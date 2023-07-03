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
            if (DD_role.SelectedIndex == -1)
            {
                DD_role.BackColor = Color.Firebrick;
            }
            else
            {
                DD_role.BackColor = Color.White;
            }
        }
        public override void button3_Click(object sender, EventArgs e)    // save click
        {
            if (LibMainClass.checkControls(LEFTPANEL).Count > 0)
            {
                LibMainClass.showMessage("Field with RED are mandatory.", "error");
            }
            else
            {
            //    if (edit == 0)
            //    {
            //        Hashtable ht = new Hashtable();
            //        ht.Add(@"name", txt_role.Text);

            //        int ret = LibCRUD.data_insert_update_delete("st_insertRoles", ht);
            //        if (ret > 0)
            //        {
            //            LibMainClass.showMessage(txt_role.Text + " added successfully..", "success");
            //            LibMainClass.resetEnable(LEFTPANEL);
            //            LoadRoles();
            //        }
            //    }
            //    else if (edit == 1)
            //    {
            //        Hashtable ht = new Hashtable();
            //        ht.Add(@"name", txt_role.Text);
            //        ht.Add(@"id", roleID);
            //        if (LibCRUD.data_insert_update_delete("st_updateRoles", ht) > 0)
            //        {
            //            LibMainClass.showMessage(txt_role.Text + " added successfully..", "success");
            //            LibMainClass.resetEnable(LEFTPANEL);
            //            LoadRoles();
            //        }
            //    }

            }
        }

        public override void button4_Click(object sender, EventArgs e)   //delete click
        {

        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {

        }
    }
}
