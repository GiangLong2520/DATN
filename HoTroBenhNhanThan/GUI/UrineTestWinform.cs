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
using LibCRUD;
 using LibMainClass;
using HoTroBenhNhanThan.Source;

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
            LibCRUD.LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);
        }
        private void LoadUrineTest()
        {
            ListBox loadData = new ListBox();

            loadData.Items.Add(IDGV);
            loadData.Items.Add(apointDateGV);
            loadData.Items.Add(patientGV);
            loadData.Items.Add(ageGV);
            loadData.Items.Add(PhoneGV);

            loadData.Items.Add(SpecificGravityGV);
            loadData.Items.Add(PHGV);
            loadData.Items.Add(ASCGV);
            loadData.Items.Add(LeukocytesGV);
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
            LibCRUD.LibCRUD.loadData("st_GetUrineTestPatientAppointmentReg", dataGridView1, loadData, ht);
            if (dataGridView1.RowCount > 0)
            {
                txt_phone.Text = dataGridView1.Rows[0].Cells[PhoneGV.Name].Value.ToString();
                txtage.Text = dataGridView1.Rows[0].Cells[ageGV.Name].Value.ToString();
            }
            else{
                txt_phone.Text = "";
                txtage.Text = "";
            }
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

                    ht.Add("@AppID"             ,    AppID);
                    ht.Add("@SG"			  ,     Math.Round(float.Parse(txt_SG .Text.ToString()), 3));
                    ht.Add("@PH"			  ,    Math.Round(float.Parse(txt_PH.Text.ToString()), 3));
                    ht.Add("@ASC"	            ,  Math.Round(float.Parse(txt_ASC.Text.ToString()), 3));

                    ht.Add("@Leukocytes"	  ,     radio_LEUAmTinh.Checked ? true: false );
                    ht.Add("@Nitrit"		  ,     radioNitritAmtinh.Checked ? true: false);
                    ht.Add("@Ketone"		  ,     radioKetoneKhong.Checked ? true : false);
                    ht.Add("@Urobilinogen"      ,   radioUrobilKhongCo.Checked ? true: false);


                    int ret = LibCRUD.LibCRUD.data_insert_update_delete("[st_InsertUrineTestPatientAppointmentReg]", ht);
                    if (ret > 0)
                    {
                        // Write Log
                        LogControler.WriteLog("st_InsertUrineTestPatientAppointmentReg", ht);
                        LibMainClass.LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " added successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
                        LoadUrineTest();
                    }
                    txt_phone.Text = dataGridView1.Rows[0].Cells[PhoneGV.Name].Value.ToString();
                    txtage.Text = dataGridView1.Rows[0].Cells[ageGV.Name].Value.ToString();
                }
                else if (edit == 1)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@ID", urineID);
                    ht.Add("@SG", Math.Round(float.Parse(txt_SG.Text.ToString()), 3));
                    ht.Add("@PH", Math.Round(float.Parse(txt_PH.Text.ToString()), 3));
                    ht.Add("@ASC", Math.Round(float.Parse(txt_ASC.Text.ToString()), 3));

                    ht.Add("@Leukocytes", radio_LEUAmTinh.Checked ? true : false);
                    ht.Add("@Nitrit", radioNitritAmtinh.Checked ? true : false);
                    ht.Add("@Ketone", radioKetoneKhong.Checked ? true : false);
                    ht.Add("@Urobilinogen", radioUrobilKhongCo.Checked ? true : false);


                    int ret = LibCRUD.LibCRUD.data_insert_update_delete("[st_UpdateUrineTestPatientAppointmentReg]", ht);
                    if (ret > 0)
                    {
                        // Write Log
                        LogControler.WriteLog("st_UpdateUrineTestPatientAppointmentReg", ht);
                        LibMainClass.LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " Update successfully..", "success");
                        LibMainClass  .LibMainClass.resetEnable(left_panel);
                        LoadUrineTest();
                    }
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
                    ht.Add("@ID", urineID);
                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_DeleteUrineTestPatientAppointmentReg", ht) > 0)
                    {
                        // Write Log
                        LogControler.WriteLog("st_DeleteUrineTestPatientAppointmentReg", ht);
                        LibMainClass.LibMainClass.showMessage(cb_selectPatient.ValueMember.ToString() + " deleted successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
                        LoadUrineTest();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadUrineTest();
        }
        public static long urineID;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.LibMainClass.DisableControl(left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                urineID = Convert.ToInt32(row.Cells["IDGV"].Value.ToString());
                //txt_role.Text = row.Cells["RoleGV"].Value.ToString(); 
                // SpecificGravityGV);
                // PHGV);
                // ASCGV);
                // LeukocytesGV);
                // NitritGV);
                // KetoneGV);
                // UrobilinogenGV);
                // txt_SG.Text = row.Cells[""].Value.ToString();
                txt_SG.Text = row.Cells["SpecificGravityGV"].Value.ToString();
                txt_PH.Text = row.Cells["PHGV"].Value.ToString();
                txt_ASC.Text = row.Cells["ASCGV"].Value.ToString();

                string tmp;
                tmp = row.Cells["LeukocytesGV"].Value.ToString();
                if(tmp.Equals("Âm Tính"))
                {
                    radio_LEUAmTinh.Checked = true;
                }
                else
                {
                    radio_LeuDuongTinh.Checked = true;
                }

                tmp = row.Cells["NitritGV"].Value.ToString();
                if (tmp.Equals("Âm Tính"))
                {
                    radioNitritAmtinh.Checked = true;
                }
                else
                {
                    radioNitritDuongTinh.Checked = true;
                }

                tmp = row.Cells["KetoneGV"].Value.ToString();
                if (tmp.Equals("< 0.5 mmol/L"))
                {
                    radioKetoneKhong.Checked = true;
                }
                else
                {
                    radioKetoneCoNhieu.Checked = true;
                }

                tmp = row.Cells["UrobilinogenGV"].Value.ToString();
                if (tmp.Equals("Không Có"))
                {
                    radioUrobilKhongCo.Checked = true;
                }
                else
                {
                    radioUrobilCo.Checked = true;
                }


                LibMainClass.LibMainClass.DisableControl(left_panel);
            }
        }
    }
}
