//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.DirectoryServices;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HoTroBenhNhanThan
//{
//    public class LibCRUD
//    {
//        public static int data_insert_update_delete(string proc , Hashtable ht)
//        {
//            int res = 0;
//            try
//            {
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = System.Data.CommandType.StoredProcedure;
//                foreach(DictionaryEntry item in ht)
//                {
//                    cmd.Parameters.AddWithValue(item.Key.ToString(),item.Value);
//                }     
//                LibMainClass.con.Open();
//                res = cmd.ExecuteNonQuery();
//                LibMainClass.con.Close();
//            }
//            catch(Exception ex)
//            {
//                LibMainClass.con.Close();
//                LibMainClass.showMessage(ex.Message, "error");
//            }
//            return res;
//        }
//        public static DataTable LoadDataTable(string sql)
//        {
//            DataTable dt = new DataTable();
//            SqlCommand cmd = new SqlCommand(sql, LibMainClass.con);
//            cmd.CommandType = CommandType.Text;
//            SqlDataAdapter da = new SqlDataAdapter(cmd);
//            da.Fill(dt);
//            return dt;
//        }

//        public static void loadData(string proc,DataGridView gv, ListBox lb)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                SqlDataAdapter da =  new SqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                da.Fill(dt);

//                foreach (DataRow row in dt.Rows)
//                {
//                    for (int i = 0; i < dt.Columns.Count; i++)
//                    {
//                        row[i] = row[i].ToString().Trim();
//                    }
//                }
//                for (int i = 0; i<lb.Items.Count; i++)
//                {
//                    string colName = ((DataGridViewColumn)lb.Items[i]).Name;
//                    gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();

//                }
//                gv.DataSource= dt;
//                int count = 0;                                              
//                foreach(DataGridViewRow row in gv.Rows)
//                {
//                    count++;
//                    row.Cells[0].Value = count;
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        public static void loadList(string proc, ComboBox cb, string valueNumber, string displayMember, Hashtable ht) {
//            try
//            {                                                      
//               // cb.Items.Clear();
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                foreach(DictionaryEntry item in ht)
//                {
//                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
//                }
//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                da.Fill(dt);
//                cb.DisplayMember= displayMember;
//                cb.ValueMember= valueNumber;
//                cb.DataSource= dt;
//                cb.SelectedIndex = -1;
//            }
//            catch(Exception ex)
//            {
//                LibMainClass.showMessage(ex.Message, "error");

//            } 
//        }

//        public static void loadRole( ComboBox cb)
//        {
//            string proc = "st_getAllRole";
//            try
//            {
//                // cb.Items.Clear();
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                da.Fill(dt);
//                cb.DisplayMember = "Name";
//                cb.ValueMember = "ID";
//                cb.DataSource = dt;
//                cb.SelectedIndex = -1;
//            }
//            catch (Exception ex)
//            {
//                LibMainClass.showMessage(ex.Message, "error");

//            }
//        }

//        public static void loadDisease(ComboBox cb)
//        {
//            string proc = "st_getAllDisease";
//            try
//            {
//                // cb.Items.Clear();
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                da.Fill(dt);
//                cb.DisplayMember = "Name";
//                cb.ValueMember = "ID";
//                cb.DataSource = dt;
//                cb.SelectedIndex = -1;
//            }
//            catch (Exception ex)
//            {
//                LibMainClass.showMessage(ex.Message, "error");

//            }
//        }

//        public static void loadData(string proc, DataGridView gv, ListBox lb, Hashtable ht)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                foreach (DictionaryEntry item in ht)
//                {
//                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
//                }
//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                da.Fill(dt);
//                for (int i = 0; i < lb.Items.Count; i++)
//                {
//                    string colName = ((DataGridViewColumn)lb.Items[i]).Name;
//                    //if (colName.Equals("NhomMauGV")) { }
//                    gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString().TrimEnd().TrimStart();
//                }
//                gv.DataSource = dt;
//                int count = 0;
//                foreach (DataGridViewRow row in gv.Rows)
//                {
//                    count++;
//                    row.Cells[0].Value = count;
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

    
//        public static int getTurnNumber(string proc, Hashtable ht)
//        {

//            int turnNo = 0;
//            try
//            {
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                foreach (DictionaryEntry item in ht)
//                {
//                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
//                }

//                LibMainClass.con.Open();
//                turnNo = Convert.ToInt32(cmd.ExecuteScalar().ToString());
//                LibMainClass.con.Close();
//            }
//            catch (Exception ex)
//            {
//                LibMainClass.showMessage(ex.Message, "error");

//            }
//            return turnNo;
//        }
//        public static object getLastID(string proc)
//        {
//            object o = null;
//            try
//            {
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                LibMainClass.con.Open();
//                o = cmd.ExecuteScalar();
//                LibMainClass.con.Close();
//            }
//            catch (Exception ex)
//            {
//                LibMainClass.con.Close();
//                LibMainClass.showMessage(ex.Message, "error");

//            }      
//            return o;
//        }

//        // health check function
//        public static void getInforPatientReg(string proc, DateTimePicker date, TextBox text, Hashtable ht)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand(proc, LibMainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                foreach (DictionaryEntry item in ht)
//                {
//                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
//                }

//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                da.Fill(dt);


//            }
//            catch (Exception ex)
//            {
//                LibMainClass.showMessage(ex.Message, "error");

//            }
//        }
//    }
//}
