namespace HoTroBenhNhanThan
{
    partial class RoleWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.LEFTPANEL.SuspendLayout();
            this.left_panel.SuspendLayout();
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
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.label3);
            this.flowPanel.Controls.Add(this.txt_role);
            this.flowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanel_Paint);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Role";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(10, 29);
            this.txt_role.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(301, 27);
            this.txt_role.TabIndex = 2;
            this.txt_role.TextChanged += new System.EventHandler(this.txt_role_TextChanged);
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
            this.RoleIDGV,
            this.RoleGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(943, 601);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // RoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "RoleWindow";
            this.Text = "RoleWindow";
            this.Load += new System.EventHandler(this.RoleWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.LEFTPANEL.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_role;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn RoleIDGV;
        private DataGridViewTextBoxColumn RoleGV;
    }
}