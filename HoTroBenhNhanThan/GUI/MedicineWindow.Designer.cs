namespace HoTroBenhNhanThan.GUI
{
    partial class MedicineWindow
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
            this.txt_medi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.LEFTPANEL.SuspendLayout();
            this.left_panel_common.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.label2);
            this.left_panel.Controls.Add(this.txt_medi);
            this.left_panel.Controls.Add(this.label4);
            this.left_panel.Controls.Add(this.txt_company);
            this.left_panel.Controls.Add(this.label8);
            this.left_panel.Controls.Add(this.cb_Type);
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
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medicine";
            // 
            // txt_medi
            // 
            this.txt_medi.Location = new System.Drawing.Point(10, 43);
            this.txt_medi.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_medi.MaxLength = 50;
            this.txt_medi.Name = "txt_medi";
            this.txt_medi.Size = new System.Drawing.Size(303, 27);
            this.txt_medi.TabIndex = 7;
            this.txt_medi.TextChanged += new System.EventHandler(this.txt_medi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Company";
            // 
            // txt_company
            // 
            this.txt_company.Location = new System.Drawing.Point(10, 96);
            this.txt_company.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_company.MaxLength = 50;
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(303, 27);
            this.txt_company.TabIndex = 9;
            this.txt_company.TextChanged += new System.EventHandler(this.txt_company_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Type";
            // 
            // cb_Type
            // 
            this.cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "Internal",
            "External"});
            this.cb_Type.Location = new System.Drawing.Point(10, 149);
            this.cb_Type.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(303, 28);
            this.cb_Type.TabIndex = 14;
            this.cb_Type.SelectedIndexChanged += new System.EventHandler(this.DD_Type_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.MediIDGV,
            this.MedicineGV,
            this.CompanyGV,
            this.TypeGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 601);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // MediIDGV
            // 
            this.MediIDGV.HeaderText = "MediID";
            this.MediIDGV.MinimumWidth = 6;
            this.MediIDGV.Name = "MediIDGV";
            this.MediIDGV.ReadOnly = true;
            this.MediIDGV.Visible = false;
            // 
            // MedicineGV
            // 
            this.MedicineGV.HeaderText = "Medicine";
            this.MedicineGV.MinimumWidth = 6;
            this.MedicineGV.Name = "MedicineGV";
            this.MedicineGV.ReadOnly = true;
            // 
            // CompanyGV
            // 
            this.CompanyGV.HeaderText = "Company";
            this.CompanyGV.MinimumWidth = 6;
            this.CompanyGV.Name = "CompanyGV";
            this.CompanyGV.ReadOnly = true;
            // 
            // TypeGV
            // 
            this.TypeGV.HeaderText = "Type";
            this.TypeGV.MinimumWidth = 6;
            this.TypeGV.Name = "TypeGV";
            this.TypeGV.ReadOnly = true;
            // 
            // MedicineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "MedicineWindow";
            this.Text = "MedicineWindow";
            this.Load += new System.EventHandler(this.MedicineWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.LEFTPANEL.ResumeLayout(false);
            this.left_panel_common.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private TextBox txt_medi;
        private Label label4;
        private TextBox txt_company;
        private Label label8;
        private DataGridView dataGridView1;
        private ComboBox cb_Type;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn MediIDGV;
        private DataGridViewTextBoxColumn MedicineGV;
        private DataGridViewTextBoxColumn CompanyGV;
        private DataGridViewTextBoxColumn TypeGV;
    }
}