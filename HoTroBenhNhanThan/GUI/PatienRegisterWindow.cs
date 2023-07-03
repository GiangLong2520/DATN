﻿using Microsoft.Data.SqlClient;
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
                SqlCommand cmd = new SqlCommand("st_CheckPatientRegisteratonExist");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                LibMainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    check = true;
                    while (dr.Read())
                    {
                        partID = Convert.ToInt64(dr["PatientID"].ToString());
                        txt_age.Text = dr["Patient"].ToString();
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
                LibMainClass.con.Close();
            }
            catch(Exception) {
                LibMainClass.con.Close();
                throw;
            }
            return check;
        }
        private void PatienRegisterWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht= new Hashtable();
            LibCRUD.loadList("st_getDocter", cb_ApointmentFor, "ID", "Docter", ht);
        }

        private void PhoneTxt_Leave(object sender, EventArgs e)
        {
            if (txt_Phone.Text != "")
            {
                if (getCheckPatientRecord(txt_Phone.Text))
                {

                }
                else
                {
                    LibMainClass.resetEnable(left_panel);
                }
            }
        }

        //-----------------------------------------------------------------------------------

        private void LoadPatient()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(patientIDGV);
            loadData.Items.Add(patientGV);
            loadData.Items.Add(GuardGV);
            loadData.Items.Add(ageGV);
            loadData.Items.Add(apointDateGV);
            loadData.Items.Add(doctorGV);
            loadData.Items.Add(DoctorIDGV);
            loadData.Items.Add(statusGV);
            loadData.Items.Add(appIDGV);

            LibCRUD.loadData("st_getPatientAppointmentRegisteration", dataGridView1, loadData);
        }

        Int64 partID;
        Int64 apointmentID;
        public override void button3_Click(object sender, EventArgs e)          //save btn
        {
            if (LibMainClass.checkControls(LEFTPANEL).Count > 0)
            {
                LibMainClass.showMessage("Field with RED are mandatory.", "error");

            }
            else
            {
                if (edit == 0)                              // code for save
                {
                    if (getCheckPatientRecord(txt_Phone.Text))
                    {
                        //LibMainClass.resetEnable(left_panel);
                        Hashtable ht = new Hashtable();
                        ht.Add("@name", txt_Patient.Text);
                        ht.Add("@guard", txt_Father.Text);
                        ht.Add("@phone", txt_Phone.Text);
                        ht.Add("@age", txt_age.Text);
                        ht.Add("@id", partID);
                        int ret = LibCRUD.data_insert_update_delete("st_updatePatientReg", ht);
                        if (ret > 0)
                        {
                            Int64 patientID =partID;

                            Hashtable htt = new Hashtable();
                            htt.Add("@date", picker_LastApointmentDate.Value);
                            htt.Add("@doctorID", Convert.ToInt32(cb_ApointmentFor.SelectedValue.ToString()));
                            htt.Add("@patientID", patientID);
                            htt.Add("@status", 0);
                            htt.Add("@day", Picker_ApointmentDate.Value.Day);
                            htt.Add("@mount", Picker_ApointmentDate.Value.Month);
                            htt.Add("@year", Picker_ApointmentDate.Value.Year);
                            if (LibCRUD.data_insert_update_delete("st_insertAppointment", htt) > 0)
                            {

                                LibMainClass.showMessage(txt_Patient.Text + " added successfully..", "success");
                                LibMainClass.resetEnable(LEFTPANEL);
                                LoadPatient();
                            }
                        }
                        else
                        {
                            LibMainClass.showMessage("Unable to save record.", "error");
                        }
                    }
                    else
                    {
                        //LibMainClass.resetEnable(left_panel);
                        Hashtable ht = new Hashtable();
                        ht.Add("@name", txt_Patient.Text);
                        ht.Add("@guard", txt_Father.Text);
                        ht.Add("@phone", txt_Phone.Text);
                        ht.Add("@age", txt_age.Text);
                        int ret = LibCRUD.data_insert_update_delete("st_insertPatientReg", ht);
                        if (ret > 0)
                        {
                            Int64 patientID = Convert.ToInt64(LibCRUD.getLastID("st_getLastPatientID"));

                            Hashtable htt = new Hashtable();
                            htt.Add("@date", picker_LastApointmentDate.Value);
                            htt.Add("@doctorID", Convert.ToInt32(cb_ApointmentFor.SelectedValue.ToString()));
                            htt.Add("@patientID", patientID);
                            htt.Add("@status", 0);
                            htt.Add("@day", Picker_ApointmentDate.Value.Day);
                            htt.Add("@mount", Picker_ApointmentDate.Value.Month);
                            htt.Add("@year", Picker_ApointmentDate.Value.Year);
                            if (LibCRUD.data_insert_update_delete("st_insertAppointment", htt) > 0)
                            {

                                LibMainClass.showMessage(txt_Patient.Text + " added successfully..", "success");
                                LibMainClass.resetEnable(LEFTPANEL);
                                LoadPatient();
                            }
                        }
                        else
                        {
                            LibMainClass.showMessage("Unable to save record.", "error");
                        }
                    }
                }
                else if (edit == 1)                        // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_Patient.Text);
                    ht.Add(@"guard", txt_Father.Text);
                    ht.Add(@"phone", txt_Phone.Text);
                    ht.Add(@"age", txt_age.Text);
                    ht.Add(@"id", partID);

                    int ret = LibCRUD.data_insert_update_delete("st_updatePatientReg", ht);
                    if (ret > 0)
                    {
                        Int64 patientID = Convert.ToInt64(LibCRUD.getLastID("st_getLastPatientID"));

                        Hashtable htt = new Hashtable();
                        htt.Add("@date", picker_LastApointmentDate.Value);
                        htt.Add("@doctorID", Convert.ToInt32(cb_ApointmentFor.SelectedValue.ToString()));
                        htt.Add("@patientID", partID);
                        htt.Add("@status", 0);
                        htt.Add("@id", apointmentID);
                        if (LibCRUD.data_insert_update_delete("st_updateAppointment", htt) > 0)
                        {

                            LibMainClass.showMessage(txt_Patient.Text + " added successfully..", "success");
                            LibMainClass.resetEnable(LEFTPANEL);
                            LoadPatient();
                        }
                    }
                    else
                    {
                        LibMainClass.showMessage("Unable to update record.", "error");
                    }
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
                    ht.Add(@"id", partID);
                    if (LibCRUD.data_insert_update_delete("st_deletePatientReg", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_Patient.Text + " deleted successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadPatient();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadPatient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.DisableControl(LEFTPANEL);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                partID = Convert.ToInt64(row.Cells["PatientIDGV"].Value.ToString());
                apointmentID = Convert.ToInt64(row.Cells["appIDGV"].Value.ToString());
                txt_Phone.Text = row.Cells["phoneGV"].Value.ToString();
                txt_Patient.Text = row.Cells["patientGV"].Value.ToString();
                txt_Father.Text = row.Cells["guardGV"].Value.ToString();
                Picker_ApointmentDate.Value = Convert.ToDateTime( row.Cells["appointDateGV"].Value.ToString());
                cb_ApointmentFor.SelectedValue = row.Cells["doctorIDGV"].Value;
                txt_age.Text = row.Cells["ageGV"].Value.ToString();
            }
        }
    }

}