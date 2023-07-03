using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
namespace HoTroBenhNhanThan.Authentication
{
    internal class Login
    {
        private static string name, role;
        private static int  nameID, roleID;
        public static string NAME
        {
            get { return name; }
            set { name = value; }

        }
        public static string ROLE
        {
            get { return role; }
            set { role = value; }

        }
        public static int USERID
        {
            get { return nameID; }
            set { nameID = value; }

        }
        public static int ROLEID
        {
            get { return roleID; }
            set { roleID = value; }

        }
        public static bool getLoginDetails(string proc, Hashtable ht)
        {
            bool r = false;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }    
                LibMainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows) {
                    r = true;
                    while (dr.Read())
                    {
                        USERID = Convert.ToInt32(dr[0].ToString());
                        NAME = dr[1].ToString();
                        ROLEID = Convert.ToInt32(dr[2].ToString);
                        ROLE = dr[3].ToString();

                    }
                }
                else
                {
                    r = false;
                    LibMainClass.showMessage("Invalid UseName Or Password.", "error");
                }
                LibMainClass.con.Close();
            }   catch(Exception ex)
            {
                LibMainClass.showMessage(ex.Message, "error");
            }
            return r;
        }
    }
}
