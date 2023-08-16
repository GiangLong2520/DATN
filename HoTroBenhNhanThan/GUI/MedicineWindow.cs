using HoTroBenhNhanThan.Source;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace HoTroBenhNhanThan.GUI
{
    public partial class MedicineWindow : Sample2
    {
        public MedicineWindow()
        {
            InitializeComponent();
        }

        private void MedicineWindow_Load(object sender, EventArgs e)
        {
            Loadmedicine();
        }

        private void Loadmedicine()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(MediIDGV);
            loadData.Items.Add(MedicineGV);
            loadData.Items.Add(TypeGV);
            loadData.Items.Add(CompanyGV);

            LibCRUD.LibCRUD.loadData("st_getMedicine", dataGridView1, loadData);
        }

        int MedID;
        public override void button3_Click(object sender, EventArgs e)          //save btn
        {
            if (LibMainClass.LibMainClass.checkControls(left_panel).Count > 0)
            {
                LibMainClass.LibMainClass.showMessage("Field with RED are mandatory.", "error");

            }
            else
            {
                Hashtable h = new Hashtable();
                h.Add("@name", txt_medi.Text);
                h.Add("@type", cb_Type.SelectedIndex);
                if (CheckExistance("st_checkExistMedicine", h))
                {
                    LibMainClass.LibMainClass.showMessage("Medicine Existed", "warning");
                    return;
                }    
                    if (edit == 0)                              // code for save
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_medi.Text);
                    if (txt_company.Text == "")
                    {
                        ht.Add("@comp", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@comp", txt_company.Text);
                    }

                    ht.Add("@type", cb_Type.SelectedIndex);

                    int ret = LibCRUD.LibCRUD.data_insert_update_delete("st_insertMedicine", ht);
                    if (ret > 0)
                    {
                        // Write Log
                        LogControler.WriteLog("st_insertMedicine", ht);
                        LibMainClass.LibMainClass.showMessage(txt_medi.Text + " added successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
                        Loadmedicine();
                    }
                }
                else if (edit == 1)                        // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_medi.Text);
                    if (txt_company.Text == "")
                    {
                        ht.Add("@comp", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@comp", txt_company.Text);
                    }

                    ht.Add("@type", cb_Type.SelectedIndex);
                    ht.Add("@id", MedID);

                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_updateMedicine", ht) > 0)
                    {
                        // Write Log
                        LogControler.WriteLog("st_updateMedicine", ht);
                        LibMainClass.LibMainClass.showMessage(txt_medi.Text + " added successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
                        Loadmedicine();
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
                    ht.Add(@"id", MedID);
                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_deleteMedicine", ht) > 0)
                    {
                        // Write Log
                        LogControler.WriteLog("st_deleteMedicine", ht);
                        LibMainClass.LibMainClass.showMessage(txt_company.Text + " deleted successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
                        Loadmedicine();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            Loadmedicine();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.LibMainClass.DisableControl(left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MedID = Convert.ToInt32(row.Cells["MediIDGV"].Value.ToString());
                txt_medi.Text = row.Cells["MedicineGV"].Value.ToString(); ;
                txt_company.Text = row.Cells["CompanyGV"].Value.ToString();
                cb_Type.SelectedItem = row.Cells["TypeGV"].Value.ToString();
            }
        }

        private void txt_medi_TextChanged(object sender, EventArgs e)
        {
            if (txt_medi.Text == "")
            {
                txt_medi.BackColor = Color.Firebrick;
            }
            else
            {
                txt_medi.BackColor = Color.White;
            }
        }

        private void txt_company_TextChanged(object sender, EventArgs e)
        {

        }

        private void DD_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Type.SelectedIndex == -1)
            {
                cb_Type.BackColor = Color.Firebrick;
            }
            else
            {
                cb_Type.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.LibMainClass.DisableControl(LEFTPANEL);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MedID = Convert.ToInt32(row.Cells["MediIDGV"].Value.ToString());
                txt_medi.Text = row.Cells["MedicineGV"].Value.ToString(); ;
                txt_company.Text = row.Cells["CompanyGV"].Value.ToString();
                cb_Type.SelectedItem = row.Cells["TypeGV"].Value.ToString();
                LibMainClass.LibMainClass.DisableControl(left_panel);
            }
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
    }
}
