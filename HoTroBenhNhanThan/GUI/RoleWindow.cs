
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

namespace HoTroBenhNhanThan
{
    public partial class RoleWindow : Sample2
    {
        public RoleWindow()
        {
            InitializeComponent();
            LoadRoles();

        }

        int roleID;
        private void LoadRoles()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(RoleIDGV);
            loadData.Items.Add(RoleGV);
            LibCRUD.loadData("st_getRoles", dataGridView1, loadData);
        }
        private void txt_role_TextChanged(object sender, EventArgs e)
        {

        }

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
                    ht.Add(@"name", txt_role.Text);
                   
                    int ret = LibCRUD.data_insert_update_delete("st_insertRoles", ht);
                    if (ret > 0)
                    {
                        LibMainClass.showMessage(txt_role.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadRoles();
                    }
                }
                else if (edit == 1)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_role.Text);
                    ht.Add(@"id", roleID);
                    if (LibCRUD.data_insert_update_delete("st_updateRoles",ht) > 0)
                    {
                        LibMainClass.showMessage(txt_role.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadRoles();
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
                    ht.Add(@"id", roleID);
                    if (LibCRUD.data_insert_update_delete("st_deleteRoles", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_role.Text + " deleted successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadRoles();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadRoles();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.DisableControl(LEFTPANEL);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["rolesIDGV"].Value.ToString());
                txt_role.Text = row.Cells["RoleGV"].Value.ToString();
            }
        }

        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
