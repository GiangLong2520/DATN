﻿using System;
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
namespace HoTroBenhNhanThan
{
    
    public partial class UserWindow : Sample2
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        int UserID;
        int roleID;
        //private void txt_Name_TextChanged(object sender, EventArgs e)
        //{
        //        if (txt_Name.Text == "")
        //    {
        //        txt_Name.BackColor = Color.Firebrick;
        //    }
        //    else
        //    {
        //        txt_Name.BackColor = Color.White;
        //    }
        //}

        //private void txt_usename_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_usename.Text == "")
        //    {
        //        txt_usename.BackColor = Color.Firebrick;
        //    }
        //    else
        //    {
        //        txt_usename.BackColor = Color.White;
        //    }
        //}

        //private void txt_Pass_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_Pass.Text == "")
        //    {
        //        txt_Pass.BackColor = Color.Firebrick;
        //    }
        //    else
        //    {
        //        txt_Pass.BackColor = Color.White;
        //    }
        //}

        //private void txt_Phone_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_Phone.Text == "")
        //    {
        //        txt_Phone.BackColor = Color.Firebrick;
        //    }
        //    else
        //    {
        //        txt_Phone.BackColor = Color.White;
        //    }
        //}

        //private void txt_Address_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_Address.Text == "")
        //    {
        //        txt_Address.BackColor = Color.Firebrick;
        //    }
        //    else
        //    {
        //        txt_Address.BackColor = Color.White;
        //    }
        //}

        //private void cb_Roles_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   if (cb_Roles.SelectedIndex == -1)
        //    {
        //        txt_usename .BackColor = Color.Firebrick;
        //    }
        //    else
        //    {
        //        txt_usename.BackColor = Color.White;
        //    }
        //}

        private void LoadUsers()
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(IDGV             );
            loadData.Items.Add(NameGV           );
            loadData.Items.Add(UserNameGV       );
            loadData.Items.Add(PasswordGV       );
            loadData.Items.Add(PhoneGV          );
            loadData.Items.Add(AddressGV        );
            loadData.Items.Add(RoleIDGV         );
            loadData.Items.Add(RoleGV           );

            LibCRUD.LibCRUD.loadData("st_getUsers", dataGridView2, loadData);
        }

        public override void button3_Click(object sender, EventArgs e)          //save btn
        {
            if (LibMainClass.LibMainClass.checkControls(LEFTPANEL).Count > 0)
            {
                LibMainClass.LibMainClass.showMessage("Field with RED are mandatory.", "error");

            }
            else
            {
                if (edit == 0)                              // code for save
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name",     txt_Name.Text);
                    ht.Add(@"userName", txt_usename.Text);
                    ht.Add(@"passWord", txt_Pass.Text);
                    ht.Add(@"phone",    txt_Phone.Text);
                    ht.Add(@"address",  txt_Address.Text);
                    ht.Add(@"roleId", Convert.ToInt32(cb_Roles.SelectedValue.ToString()));                           

                    int ret = LibCRUD.LibCRUD.data_insert_update_delete("st_insertUsers", ht);
                    if (ret > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(txt_Name.Text + " added successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(LEFTPANEL);
                        LoadUsers();
                    }
                }
                else if (edit == 1)                        // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add(@"name", txt_Name.Text);
                    ht.Add(@"userName", txt_usename.Text);
                    ht.Add(@"passWord", txt_Pass.Text);
                    ht.Add(@"phone", txt_Phone.Text);
                    ht.Add(@"address", txt_Address.Text);
                    ht.Add(@"roleId", Convert.ToInt32(cb_Roles.SelectedValue.ToString()));
                    ht.Add(@"id", UserID);

                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_updateUsers", ht) > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(txt_Name.Text + " update successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(LEFTPANEL);
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
                    if (LibCRUD.LibCRUD.data_insert_update_delete("st_deleteUser", ht) > 0)
                    {
                        LibMainClass.LibMainClass.showMessage(txt_usename.Text + " deleted successfully..", "success");
                        LibMainClass.LibMainClass.resetEnable(left_panel);
                        LoadUsers();
                    }
                }
            }
        }
        public override void btn_View_Click(object sender, EventArgs e)         // view click
        {
            LoadUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.LibMainClass.DisableControl(left_panel);
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells["UserIDGV"].Value.ToString());
                txt_Name.Text = row.Cells["NameGV"].Value.ToString(); ;
                txt_usename.Text = row.Cells["UserNameGV"].Value.ToString();
                txt_Pass.Text = row.Cells["PassGV"].Value.ToString();
                txt_Phone.Text = row.Cells["PhoneGV"].Value.ToString();
                txt_Address.Text = row.Cells["AddressGV"].Value.ToString();
            }
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LibCRUD.LibCRUD.loadRole(cb_Roles);

            Listprovince();
        }


        private void Listprovince()
        {
            DataTable dt = new DataTable();
            dt = LibCRUD.LibCRUD.LoadDataTable("SELECT * FROM province");
            cboCity.DataSource = dt;
            cboCity.DisplayMember = "prov_name";
            cboCity.ValueMember = "prov_id";
        }

        private int selectedProvinceId = 0;

        private void ProviceDrop(object sender, EventArgs e)
        {
            selectedProvinceId = Convert.ToInt32(cboCity.SelectedValue);
            Listdistrict();
        }

        private void Listdistrict()
        {
            DataTable dt = new DataTable();
            dt = LibCRUD.LibCRUD.LoadDataTable($"SELECT * FROM district WHERE dis_provID = {selectedProvinceId}");
            cboDistrict.DataSource = dt;
            cboDistrict.DisplayMember = "dis_name";
            cboDistrict.ValueMember = "dis_id";
        }

        private int selectedDistrictId = 0;

        private void DistrictDrop(object sender, EventArgs e)
        {
            selectedDistrictId = Convert.ToInt32(cboDistrict.SelectedValue);
            Listward();
        }

        private void Listward()
        {
            DataTable dt = new DataTable();
            dt = LibCRUD.LibCRUD.LoadDataTable($"SELECT * FROM ward WHERE ward_disID = {selectedDistrictId}");
            cboWard.DataSource = dt;
            cboWard.DisplayMember = "ward_name";
            cboWard.ValueMember = "ward_id";
        }

        private void WardDrop(object sender, EventArgs e)
        {
            int selectedWardId = Convert.ToInt32(cboWard.SelectedValue);
            // Đoạn code sau này có thể sử dụng selectedWardId
            // để thực hiện các tác vụ khác liên quan đến xã đã chọn.
            // Ví dụ: Lấy thông tin xã, thêm/sửa/xóa dữ liệu liên quan, v.v.
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                LibMainClass.LibMainClass.DisableControl(left_panel);
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                //IDGV
                //NameGV
                //UserNameGV
                //PasswordGV
                //PhoneGV
                //AddressGV
                //RoleIDGV
                //RoleGV

                UserID = Convert.ToInt32(row.Cells["IDGV"].Value.ToString());
                roleID = Convert.ToInt32(row.Cells["RoleIDGV"].Value.ToString());
                txt_Name.Text =         row.Cells["NameGV"].Value.ToString(); ;
                txt_usename.Text =      row.Cells["UserNameGV"].Value.ToString();
                txt_Pass.Text =         row.Cells["PasswordGV"].Value.ToString();
                txt_Phone.Text =        row.Cells["PhoneGV"].Value.ToString();
                txt_Address.Text =      row.Cells["AddressGV"].Value.ToString();

                int index = -1;
                for (int i = 0; i < cb_Roles.Items.Count; i++)
                {
                    DataRowView drv = (DataRowView)cb_Roles.Items[i];
                    int currentValue = Convert.ToInt32(drv[cb_Roles.ValueMember]);
                    if (currentValue == roleID)
                    {
                        index = i;
                        break;
                    }
                }

                // Chọn lựa chọn tại vị trí tìm thấy (nếu tìm thấy)
                if (index >= 0)
                {
                    cb_Roles.SelectedIndex = index;
                }

            }
        }

        private void left_panel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
