using System.Collections;

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
            loadData.Items.Add(CompanyGV);
            loadData.Items.Add(TypeGV);

            LibCRUD.loadData("st_getMedicine", dataGridView1, loadData);
        }

        int MedID;
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
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_medi.Text);
                    if (txt_company.Text == "")
                    {
                        ht.Add("@company", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@comp", txt_company.Text);
                    }

                    ht.Add("@type", cb_Type.SelectedIndex);

                    int ret = LibCRUD.data_insert_update_delete("st_insertMedicine", ht);
                    if (ret > 0)
                    {
                        LibMainClass.showMessage(txt_medi.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        Loadmedicine();
                    }
                }
                else if (edit == 1)                        // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_medi.Text);
                    if (txt_company.Text == "")
                    {
                        ht.Add("@company", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@company", txt_company.Text);
                    }

                    ht.Add("@type", cb_Type.SelectedIndex);
                    ht.Add("@id", MedID);

                    if (LibCRUD.data_insert_update_delete("st_updateUsers", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_medi.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
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
                    if (LibCRUD.data_insert_update_delete("st_deleteUser", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_company.Text + " deleted successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
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
                LibMainClass.DisableControl(LEFTPANEL);
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
                LibMainClass.DisableControl(LEFTPANEL);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MedID = Convert.ToInt32(row.Cells["MediIDGV"].Value.ToString());
                txt_medi.Text = row.Cells["MedicineGV"].Value.ToString(); ;
                txt_company.Text = row.Cells["CompanyGV"].Value.ToString();
                cb_Type.SelectedItem = row.Cells["TypeGV"].Value.ToString();
            }
        }
    }
}
