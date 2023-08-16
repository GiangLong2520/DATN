using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using LibCRUD;
using LibMainClass;
using HoTroBenhNhanThan.Source;

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
                SqlCommand cmd = new SqlCommand(proc, LibMainClass.LibMainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach(DictionaryEntry item in ht)
                {

                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }    
                LibMainClass.LibMainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows) {
                    r = true;
                    while (dr.Read())
                    {
                        Data.WorkingDataInstance.nameID = USERID = Convert.ToInt32(dr[0].ToString());
                        Data.WorkingDataInstance.name = NAME = dr[1].ToString();
                        Data.WorkingDataInstance.roleID = ROLEID = Convert.ToInt32(dr[2].ToString());
                        Data.WorkingDataInstance.role =ROLE = dr[3].ToString();
                    }
                }
                else
                {
                    r = false;
                    LibMainClass.LibMainClass.showMessage("Invalid UseName Or Password.", "error");
                }
                LibMainClass.LibMainClass.con.Close();
            }   catch(Exception ex)
            {
                LibMainClass.LibMainClass.con.Close();
                LibMainClass.LibMainClass.showMessage(ex.Message, "error");
            }
            return r;
        }
    }
}
