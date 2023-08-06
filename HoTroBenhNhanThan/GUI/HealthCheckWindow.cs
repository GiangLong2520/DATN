using HoTroBenhNhanThan.GUI.BaseScreen;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace HoTroBenhNhanThan.GUI
{
    public partial class HealthCheckWindow : Sample01
    {

        long AppID = -1;
        long PatientID = -1;

        public HealthCheckWindow()
        {
            InitializeComponent();
        }

        private void loadTodayPatient()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
             LibCRUD.LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);
        }
        private void HealthCheckWindow_Load(object sender, EventArgs e)
        {
            loadTodayPatient();

            Hashtable ht = new Hashtable();
             LibCRUD.LibCRUD.loadList("[st_getDisease]", cb_disease_name, "ID", "Disease", ht);
             LibCRUD.LibCRUD.loadList("[st_getSymptoms]", cb_symptom, "SymptomID", "Symptom", ht);

            Hashtable ht1 = new Hashtable();
            ht1.Add("@type", 0);
             LibCRUD.LibCRUD.loadList("st_getMedicineType", cb_DescripInternal, "ID", "Medicine", ht1);

            Hashtable ht2 = new Hashtable();
            ht2.Add("@type", 1);
             LibCRUD.LibCRUD.loadList("st_getMedicineType", cb_DescripExternal, "ID", "Medicine", ht2);

           
        }
        void setTestResult(int bioTest, int uretest, int bloodTest)
        {
            txt_testResults.Text += "Bio Test: " + ((bioTest == -1) ? "UnKnow" : ((bioTest==1) ? "Consulted" : "Not Consult"));
            txt_testResults.Text += "\nUrine Test: " + ((uretest == -1) ? "UnKnow" : ((uretest == 1) ? "Consulted" : "Not Consult"));
            txt_testResults.Text += "\nBlood Test: " + ((bloodTest == -1) ? "UnKnow" : ((bloodTest == 1) ? "Consulted" : "Not Consult"));
        }
        public static int turnNo;
        public static string patentName;
        private void btnCall_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            ht.Add("@partID", Convert.ToInt64(cb_selectPatient.SelectedValue).ToString());
            turnNo =  LibCRUD.LibCRUD.getTurnNumber("st_getTurnNumberWRTpatientWRTToday", ht);

        }

        private void Dropdown(object sender, EventArgs e)
        {
            loadTodayPatient();

        }

        public override void btn_Save_Click(object sender, EventArgs e)          //save btn
        {
            if (LibMainClass.LibMainClass.checkControls(LEFTPANEL).Count > 0)
            {
                LibMainClass.LibMainClass.showMessage("Field with RED are mandatory.", "error");

            }
            else
            {
                if(AppID== -1) {
                    LibMainClass.LibMainClass.showMessage("Please select the patient", "warning");
                    return;
                }
                if (edit == 0)
                {
                    using(TransactionScope sc = new TransactionScope() )
                    {
                        // disease data               //
                        foreach (string item in lb_diseasesList.Items)
                        {
                            Hashtable h = new Hashtable();
                            h.Add("@disease", item);
                            if(!CheckExistance("st_checkExistDisease", h))
                            {
                                 LibCRUD.LibCRUD.data_insert_update_delete("st_insertDisease", h);
                            }

                            int diseaseID = getDiseaseIDFromName(item);

                            Hashtable htpatientDisease    = new Hashtable();
                            object selectedValue = cb_selectPatient.SelectedValue;
                            if (selectedValue != null && selectedValue != DBNull.Value)
                            {
                                AppID = Convert.ToInt64(selectedValue);
                            }
                            htpatientDisease.Add("@appID", AppID);
                            htpatientDisease.Add("@diseaseID", diseaseID);
                             LibCRUD.LibCRUD.data_insert_update_delete("[st_insertPatientDisease]", htpatientDisease);
                        }

                        // symptom data            //
                        foreach (string item in lb_symptomList.Items)
                        {
                            Hashtable h = new Hashtable();
                            h.Add("@symptom", item);
                            if (!CheckExistance("st_checkExistSymptom", h))
                            {
                                 LibCRUD.LibCRUD.data_insert_update_delete("st_insertSymptom", h);
                            }

                            int symptomID = getsymptomIDFromName(item);

                            Hashtable htpatientDisease = new Hashtable();
                            object selectedValue = cb_selectPatient.SelectedValue;
                            if (selectedValue != null && selectedValue != DBNull.Value)
                            {
                                AppID = Convert.ToInt64(selectedValue);
                            }
                            htpatientDisease.Add("@appID", AppID);
                            htpatientDisease.Add("@symptomID", symptomID);
                             LibCRUD.LibCRUD.data_insert_update_delete("[st_insertPatientSymptom]", htpatientDisease);
                        }


                        // decription internal data   //
                        foreach (string item in lb_desInternal.Items)
                        {
                            string[] arr = item.Split('|');

                            Hashtable h = new Hashtable();
                            h.Add("@name", arr[0]);
                            h.Add("@type", 0);
                            if (!CheckExistance("st_checkExistMedicine", h))
                            {
                                 LibCRUD.LibCRUD.data_insert_update_delete("st_insertMedicineOnlyName", h);
                            }

                            int descriptionID = getMedicineIDFromName(arr[0]);

                            Hashtable ht = new Hashtable();
                            object selectedValue = cb_selectPatient.SelectedValue;
                            if (selectedValue != null && selectedValue != DBNull.Value)
                            {
                                AppID = Convert.ToInt64(selectedValue);
                            }
                            ht.Add("@appID", AppID);
                            ht.Add("@descriptionID", descriptionID);


                            int dosage=0;
                            if (htInternal.ContainsKey(arr[0]))
                            {
                                if (htInternal[arr[0]] is int value)
                                {
                                   dosage = Convert.ToInt32(value);
                                }
                                else
                                {
                                    Console.WriteLine("Giá trị không phải kiểu int.");
                                }
                            }
                            else
                            {
                                // Xử lý khi không tìm thấy key trong Hashtable
                                Console.WriteLine("Không tìm thấy key trong Hashtable.");
                            }
                            if (dosage == 6)
                            {
                                ht.Add("@other", txt_otherInternal.Text);
                                 LibCRUD.LibCRUD.data_insert_update_delete("st_insertPatientDescription", ht);
                            }
                            else
                            {
                                 LibCRUD.LibCRUD.data_insert_update_delete("st_insertPatientDescription", ht);
                            }
                        }

                                                       
                        // decription external data    //
                        foreach (string item in lb_desExternal.Items)
                        {
                            string[] arr = item.Split('|');

                            Hashtable h = new Hashtable();
                            h.Add("@name", arr[0]);
                            h.Add("@type", 0);
                            if (!CheckExistance("st_checkExistMedicine", h))
                            {
                                 LibCRUD.LibCRUD.data_insert_update_delete("st_insertMedicineOnlyName", h);
                            }

                            int descriptionID = getMedicineIDFromName(arr[0]);

                            Hashtable ht = new Hashtable();
                            object selectedValue = cb_selectPatient.SelectedValue;
                            if (selectedValue != null && selectedValue != DBNull.Value)
                            {
                                AppID = Convert.ToInt64(selectedValue);
                            }
                            ht.Add("@appID", AppID);
                            ht.Add("@descriptionID", descriptionID);


                            int dosage = 0;
                            if (htExternal.ContainsKey(arr[0]))
                            {
                                if (htExternal[arr[0]] is int value)
                                {
                                    dosage = Convert.ToInt32(value);
                                }
                                else
                                {
                                    Console.WriteLine("Giá trị không phải kiểu int.");
                                }
                            }
                            else
                            {
                                // Xử lý khi không tìm thấy key trong Hashtable
                                Console.WriteLine("Không tìm thấy key trong Hashtable.");
                            }

                            ht.Add("@dosage", dosage);
                            if (dosage == 6)
                            {
                                ht.Add("@other", txt_ExternalOther.Text);
                                 LibCRUD.LibCRUD.data_insert_update_delete("st_insertPatientDescription", ht);
                            }
                            else
                            {
                                 LibCRUD.LibCRUD.data_insert_update_delete("st_insertPatientDescription", ht);
                            }
                        }



                        // Remark and fees
                        Hashtable htRemFee= new Hashtable();
                        htRemFee.Add("@appID", AppID);
                        htRemFee.Add("@remark", txt_rem.Text);
                        htRemFee.Add("@fees", txt_fees.Text);
                         LibCRUD.LibCRUD.data_insert_update_delete("st_insertpatientHealthCheckup", htRemFee);



                        // Update apointment done
                        Hashtable htAppStaus = new Hashtable();
                        htAppStaus.Add("@appID", AppID);
                        htAppStaus.Add("@status", 1);
                         LibCRUD.LibCRUD.data_insert_update_delete("st_updateAppointmentStatus", htRemFee);

                        LibMainClass.LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " Health checkup successfully..", "success");

                        sc.Complete();
                    }



                }
                else if (edit == 1)
                {
                    //Hashtable ht = new Hashtable();
                    //ht.Add("@ID", urineID);
                    //ht.Add("@SG", Math.Round(float.Parse(txt_SG.Text.ToString()), 3));
                    //ht.Add("@PH", Math.Round(float.Parse(txt_PH.Text.ToString()), 3));
                    //ht.Add("@ASC", Math.Round(float.Parse(txt_ASC.Text.ToString()), 3));

                    //ht.Add("@Leukocytes", radio_LEUAmTinh.Checked ? true : false);
                    //ht.Add("@Nitrit", radioNitritAmtinh.Checked ? true : false);
                    //ht.Add("@Ketone", radioKetoneKhong.Checked ? true : false);
                    //ht.Add("@Urobilinogen", radioUrobilKhongCo.Checked ? true : false);


                    //int ret =  LibCRUD.LibCRUD.data_insert_update_delete("[st_UpdateUrineTestPatientAppointmentReg]", ht);
                    //if (ret > 0)
                    //{
                    //    LibMainClass.LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " Update successfully..", "success");
                    //    LibMainClass.LibMainClass.resetEnable(left_panel);
                    //    LoadUrineTest();
                    //}
                }

            }
        }

        public override void btn_Delete_Click(object sender, EventArgs e)          //delete btn
        {
            if (edit == 1)
            {
                //DialogResult dr = MessageBox.Show("Are you sure ?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dr == DialogResult.Yes)
                //{
                //    Hashtable ht = new Hashtable();
                //    ht.Add("@ID", urineID);
                //    if ( LibCRUD.LibCRUD.data_insert_update_delete("st_DeleteUrineTestPatientAppointmentReg", ht) > 0)
                //    {
                //        LibMainClass.LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " deleted successfully..", "success");
                //        LibMainClass.LibMainClass.resetEnable(left_panel);
                //        LoadUrineTest();
                //    }
                //}
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            //Hashtable ht = new Hashtable();
            //ht.Add("@day", picker_DateTime.Value.Day);
            //ht.Add("@month", picker_DateTime.Value.Month);
            //ht.Add("@year", picker_DateTime.Value.Year);
            // LibCRUD.LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);

            getInforPatientReg();
            setTestResult(-1, -1, -1);
        }


        ////////////////////////////////////////////////////////////////

        Hashtable htInternal = new Hashtable();
        Hashtable htExternal = new Hashtable();
        // internal description
        private void btn_DesInternalAdd_Click(object sender, EventArgs e)
        {
            if(cb_DescripInternal.Text == null)
            {
                LibMainClass.LibMainClass.showMessage("Please select medicine", "warning");
            }   
            else
            {                                              
                if (!lb_desInternal.Items.Contains(cb_DescripInternal.Text))
                {
                    if(!radio_0InM.Checked && !radio_1InME.Checked && !radio_2InMEN.Checked && !radio_3InBE.Checked && !radioIn_4AE.Checked && !radioIn_5BS.Checked && !radio_6internalOther.Checked)
                    {
                        LibMainClass.LibMainClass.showMessage("Please sellect dosage for the medicine", "warning");
                    }
                    else
                    {
                        if (radio_0InM.Checked)
                        {
                            htInternal.Add(cb_DescripInternal.Text, 0);
                            lb_desInternal.Items.Add(cb_DescripInternal.Text + "|" + radio_0InM.Text);
                        }
                        else if (radio_1InME.Checked)
                        {
                            htInternal.Add(cb_DescripInternal.Text, 1);
                            lb_desInternal.Items.Add(cb_DescripInternal.Text + "|" + radio_1InME.Text);
                        }
                        else if (radio_2InMEN.Checked)
                        {
                            htInternal.Add(cb_DescripInternal.Text, 2);
                            lb_desInternal.Items.Add(cb_DescripInternal.Text + "|" + radio_2InMEN.Text);
                        }
                        else if (radio_3InBE.Checked)
                        {
                            htInternal.Add(cb_DescripInternal.Text, 3);
                            lb_desInternal.Items.Add(cb_DescripInternal.Text + "|" + radio_3InBE.Text);
                        }
                        else if (radioIn_4AE.Checked)
                        {
                            htInternal.Add(cb_DescripInternal.Text, 4);
                            lb_desInternal.Items.Add(cb_DescripInternal.Text + "|" + radioIn_4AE.Text);
                        }
                        else if (radioIn_5BS.Checked)
                        {
                            htInternal.Add(cb_DescripInternal.Text, 5);
                            lb_desInternal.Items.Add(cb_DescripInternal.Text + "|" + radioIn_5BS.Text);
                        }
                        else if (radio_6internalOther.Checked)
                        {
                            if (txt_otherInternal.Text == "")
                            {
                                LibMainClass.LibMainClass.showMessage("Plese Input other dosage", "warning");
                            }
                            else
                            {
                                htInternal.Add(cb_DescripInternal.Text, 6);
                                lb_desInternal.Items.Add(cb_DescripInternal.Text + "|" + txt_otherInternal.Text);
                            }
                        }

                        radio_0InM.Checked = false;
                        radio_1InME.Checked = false;
                        radio_2InMEN.Checked = false;
                        radio_3InBE.Checked = false;
                        radioIn_4AE.Checked = false;
                        radioIn_5BS.Checked = false;
                        radio_6internalOther.Checked = false;
                        txt_otherInternal.Text = "";
                        cb_DescripInternal.SelectedIndex = -1;
                    }
                }
            }
        }

        private void btn_DesInternalRemove_Click(object sender, EventArgs e)
        {
            if (lb_desInternal.Items.Count > 0)
            {
                string[] arr = lb_desInternal.SelectedItems[0].ToString().Split('|');
                htInternal.Remove(arr[0]);
                lb_desInternal.Items.Remove(lb_desInternal.SelectedItems[0]);
            }
        }


        // External description
        private void btn_DesExteralAdd_Click(object sender, EventArgs e)
        {
            if (cb_DescripExternal.SelectedIndex == -1)                           
            {
                LibMainClass.LibMainClass.showMessage("Please select medicine", "warning");
            }
            else
            {
                if (!lb_desExternal.Items.Contains(cb_DescripExternal.Text))
                {
                    if (!radio0ExM.Checked && !radio1ExME.Checked && !radio2ExMEN.Checked && !radio3ExBE.Checked && !radio4ExAE.Checked && !radio5ExBS.Checked && !radio6EXother.Checked)
                    {
                        LibMainClass.LibMainClass.showMessage("Please sellect dosage for the medicine", "warning");
                    }
                    else
                    {
                        if (radio0ExM.Checked)
                        {
                            htExternal.Add(cb_DescripExternal.Text, 0);
                            lb_desExternal.Items.Add(cb_DescripExternal.Text + "|" + radio0ExM.Text);
                        }
                        else if (radio_1InME.Checked)
                        {
                            htExternal.Add(cb_DescripExternal.Text, 1);
                            lb_desExternal.Items.Add(cb_DescripExternal.Text + "|" + radio_1InME.Text);
                        }
                        else if (radio2ExMEN.Checked)
                        {
                            htExternal.Add(cb_DescripExternal.Text, 2);
                            lb_desExternal.Items.Add(cb_DescripExternal.Text + "|" + radio2ExMEN.Text);
                        }
                        else if (radio3ExBE.Checked)
                        {
                            htExternal.Add(cb_DescripExternal.Text, 3);
                            lb_desExternal.Items.Add(cb_DescripExternal.Text + "|" + radio3ExBE.Text);
                        }
                        else if (radio4ExAE.Checked)
                        {
                            htExternal.Add(cb_DescripExternal.Text, 4);
                            lb_desExternal.Items.Add(cb_DescripExternal.Text + "|" + radio4ExAE.Text);
                        }
                        else if (radio5ExBS.Checked)
                        {
                            htExternal.Add(cb_DescripExternal.Text, 5);
                            lb_desExternal.Items.Add(cb_DescripExternal.Text + "|" + radio5ExBS.Text);
                        }
                        else if (radio6EXother.Checked)
                        {
                            if (txt_ExternalOther.Text == "")
                            {
                                LibMainClass.LibMainClass.showMessage("Plese Input other dosage", "warning");
                            }
                            else
                            {
                                htInternal.Add(cb_DescripExternal.Text, 6);
                                lb_desExternal.Items.Add(cb_DescripExternal.Text + "|" + txt_ExternalOther.Text);
                            }
                        }

                        radio0ExM.Checked = false;
                        radio1ExME.Checked = false;
                        radio2ExMEN.Checked = false;
                        radio3ExBE.Checked = false;
                        radio4ExAE.Checked = false;
                        radio5ExBS.Checked = false;
                        radio6EXother.Checked = false;
                        txt_ExternalOther.Text = "";
                        cb_DescripExternal.SelectedIndex = -1;

                    }
                }
            }
        }

        private void btn_DesExternalRemove_Click(object sender, EventArgs e)
        {
            if (lb_desExternal.Items.Count > 0)
            {
                char[] c = { '|' };
                string[] arr = lb_desExternal.SelectedItems[0].ToString().Split(c);
                htExternal.Remove(arr[0]);
                lb_desExternal.Items.Remove(lb_desExternal.SelectedItems[0]);
            }
        }


        // disease
        private void btn_disease_add_Click(object sender, EventArgs e)
        {
            if(cb_disease_name.Text!= null)
            {
                if (!lb_diseasesList.Items.Contains(cb_disease_name.Text))
                {
                    lb_diseasesList.Items.Add(cb_disease_name.Text);
                }
            }
        }

        private void btn_disease_remove_Click(object sender, EventArgs e)
        {
            if (lb_diseasesList.Items.Contains(cb_disease_name.Text))
            {
                lb_diseasesList.Items.Remove(cb_disease_name.Text);

            }
        }

  

        // symptom
        private void btn_symtomAdd_Click(object sender, EventArgs e)
        {
            if (cb_symptom.Text != null)
            {
                if (!lb_symptomList.Items.Contains(cb_symptom.Text))
                {
                    lb_symptomList.Items.Add(cb_symptom.Text);
                }
            }
        }

        private void btn_symptomRemove_Click(object sender, EventArgs e)
        {
            if (lb_symptomList.Items.Contains(cb_symptom.Text))
            {
                lb_symptomList.Items.Remove(cb_symptom.Text);
            }
        }





        // getdata
        public void getInforPatientReg()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[st_GetPatientInforReg]", LibMainClass.LibMainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                Hashtable ht = new Hashtable();
                ht.Add("@day", picker_DateTime.Value.Day);
                ht.Add("@month", picker_DateTime.Value.Month);
                ht.Add("@year", picker_DateTime.Value.Year);

                object selectedValue = cb_selectPatient.SelectedValue;
                if (selectedValue != null && selectedValue != DBNull.Value)
                {
                    AppID = Convert.ToInt64(selectedValue);
                }
                ht.Add("@appID", AppID);

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    PatientID =  Convert.ToInt32(row["ID"]); // Lấy giá trị của cột "ID" tại hàng hiện tại
                    txt_phone.Text = row["Phone"].ToString(); // Lấy giá trị của cột "Name" tại hàng hiện tại
                    txtage.Text = row["Age"].ToString();
                    // Sử dụng các giá trị lấy được ở đây...
                }

            }
            catch (Exception ex)
            {
                LibMainClass.LibMainClass.showMessage(ex.Message, "error");

            }
        }

        private int getDiseaseIDFromName(string name)
        {
            int did = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDiseaseIDFromName", LibMainClass.LibMainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                LibMainClass.LibMainClass.con.Open();
                did = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                LibMainClass.LibMainClass.con.Close();
            }   catch(Exception ex)
            {
                LibMainClass.LibMainClass.con.Close();
            }
            return did;
        }

        private int getsymptomIDFromName(string name)
        {
            int did = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getsymptomIDIDFromName", LibMainClass.LibMainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                LibMainClass.LibMainClass.con.Open();
                did = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                LibMainClass.LibMainClass.con.Close();
            }
            catch (Exception ex)
            {
                LibMainClass.LibMainClass.con.Close();
            }
            return did;
        }
        private int getMedicineIDFromName(string name)
        {
            int did = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getMedicineIDFromName", LibMainClass.LibMainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                LibMainClass.LibMainClass.con.Open();
                did = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                LibMainClass.LibMainClass.con.Close();
            }
            catch (Exception ex)
            {
                LibMainClass.LibMainClass.con.Close();
            }
            return did;
        }



        private bool CheckExistance(string proc, Hashtable ht)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, LibMainClass.LibMainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value.ToString());
                }
                LibMainClass.LibMainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                LibMainClass.LibMainClass.con.Close();
            }
            catch (Exception ex)
            {
                LibMainClass.LibMainClass.con.Close();
            }
            return check;
        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }
    }
}
                                