using HoTroBenhNhanThan.Source;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace HoTroBenhNhanThan.GUI
{
    public partial class PatienRegisterWindow : Sample2
    {
        public PatienRegisterWindow()
        {
            InitializeComponent();
        }

        private bool getCheckPatientRecord(string phone)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_CheckPatientRegistrationExist", LibMainClass.LibMainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                LibMainClass.LibMainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    check = true;
                    while (dr.Read())
                    {
                        partID   = (long)Convert.ToUInt64(dr["PatientID"].ToString());
                        txt_Patient.Text = dr["Patient"].ToString();
                        txt_Father.Text = dr["Guardian"].ToString();
                        txt_age.Text = dr["Age"].ToString();
                        picker_LastApointmentDate.Value = Convert.ToDateTime(dr["LastAppointment"].ToString());
                        txt_consultsTo.Text = dr["Doctor"].ToString();
                        txt_Status.Text = dr["Status"].ToString();
                    }
                }
                else
                {
                    check = false;
                }               
                LibMainClass.LibMainClass.con.Close();
            }
            catch(Exception) {
                LibMainClass.LibMainClass.con.Close();
                throw;
            }
            return check;
        }
        private void PatienRegisterWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht= new Hashtable();// không có trong bài 10, nên check lại ở nội dung các bài khác
            LibCRUD.LibCRUD.loadList("st_getDoctors", cb_ApointmentFor, "ID", "Doctor", ht);
            LibMainClass.LibMainClass.resetDisable(left_panel);
        }

        private void PhoneTxt_Leave(object sender, EventArgs e)
        {
            if (txt_Phone.Text != "")
            {
                string tmp = txt_Phone.Text;
                if (getCheckPatientRecord(txt_Phone.Text))
                {

                }
                else
                {
                    LibMainClass.LibMainClass.resetEnable(left_panel);
                    txt_Phone.Text = tmp;
                }
            }
        }

        //-----------------------------------------------------------------------------------

        private void LoadPatient()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(TurnGV);
            loadData.Items.Add(patientIDGV);
            loadData.Items.Add(patientGV);
            loadData.Items.Add(GuardGV);
            loadData.Items.Add(apointDateGV);
            loadData.Items.Add(ageGV);
            loadData.Items.Add(doctorGV);
            loadData.Items.Add(DoctorIDGV);
            loadData.Items.Add(statusGV);
            loadData.Items.Add(appIDGV);
            loadData.Items.Add(phoneGV);

            LibCRUD.LibCRUD.loadData("st_GetPatientAppointmentReg", dataGridView1, loadData);
        }

        Int64 partID;
        Int64 apointmentID;
        public override void button3_Click(object sender, EventArgs e)          //save btn
        {
            if (LibMainClass.LibMainClass.checkControls(left_panel, edit).Count > 0)
            {
                LibMainClass.LibMainClass.showMessage("Field with RED are mandatory.", "error");

            }
            else
            {

                using (TransactionScope sc = new TransactionScope()) {
                    // check code for save in : 39;47 - 39;51
                    if (edit == 0)                              // code for save
                    {
                        if (getCheckPatientRecord(txt_Phone.Text))
                        {
                            //LibMainClass.LibMainClass.resetEnable(left_panel);
                            Hashtable ht = new Hashtable();
                            ht.Add("@name", txt_Patient.Text);
                            ht.Add("@guard", txt_Father.Text);
                            ht.Add("@phone", txt_Phone.Text);
                            ht.Add("@age",  txt_age.Text);
                            ht.Add("@id", partID);
                            int ret = LibCRUD.LibCRUD.data_insert_update_delete("st_updatePatientReg", ht); //  LibCRUD.LibCRUD.data_insert_update_delete("st_insertPatientReg", ht) 55;03
                            if (ret > 0)
                            {
                               // Int64 patientID = Convert.ToInt64(LibCRUD.LibCRUD.getLastID("st_getlastPatientID")); 
                                Hashtable htt = new Hashtable();
                                htt.Add("@date", Picker_ApointmentDate.Value);
                                htt.Add("@doctorID", Convert.ToInt32(cb_ApointmentFor.SelectedValue.ToString()));
                                htt.Add("@patientID", partID);
                                htt.Add("@status", 0);
                                htt.Add("@day", picker_LastApointmentDate.Value.Day);
                                htt.Add("@month", picker_LastApointmentDate.Value.Month);
                                htt.Add("@year", picker_LastApointmentDate.Value.Year);
                                if (LibCRUD.LibCRUD.data_insert_update_delete("st_insertAppointment", htt) > 0)
                                {
                                    // Write Log
                                    LogControler.WriteLog("st_insertAppointment", htt);
                                    LibMainClass.LibMainClass.showMessage(txt_Patient.Text + " added successfully..", "success");
                                    LibMainClass.LibMainClass.resetDisable(left_panel);
                                    LoadPatient();
                                }
                            }
                            else
                            {
                                LibMainClass.LibMainClass.showMessage("Unable to save record.", "error");
                            }
                        }
                        else
                        {
                            //LibMainClass.LibMainClass.resetEnable(left_panel);
                            Hashtable ht = new Hashtable();
                            ht.Add("@name", txt_Patient.Text);
                            ht.Add("@guard", txt_Father.Text);
                            ht.Add("@phone", txt_Phone.Text);
                            ht.Add("@age", txt_age.Text);
                            // ht.Add("@id", partID);
                            int ret = LibCRUD.LibCRUD.data_insert_update_delete("st_insertPatientReg", ht); //  LibCRUD.LibCRUD.data_insert_update_delete("st_insertPatientReg", ht) 55;03
                            // Write Log
                            LogControler.WriteLog("st_insertPatientReg", ht);                                                      

                            if (ret > 0)
                            {
                                Int64 patientID = Convert.ToInt64(LibCRUD.LibCRUD.getLastID("st_getlastPatientID"));
                                Hashtable htt = new Hashtable();
                                htt.Add("@date", picker_LastApointmentDate.Value);
                                htt.Add("@doctorID", Convert.ToInt32(cb_ApointmentFor.SelectedValue.ToString()));
                                htt.Add("@patientID", patientID);
                                htt.Add("@status", 0);
                                htt.Add("@day", Picker_ApointmentDate.Value.Day);
                                htt.Add("@month", Picker_ApointmentDate.Value.Month);
                                htt.Add("@year", Picker_ApointmentDate.Value.Year);
                                if (LibCRUD.LibCRUD.data_insert_update_delete("st_insertAppointment", htt) > 0)
                                {
                                    // Write Log
                                    LogControler.WriteLog("st_insertAppointment", htt);
                                    LibMainClass.LibMainClass.showMessage(txt_Patient.Text + " added successfully..", "success");
                                    LibMainClass.LibMainClass.resetDisable(left_panel);
                                    LoadPatient();
                                }
                            }
                            else
                            {
                                LibMainClass.LibMainClass.showMessage("Unable to save record.", "error");
                            }
                        }
                    }
                    else if (edit == 1)                        // code for update  1;19;08 - 
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add(@"name", txt_Patient.Text);
                        ht.Add(@"guard", txt_Father.Text);
                        ht.Add(@"phone", txt_Phone.Text);
                        ht.Add(@"age", txt_age.Text);
                        ht.Add(@"id", partID);

                        int ret = LibCRUD.LibCRUD.data_insert_update_delete("st_updatePatientReg", ht);
                        // Write Log
                        LogControler.WriteLog("st_updatePatientReg", ht);
                        if (ret > 0)
                        {
                            // Int64 patientID = Convert.ToInt64(LibCRUD.LibCRUD.getLastID("st_getLastPatientID"));

                            Hashtable htt = new Hashtable();
                            htt.Add("@date", picker_LastApointmentDate.Value);
                            htt.Add("@doctorID", Convert.ToInt32(cb_ApointmentFor.SelectedValue.ToString()));
                            htt.Add("@patientID", partID);
                            htt.Add("@status", 0);
                            htt.Add("@id", apointmentID);
                            if (LibCRUD.LibCRUD.data_insert_update_delete("st_updateAppointment", htt) > 0)
                            {
                                // Write Log
                                LogControler.WriteLog("st_updateAppointment", htt);
                                LibMainClass.LibMainClass.showMessage(txt_Patient.Text + " update successfully..", "success");
                                LibMainClass.LibMainClass.resetEnable(left_panel);
                                LoadPatient();
                            }
                        }
                        else
                        {
                            LibMainClass.LibMainClass.showMessage("Unable to update record.", "error");
                        }
                    }
                    sc.Complete();
                }
            }
        }

        public override void button4_Click(object sender, EventArgs e)          //delete btn
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure ?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"id", apointmentID);
                    if (LibCRUD.LibCRUD.data_insert_update_delete("[st_deleteAppointment]", ht) > 0)
                    {
                        // Write Log
                        LogControler.WriteLog("st_deleteAppointment", ht);
                        LibMainClass.LibMainClass.showMessage(txt_Patient.Text + " appointment deleted appointment successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
                        LoadPatient();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadPatient();
        }
        private void txt_Patient_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                partID = Convert.ToInt64(row.Cells["patientIDGV"].Value.ToString());
                apointmentID = Convert.ToInt64(row.Cells["appIDGV"].Value.ToString());
                txt_Phone.Text = row.Cells["phoneGV"].Value.ToString();
                txt_Patient.Text = row.Cells["patientGV"].Value.ToString();
                txt_Father.Text = row.Cells["guardGV"].Value.ToString();
                Picker_ApointmentDate.Value = Convert.ToDateTime(row.Cells["apointDateGV"].Value.ToString());
                cb_ApointmentFor.SelectedValue = row.Cells["doctorIDGV"].Value;
                txt_age.Text = row.Cells["ageGV"].Value.ToString();
                getCheckPatientRecord(txt_Phone.Text);
                LibMainClass.LibMainClass.DisableControl(left_panel);
            }
        }
    }
}
