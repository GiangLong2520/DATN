namespace HoTroBenhNhanThan
{
    partial class StaffWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.dataGridViewstaff = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.LEFTPANEL.SuspendLayout();
            this.left_panel_common.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewstaff);
            // 
            // flowPanel
            // 
            this.left_panel.Controls.Add(this.label2);
            this.left_panel.Controls.Add(this.txt_name);
            this.left_panel.Controls.Add(this.label4);
            this.left_panel.Controls.Add(this.txt_usename);
            this.left_panel.Controls.Add(this.label5);
            this.left_panel.Controls.Add(this.txt_password);
            this.left_panel.Controls.Add(this.label6);
            this.left_panel.Controls.Add(this.txt_phone);
            this.left_panel.Controls.Add(this.label7);
            this.left_panel.Controls.Add(this.txt_address);
            this.left_panel.Controls.Add(this.label8);
            this.left_panel.Controls.Add(this.cb_role);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(10, 43);
            this.txt_name.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(303, 27);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "UserName";
            // 
            // txt_usename
            // 
            this.txt_usename.Location = new System.Drawing.Point(10, 96);
            this.txt_usename.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_usename.MaxLength = 50;
            this.txt_usename.Name = "txt_usename";
            this.txt_usename.Size = new System.Drawing.Size(303, 27);
            this.txt_usename.TabIndex = 4;
            this.txt_usename.TextChanged += new System.EventHandler(this.txt_usename_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(10, 149);
            this.txt_password.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(303, 27);
            this.txt_password.TabIndex = 6;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(10, 202);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_phone.MaxLength = 50;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(303, 27);
            this.txt_phone.TabIndex = 8;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(10, 255);
            this.txt_address.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_address.MaxLength = 50;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(303, 27);
            this.txt_address.TabIndex = 10;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Role";
            // 
            // cb_role
            // 
            this.cb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_role.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(10, 308);
            this.cb_role.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(303, 28);
            this.cb_role.TabIndex = 12;
            this.cb_role.SelectedIndexChanged += new System.EventHandler(this.DD_role_SelectedIndexChanged);
            // 
            // dataGridViewstaff
            // 
            this.dataGridViewstaff.AllowUserToAddRows = false;
            this.dataGridViewstaff.AllowUserToDeleteRows = false;
            this.dataGridViewstaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewstaff.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewstaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.UserIDGV,
            this.nameGV,
            this.UserNameGV,
            this.PasswordGV,
            this.PhoneGV,
            this.AddressGV,
            this.RoleIDGV,
            this.RoleGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewstaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewstaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewstaff.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewstaff.Name = "dataGridViewstaff";
            this.dataGridViewstaff.ReadOnly = true;
            this.dataGridViewstaff.RowHeadersVisible = false;
            this.dataGridViewstaff.RowHeadersWidth = 51;
            this.dataGridViewstaff.RowTemplate.Height = 29;
            this.dataGridViewstaff.Size = new System.Drawing.Size(943, 601);
            this.dataGridViewstaff.TabIndex = 2;
            this.dataGridViewstaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstaff_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.MinimumWidth = 6;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 47;
            // 
            // UserIDGV
            // 
            this.UserIDGV.HeaderText = "ID";
            this.UserIDGV.MinimumWidth = 6;
            this.UserIDGV.Name = "UserIDGV";
            this.UserIDGV.ReadOnly = true;
            this.UserIDGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Name";
            this.nameGV.MinimumWidth = 6;
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            this.UserNameGV.HeaderText = "UserName";
            this.UserNameGV.MinimumWidth = 6;
            this.UserNameGV.Name = "UserNameGV";
            this.UserNameGV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            this.PasswordGV.HeaderText = "Partword";
            this.PasswordGV.MinimumWidth = 6;
            this.PasswordGV.Name = "PasswordGV";
            this.PasswordGV.ReadOnly = true;
            this.PasswordGV.Visible = false;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone";
            this.PhoneGV.MinimumWidth = 6;
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // AddressGV
            // 
            this.AddressGV.HeaderText = "Address";
            this.AddressGV.MinimumWidth = 6;
            this.AddressGV.Name = "AddressGV";
            this.AddressGV.ReadOnly = true;
            // 
            // RoleIDGV
            // 
            this.RoleIDGV.HeaderText = "RoleID";
            this.RoleIDGV.MinimumWidth = 6;
            this.RoleIDGV.Name = "RoleIDGV";
            this.RoleIDGV.ReadOnly = true;
            this.RoleIDGV.Visible = false;
            // 
            // RoleGV
            // 
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.MinimumWidth = 6;
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // StaffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "StaffWindow";
            this.Text = "StaffWindow";
            this.Load += new System.EventHandler(this.StaffWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.LEFTPANEL.ResumeLayout(false);
            this.left_panel_common.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private TextBox txt_name;
        private Label label4;
        private TextBox txt_usename;
        private Label label5;
        private TextBox txt_password;
        private Label label6;
        private TextBox txt_phone;
        private Label label7;
        private TextBox txt_address;
        private Label label8;
        private ComboBox cb_role;
        private DataGridView dataGridViewstaff;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn UserIDGV;
        private DataGridViewTextBoxColumn nameGV;
        private DataGridViewTextBoxColumn UserNameGV;
        private DataGridViewTextBoxColumn PasswordGV;
        private DataGridViewTextBoxColumn PhoneGV;
        private DataGridViewTextBoxColumn AddressGV;
        private DataGridViewTextBoxColumn RoleIDGV;
        private DataGridViewTextBoxColumn RoleGV;
    }
}