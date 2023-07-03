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
    public partial class SymtomsWindow : Sample2
    {
        public SymtomsWindow()
        {
            InitializeComponent();
        }

        private void SymtomsWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            LibCRUD.loadList("st_getDisease", cb_disease,"ID","Disease", ht);
        }


        //--------------------------------------------------------------//

        int symptomID;
        private void LoadSymptom()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(symptomIDGV);
            loadData.Items.Add(symptomGV);
            loadData.Items.Add(diseaseIDGV);
            loadData.Items.Add(DiseaseGV);

            LibCRUD.loadData("st_getSymptoms", dataGridView1, loadData);
        }

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
                    ht.Add(@"symptom", txt_symptom.Text);
                    ht.Add(@"did", Convert.ToInt32(cb_disease.SelectedValue.ToString()));

                    int ret = LibCRUD.data_insert_update_delete("st_insertSymptom", ht);
                    if (ret > 0)
                    {
                        LibMainClass.showMessage(txt_symptom.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadSymptom();
                    }
                }
                else if (edit == 1)                        // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"symptom", txt_symptom.Text);
                    ht.Add(@"did", Convert.ToInt32(cb_disease.SelectedValue.ToString()));
                    ht.Add(@"sid", symptomID);

                    if (LibCRUD.data_insert_update_delete("st_updateSymptom", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_symptom.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadSymptom();
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
                    ht.Add(@"sid", symptomID);
                    if (LibCRUD.data_insert_update_delete("st_deleteSymptom", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_symptom.Text + " deleted successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadSymptom();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadSymptom();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.DisableControl(LEFTPANEL);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                symptomID = Convert.ToInt32(row.Cells["symptomIDGV"].Value.ToString());
                txt_symptom.Text = row.Cells["symptomGV"].Value.ToString();

                cb_disease.SelectedValue = row.Cells["diseaseIDGV"].Value;
            }
        }

    }
}
