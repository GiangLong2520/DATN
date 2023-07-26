using HoTroBenhNhanThan.GUI.BaseScreen;
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

namespace HoTroBenhNhanThan.GUI
{
    public partial class UrineTestWinform : Sample01
    {
        public UrineTestWinform()
        {
            InitializeComponent();
        }
        public static int turnNo;
        public static string patientName;
        public static long AppID;
        //private void cb_selectPatient_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Hashtable ht = new Hashtable();
        //    ht.Add("@day", picker_DateTime.Value.Day);
        //    ht.Add("@month", picker_DateTime.Value.Month);
        //    ht.Add("@year", picker_DateTime.Value.Year);
        //    LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);
        //}
        private void dropdown(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);
        }
        private void LoadBioTest()
        {
            ListBox loadData = new ListBox();

            loadData.Items.Add(BioIDGV);
            loadData.Items.Add(apointDateGV);
            loadData.Items.Add(patientGV);
            loadData.Items.Add(ageGV);
            loadData.Items.Add(PhoneGV);

            loadData.Items.Add(SpecificGravityGV);
            loadData.Items.Add(PHGV);
            loadData.Items.Add(LeukocytesGV);
            loadData.Items.Add(ASCGV);
            loadData.Items.Add(NitritGV);
            loadData.Items.Add(KetoneGV);
            loadData.Items.Add(UrobilinogenGV);

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
            LibCRUD.loadData("st_GetUrineTestPatientAppointmentReg", dataGridView1, loadData, ht);

            txt_phone.Text = dataGridView1.Rows[0].Cells[PhoneGV.Name].Value.ToString();
            txtage.Text = dataGridView1.Rows[0].Cells[ageGV.Name].Value.ToString();
        }

        public override void btn_Save_Click(object sender, EventArgs e)          //save btn
        {
            if (LibMainClass.checkControls(LEFTPANEL).Count > 0)
            {
                LibMainClass.showMessage("Field with RED are mandatory.", "error");

            }
            else
            {
                if (edit == 0)
                {
                    Hashtable ht = new Hashtable();
                    object selectedValue = cb_selectPatient.SelectedValue;
                    if (selectedValue != null && selectedValue != DBNull.Value)
                    {
                        AppID = Convert.ToInt64(selectedValue);
                    }

                    ht.Add("@AppID"             ,    AppID);
                    ht.Add("@SG"			  ,     Math.Round(float.Parse(txt_SG .Text.ToString()), 3));
                    ht.Add("@PH"			  ,    Math.Round(float.Parse(txt_PH.Text.ToString()), 3));
                    ht.Add("@ASC"	            ,  Math.Round(float.Parse(txt_ASC.Text.ToString()), 3));

                    ht.Add("@Leukocytes"	  ,     radio_LEUAmTinh.Checked ? true: false );
                    ht.Add("@Nitrit"		  ,     radioNitritAmtinh.Checked ? true: false);
                    ht.Add("@Ketone"		  ,     radioKetoneKhong.Checked ? true : false);
                    ht.Add("@Urobilinogen"      ,   radioUrobilKhongCo.Checked ? true: false);


                    int ret = LibCRUD.data_insert_update_delete("[st_InsertUrineTestPatientAppointmentReg]", ht);
                    if (ret > 0)
                    {
                        LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " added successfully..", "success");
                        LibMainClass.resetEnable(left_panel);
                        LoadBioTest();
                    }
                    txt_phone.Text = dataGridView1.Rows[0].Cells[PhoneGV.Name].Value.ToString();
                    txtage.Text = dataGridView1.Rows[0].Cells[ageGV.Name].Value.ToString();
                }
                else if (edit == 1)
                {
                    Hashtable ht = new Hashtable();
                    //ht.Add("@roleId", roleID);
                    //ht.Add("@newName", txt_role.Text);
                    //if (LibCRUD.data_insert_update_delete("st_updateRole", ht) > 0)
                    //{
                    //    LibMainClass.showMessage(txt_role.Text + " added successfully..", "success");
                    //    LibMainClass.resetEnable(LEFTPANEL);
                    //    LoadBioTest();
                    //}
                }

            }
        }

        public override void btn_Delete_Click(object sender, EventArgs e)          //delete btn
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure ?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@AppID", AppID);
                    if (LibCRUD.data_insert_update_delete("st_deleteRole", ht) > 0)
                    {
                        LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " deleted successfully..", "success");
                        LibMainClass.resetEnable(left_panel);
                        LoadBioTest();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadBioTest();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1 && e.ColumnIndex != -1)
            //{
            //    edit = 1;
            //    LibMainClass.DisableControl(LEFTPANEL);
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //    roleID = Convert.ToInt32(row.Cells["RoleIDGV"].Value.ToString());
            //    txt_role.Text = row.Cells["RoleGV"].Value.ToString();
            //    LibMainClass.DisableControl(left_panel);
            //}
        }


    }
}
