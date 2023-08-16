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
using LibMainClass;
using LibCRUD;
using HoTroBenhNhanThan.Source;

namespace HoTroBenhNhanThan.GUI
{
    public partial class TestWindow : Sample2
    {
        public TestWindow()
        {
            InitializeComponent();
        }


        //------------------------------------------------------//
        int testID;
        private void LoadDisease()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(testIDGV);
            loadData.Items.Add(testGV);
            loadData.Items.Add(priceGV);
            loadData.Items.Add(precautionsGV);
            LibCRUD.LibCRUD.loadData("st_getTest", dataGridView2, loadData);
        }

        //--------------------------------------------------------//
        public override void button3_Click(object sender, EventArgs e)          //save btn
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
                    ht.Add(@"test", txt_test.Text);
                    ht.Add("@price",txt_price.Text);
                    ht.Add("@precautions", txtPrecautions);
                    int ret = LibCRUD.LibCRUD.data_insert_update_delete("st_insertTest", ht);
                    if (ret > 0)
                    {
                        // Write Log
                        LogControler.WriteLog("st_deleteSymptom", ht);
                        LibMainClass.LibMainClass.showMessage(txt_test.Text + " added successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(LEFTPANEL);
                        LoadDisease();
                    }
                }
                else if (edit == 1)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"test", txt_test.Text);
                    ht.Add("@price", txt_price.Text);
                    ht.Add("@precautions", txtPrecautions);
                    ht.Add(@"id", testID);
                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_updateRoles", ht) > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(txt_test.Text + " added successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(LEFTPANEL);
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
                    ht.Add(@"id", testID);
                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_deleteRoles", ht) > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(txt_test.Text + " deleted successfully..", "success");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.LibMainClass.DisableControl(LEFTPANEL);
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                testID = Convert.ToInt32(row.Cells["testIDGV"].Value.ToString());
                txt_test.Text = row.Cells["testGV"].Value.ToString();
                txt_price.Text = row.Cells["priceGV"].Value.ToString();
                txtPrecautions.Text = row.Cells["precautionsGV"].Value.ToString();
            }
        }

        private void TestWindow_Load(object sender, EventArgs e)
        {

        }
    }

}
