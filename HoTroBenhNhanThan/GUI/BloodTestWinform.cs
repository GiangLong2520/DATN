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
    public partial class BloodTestWinform : Sample01
    {
        public static int turnNo;
        public static string patientName;
        public static long AppID;
        public BloodTestWinform()
        {
            InitializeComponent();
        }

        private void LoadBioTest()
        {
            ListBox loadData = new ListBox();

            loadData.Items.Add(BioIDGV);
            loadData.Items.Add(apointDateGV);
            loadData.Items.Add(patientGV);
            loadData.Items.Add(ageGV);
            loadData.Items.Add(PhoneGV);

            loadData.Items.Add(HongCauGV);
            loadData.Items.Add(PhanBoHongCauGV);
            loadData.Items.Add(BachCauGV);
            loadData.Items.Add(PhanBoBachCauGV);
            loadData.Items.Add(TieuCauGV);
            loadData.Items.Add(PhanBoTieuCauGV);
            loadData.Items.Add(NhomMauGV);
            loadData.Items.Add(HuyetSacToGV);
            loadData.Items.Add(MCVGV);
            loadData.Items.Add(MCNGV);
            loadData.Items.Add(MCNCGV);

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
            LibCRUD.LibCRUD.loadData("st_GetBloodTestPatientAppointmentReg", dataGridView1, loadData, ht);

           // txt_phone.Text = dataGridView1.Rows[0].Cells[PhoneGV.Name].Value.ToString();
            //txtage.Text = dataGridView1.Rows[0].Cells[ageGV.Name].Value.ToString();
        }


        private void selectPatientDown(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);
        }


        public override void btn_Save_Click(object sender, EventArgs e)          //save btn
        {
            if (LibMainClass.LibMainClass.checkControls(LEFTPANEL).Count > 0)
            {
                LibMainClass.LibMainClass.showMessage("Field with RED are mandatory.", "error");

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

                    ht.Add("@AppID",                AppID);
                    ht.Add("@HongCauGV",            Math.Round(float.Parse(txt_hongCau.Text.ToString()), 3));
                    ht.Add("@PhanBoHongCauGV",        Math.Round(float.Parse(txt_pbHongCau.Text.ToString()), 3));
                    ht.Add("@BachCauGV",              Math.Round(float.Parse(txt_bachCau.Text.ToString()), 3));
                    ht.Add("@PhanBoBachCauGV",        Math.Round(float.Parse(txt_pbBachCau.Text.ToString()), 3));
                    ht.Add("@TieuCauGV",              Math.Round(float.Parse(txt_TieuCau .Text.ToString()), 3));
                    ht.Add("@PhanBoTieuCauGV",      Math.Round(float.Parse(txt_pbTieuCau.Text.ToString()), 3));
                    ht.Add("@NhomMauGV",            txt_NhomMau.Text.ToString());
                    ht.Add("@HuyetSacToGV",           Math.Round(float.Parse(txt_huyetSacTo.Text.ToString()), 3));
                    ht.Add("@MCVGV",                  Math.Round(float.Parse(txt_MCV.Text.ToString()), 3));
                    ht.Add("@MCNGV",                  Math.Round(float.Parse(txt_MCN.Text.ToString()), 3));
                    ht.Add("@txt_MCNC",                Math.Round(float.Parse(txt_MCNC.Text.ToString()), 3));


                    int ret = LibCRUD.LibCRUD.data_insert_update_delete("[st_InsertBloodTestPatientAppointmentReg]", ht);
                    if (ret > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " added successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
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
                    //if (LibCRUD.LibCRUD.data_insert_update_delete("st_updateRole", ht) > 0)
                    //{
                    //    LibMainClass.LibMainClass.showMessage(txt_role.Text + " added successfully..", "success");
                    //    LibMainClass.LibMainClass.resetEnable(LEFTPANEL);
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
                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_deleteRole", ht) > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " deleted successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
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
            //    LibMainClass.LibMainClass.DisableControl(LEFTPANEL);
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //    roleID = Convert.ToInt32(row.Cells["RoleIDGV"].Value.ToString());
            //    txt_role.Text = row.Cells["RoleGV"].Value.ToString();
            //    LibMainClass.LibMainClass.DisableControl(left_panel);
            //}
        }
    }
}
