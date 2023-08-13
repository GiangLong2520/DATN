using Microsoft.Data.SqlClient;
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
            loadData.Items.Add(IDGV);
            loadData.Items.Add(diseaseGV);
            LibCRUD.LibCRUD.loadData("st_getDisease", dataGridView2, loadData);
        }

            //--------------------------------------------------------//
        public override void button3_Click(object sender, EventArgs e)          //save btn
        {
            if (LibMainClass.LibMainClass.checkControls(left_panel_common).Count > 0)
            {
                LibMainClass.LibMainClass.showMessage("Field with RED are mandatory.", "error");

            }
            else
            {
                Hashtable h = new Hashtable();
                h.Add("@disease", txt_disease.Text);
                if (CheckExistance("st_checkExistdisease", h))
                {
                    LibMainClass.LibMainClass.showMessage("Symptom Existed", "warning");
                    return;
                }
                if (edit == 0)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"disease", txt_disease.Text);

                    int ret = LibCRUD.LibCRUD.data_insert_update_delete("st_insertDisease", ht);
                    if (ret > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(txt_disease.Text + " added successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
                        LoadDisease();
                    }
                }
                else if (edit == 1)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@disease", txt_disease.Text);
                    ht.Add("@did", diseaseID);
                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_updateDisease", ht) > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(txt_disease.Text + " update successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
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
                    ht.Add(@"did", diseaseID);
                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_deleteDisease", ht) > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(txt_disease.Text + " deleted successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(LEFTPANEL);
                        LoadDisease();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadDisease();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.LibMainClass.DisableControl(left_panel);
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                diseaseID = Convert.ToInt32(row.Cells["IDGV"].Value.ToString());
                txt_disease.Text = row.Cells["DiseaseGV"].Value.ToString();
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
