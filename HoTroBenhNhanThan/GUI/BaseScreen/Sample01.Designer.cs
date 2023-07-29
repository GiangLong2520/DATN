namespace HoTroBenhNhanThan.GUI.BaseScreen
{
    partial class Sample01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sample01));
            this.left_panel_common = new System.Windows.Forms.Panel();
            this.left_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LEFTPANEL = new System.Windows.Forms.Panel();
            this.BtnBackPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RIGHTPANEL = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.left_panel_common.SuspendLayout();
            this.LEFTPANEL.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel_common
            // 
            this.left_panel_common.Controls.Add(this.left_panel);
            this.left_panel_common.Controls.Add(this.panel2);
            this.left_panel_common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_panel_common.Location = new System.Drawing.Point(0, 71);
            this.left_panel_common.Name = "left_panel_common";
            this.left_panel_common.Size = new System.Drawing.Size(500, 689);
            this.left_panel_common.TabIndex = 0;
            // 
            // left_panel
            // 
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.left_panel.Location = new System.Drawing.Point(0, 62);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(500, 627);
            this.left_panel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 62);
            this.panel2.TabIndex = 3;
            // 
            // LEFTPANEL
            // 
            this.LEFTPANEL.BackColor = System.Drawing.Color.DarkGreen;
            this.LEFTPANEL.Controls.Add(this.left_panel_common);
            this.LEFTPANEL.Controls.Add(this.BtnBackPanel);
            this.LEFTPANEL.Dock = System.Windows.Forms.DockStyle.Left;
            this.LEFTPANEL.ForeColor = System.Drawing.Color.White;
            this.LEFTPANEL.Location = new System.Drawing.Point(0, 0);
            this.LEFTPANEL.Name = "LEFTPANEL";
            this.LEFTPANEL.Size = new System.Drawing.Size(500, 760);
            this.LEFTPANEL.TabIndex = 0;
            // 
            // BtnBackPanel
            // 
            this.BtnBackPanel.Controls.Add(this.btnBack);
            this.BtnBackPanel.Controls.Add(this.label1);
            this.BtnBackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBackPanel.Location = new System.Drawing.Point(0, 0);
            this.BtnBackPanel.Name = "BtnBackPanel";
            this.BtnBackPanel.Size = new System.Drawing.Size(500, 71);
            this.BtnBackPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 71);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RIGHTPANEL
            // 
            this.RIGHTPANEL.Controls.Add(this.right_panel);
            this.RIGHTPANEL.Controls.Add(this.UserPanel);
            this.RIGHTPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RIGHTPANEL.Location = new System.Drawing.Point(500, 0);
            this.RIGHTPANEL.Name = "RIGHTPANEL";
            this.RIGHTPANEL.Size = new System.Drawing.Size(772, 760);
            this.RIGHTPANEL.TabIndex = 0;
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.groupBox1);
            this.right_panel.Controls.Add(this.panel1);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.Location = new System.Drawing.Point(0, 71);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(772, 689);
            this.right_panel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 627);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 62);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Delete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Edit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_View, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_search, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.FlatAppearance.BorderSize = 2;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Delete.Location = new System.Drawing.Point(387, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.tableLayoutPanel1.SetRowSpan(this.btn_Delete, 2);
            this.btn_Delete.Size = new System.Drawing.Size(122, 56);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Edit.FlatAppearance.BorderSize = 2;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Edit.Location = new System.Drawing.Point(131, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.tableLayoutPanel1.SetRowSpan(this.btn_Edit, 2);
            this.btn_Edit.Size = new System.Drawing.Size(122, 56);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "&EDIT";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.FlatAppearance.BorderSize = 2;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.tableLayoutPanel1.SetRowSpan(this.btn_Add, 2);
            this.btn_Add.Size = new System.Drawing.Size(122, 56);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "&ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.FlatAppearance.BorderSize = 2;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Location = new System.Drawing.Point(259, 3);
            this.btn_Save.Name = "btn_Save";
            this.tableLayoutPanel1.SetRowSpan(this.btn_Save, 2);
            this.btn_Save.Size = new System.Drawing.Size(122, 56);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "&SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(643, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn_View
            // 
            this.btn_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_View.FlatAppearance.BorderSize = 2;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_View.Location = new System.Drawing.Point(515, 3);
            this.btn_View.Name = "btn_View";
            this.tableLayoutPanel1.SetRowSpan(this.btn_View, 2);
            this.btn_View.Size = new System.Drawing.Size(122, 56);
            this.btn_View.TabIndex = 4;
            this.btn_View.Text = "VIEW";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // txt_search
            // 
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_search.Location = new System.Drawing.Point(643, 32);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(126, 27);
            this.txt_search.TabIndex = 9;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.User);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(772, 71);
            this.UserPanel.TabIndex = 1;
            // 
            // User
            // 
            this.User.Dock = System.Windows.Forms.DockStyle.Left;
            this.User.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.ForeColor = System.Drawing.Color.DarkGreen;
            this.User.Location = new System.Drawing.Point(0, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(623, 71);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sample01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Controls.Add(this.RIGHTPANEL);
            this.Controls.Add(this.LEFTPANEL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sample01";
            this.Text = "Sample01";
            this.left_panel_common.ResumeLayout(false);
            this.LEFTPANEL.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Panel left_panel_common;
        protected Panel LEFTPANEL;
        protected Panel BtnBackPanel;
        protected Button btnBack;
        protected Label label1;
        protected Panel UserPanel;
        protected Label User;
        protected Panel right_panel;
        protected Panel RIGHTPANEL;
        protected Panel panel1;
        protected TableLayoutPanel tableLayoutPanel1;
        protected Button btn_Delete;
        protected Button btn_Edit;
        protected Button btn_Add;
        protected Button btn_Save;
        private Label label3;
        protected Button btn_View;
        private TextBox txt_search;
        protected Panel panel2;
        protected FlowLayoutPanel left_panel;
        protected GroupBox groupBox1;
    }
}