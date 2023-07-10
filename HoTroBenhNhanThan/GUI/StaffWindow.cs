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

namespace HoTroBenhNhanThan
{
    public partial class StaffWindow : Sample2
    {
        public StaffWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if(txt_name.Text == "")
            {
                txt_name.BackColor= Color.Firebrick;
            }
            else
            {
                txt_name.BackColor= Color.White;
            }
        }

        private void txt_usename_TextChanged(object sender, EventArgs e)
        {
            if (txt_usename.Text == "")
            {
                txt_usename.BackColor = Color.Firebrick;
            }
            else
            {
                txt_usename.BackColor = Color.White;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_usename.BackColor = Color.Firebrick;
            }
            else
            {
                txt_usename.BackColor = Color.White;
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_phone.Text == "")
            {
                txt_phone.BackColor = Color.Firebrick;
            }
            else
            {
                txt_phone.BackColor = Color.White;
            }
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            if (txt_address.Text == "")
            {
                txt_address.BackColor = Color.Firebrick;
            }
            else
            {
                txt_address.BackColor = Color.White;
            }
        }

        private void DD_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_role.SelectedIndex == -1)
            {
                cb_role.BackColor = Color.Firebrick;
            }
            else
            {
                cb_role.BackColor = Color.White;
            }
        }
        /// <summary>
        /// ///////////////////////////////////////////////
        /// </summary>
        int UserID;
        private void LoadUsers()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(UserIDGV);
            loadData.Items.Add(nameGV);
            loadData.Items.Add(UserNameGV);
            loadData.Items.Add(PasswordGV);
            loadData.Items.Add(PhoneGV);
            loadData.Items.Add(AddressGV);
            loadData.Items.Add(RoleIDGV);
            loadData.Items.Add(RoleGV);
            LibCRUD.loadData("st_getUsers", dataGridViewstaff, loadData);
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
                    ht.Add(@"name", txt_name.Text);
                    ht.Add(@"userName", txt_usename.Text);
                    ht.Add(@"passWord", txt_password.Text);
                    ht.Add(@"phone", txt_phone.Text);
                    ht.Add(@"address", txt_address.Text);
                    ht.Add(@"roleId", Convert.ToInt32(cb_role.SelectedValue.ToString()));

                    int ret = LibCRUD.data_insert_update_delete("st_insertUsers", ht);
                    if (ret > 0)
                    {
                        LibMainClass.showMessage(txt_name.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadUsers();
                    }
                }
                else if (edit == 1)                        // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_name.Text);
                    ht.Add(@"userName", txt_usename.Text);
                    ht.Add(@"passWord", txt_password.Text);
                    ht.Add(@"phone", txt_phone.Text);
                    ht.Add(@"address", txt_address.Text);
                    ht.Add(@"roleId", Convert.ToInt32(cb_role.SelectedValue.ToString()));
                    ht.Add(@"id", UserID);

                    if (LibCRUD.data_insert_update_delete("st_updateUsers", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_name.Text + " added successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadUsers();
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
                    ht.Add(@"id", UserID);
                    if (LibCRUD.data_insert_update_delete("st_deleteUser", ht) > 0)
                    {
                        LibMainClass.showMessage(txt_usename.Text + " deleted successfully..", "success");
                        LibMainClass.resetEnable(LEFTPANEL);
                        LoadUsers();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadUsers();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewstaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.DisableControl(LEFTPANEL);
                DataGridViewRow row = dataGridViewstaff.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells["UserIDGV"].Value.ToString());
                txt_name.Text = row.Cells["nameGV"].Value.ToString(); ;
                txt_usename.Text = row.Cells["UserNameGV"].Value.ToString();
                txt_password.Text = row.Cells["PasswordGV"].Value.ToString();
                txt_phone.Text = row.Cells["PhoneGV"].Value.ToString();
                txt_address.Text = row.Cells["AddressGV"].Value.ToString();
                cb_role.SelectedValue = row.Cells["RoleIDGV"].Value;
            }
        }


        private void StaffWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            LibCRUD.loadList("st_getRoles", cb_role, "ID", "Role", ht);
            LoadUsers();
        }
    }
}
