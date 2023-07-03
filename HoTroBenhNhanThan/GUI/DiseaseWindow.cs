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
    public partial class DiseaseWindow : Sample2
    {
        public DiseaseWindow()
        {
            InitializeComponent();
        }

        private void txt_disease_TextChanged(object sender, EventArgs e)
        {

        }


        int diseaseID;
        private void LoadDisease()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(diseaseIDGV);
            loadData.Items.Add(diseaseGV);
            LibCRUD.loadData("st_getDisease", dataGridView1, loadData);
        }

            //--------------------------------------------------------//
        public override void button3_Click(object sender, EventArgs e)          //save btn
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
                    ht.Add(@"disease", txt_disease.Text);

                    int ret = LibCRUD.data_insert_update_delete("st_insertDisease", ht);
                    if (ret > 0)
                    {
                        LibMainClass.showMessage(txt_disease.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadDisease();
                    }
                }
                else if (edit == 1)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_disease.Text);
                    ht.Add(@"id", diseaseID);
                    if (LibCRUD.data_insert_update_delete("st_updateRoles", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_disease.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadDisease();
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
                    ht.Add(@"id", diseaseID);
                    if (LibCRUD.data_insert_update_delete("st_deleteRoles", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_disease.Text + " deleted successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadDisease();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadDisease();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.DisableControl(LEFTPANEL);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                diseaseID = Convert.ToInt32(row.Cells["DiseaseIDGV"].Value.ToString());
                txt_disease.Text = row.Cells["DiseaseGV"].Value.ToString();
            }
        }
    }
}
