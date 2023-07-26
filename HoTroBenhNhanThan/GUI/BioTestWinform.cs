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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HoTroBenhNhanThan.GUI
{
    public partial class BioTestWinform : Sample01
    {
        public BioTestWinform()
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

            loadData.Items.Add(UreaGV);
            loadData.Items.Add(GlucoseGV);
            loadData.Items.Add(CreatininGV);
            loadData.Items.Add(AcidUricGV);
            loadData.Items.Add(BilirubinTPGV);
            loadData.Items.Add(BilirubinTtGV);
            loadData.Items.Add(AstGV);
            loadData.Items.Add(ALTGV);
            loadData.Items.Add(GGTGV);
            loadData.Items.Add(CholesHDLGV);
            loadData.Items.Add(CholesLDLGV);
            loadData.Items.Add(TriglyceridGV);

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
            LibCRUD.loadData("st_GetBioTestPatientAppointmentReg", dataGridView1, loadData, ht);

            txt_phone.Text = dataGridView1.Rows[0].Cells[PhoneGV.Name].Value.ToString();
            txtage.Text = dataGridView1.Rows[0].Cells[ageGV.Name].Value.ToString();
        }


        private void BioTestWinform_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);
        }

        public static int turnNo;
        public static string patientName;
        public static long AppID;
        private void btnCall_Click(object sender, EventArgs e)
        {
            //Hashtable ht = new Hashtable();
            //ht.Add("@day", picker_DateTime.Value.Day);
            //ht.Add("@month", picker_DateTime.Value.Month);
            //ht.Add("@year", picker_DateTime.Value.Year);
            //ht.Add("@patID", Convert.ToInt64(cb_selectPatient.SelectedValue.ToString()));
            //turnNo = LibCRUD.getTurnNumber("[st_getTurnNumberPatient]", ht);
            LoadBioTest();

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
                        // Tiếp tục xử lý với patientApointmentID...
                        // Ví dụ:
                        // Thực hiện các thao tác cần thiết với patientApointmentID
                    }

                    ht.Add(@"AppID", AppID);
                    ht.Add("@urea", txt_ure.Text.ToString());
                    ht.Add("@glucose", txt_gluco.Text.ToString());
                    ht.Add("@creatinin", txt_creati.Text.ToString());
                    ht.Add("@acidUric", txt_acidUric.Text.ToString());
                    ht.Add("@bilirubinTP", txt_biliTP.Text.ToString());
                    ht.Add("@bilirubinTT",txt_biliTT.Text.ToString());
                    ht.Add("@AST",txt_AST.Text.ToString());
                    ht.Add("@ALT", txt_ALT.Text.ToString());
                    ht.Add("@GGT", txt_GGT.Text.ToString());
                    ht.Add("@cholesterolHDL", txt_cholesHDL.Text.ToString());
                    ht.Add("@cholesterolLDL", txt_cholesLDL.Text.ToString());
                    ht.Add("@triglycerid", txt_trigly.Text.ToString());
                    int ret = LibCRUD.data_insert_update_delete("[st_InsertBioTestPatientAppointmentReg]", ht);
                    if (ret > 0)
                    {
                        LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " added successfully..", "success");
                        LibMainClass.resetEnable(left_panel);
                        LoadBioTest();
                    }
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

        private void dropdown(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);
        }
    }
}
