namespace HoTroBenhNhanThan.GUI
{
    partial class PaymentWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apointDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
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
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.TurnGV,
            this.patientIDGV,
            this.patientGV,
            this.GuardGV,
            this.ageGV,
            this.phoneGV,
            this.apointDateGV,
            this.doctorGV,
            this.DoctorIDGV,
            this.appIDGV,
            this.statusGV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 601);
            this.dataGridView1.TabIndex = 2;
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
            // TurnGV
            // 
            this.TurnGV.HeaderText = "Turn";
            this.TurnGV.MinimumWidth = 6;
            this.TurnGV.Name = "TurnGV";
            this.TurnGV.ReadOnly = true;
            // 
            // patientIDGV
            // 
            this.patientIDGV.HeaderText = "ID";
            this.patientIDGV.MinimumWidth = 6;
            this.patientIDGV.Name = "patientIDGV";
            this.patientIDGV.ReadOnly = true;
            this.patientIDGV.Visible = false;
            // 
            // patientGV
            // 
            this.patientGV.HeaderText = "Patient";
            this.patientGV.MinimumWidth = 6;
            this.patientGV.Name = "patientGV";
            this.patientGV.ReadOnly = true;
            // 
            // GuardGV
            // 
            this.GuardGV.HeaderText = "Guardian";
            this.GuardGV.MinimumWidth = 6;
            this.GuardGV.Name = "GuardGV";
            this.GuardGV.ReadOnly = true;
            // 
            // ageGV
            // 
            this.ageGV.HeaderText = "Age";
            this.ageGV.MinimumWidth = 6;
            this.ageGV.Name = "ageGV";
            this.ageGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.MinimumWidth = 6;
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // apointDateGV
            // 
            this.apointDateGV.HeaderText = "Apointment For";
            this.apointDateGV.MinimumWidth = 6;
            this.apointDateGV.Name = "apointDateGV";
            this.apointDateGV.ReadOnly = true;
            // 
            // doctorGV
            // 
            this.doctorGV.HeaderText = "Doctor";
            this.doctorGV.MinimumWidth = 6;
            this.doctorGV.Name = "doctorGV";
            this.doctorGV.ReadOnly = true;
            // 
            // DoctorIDGV
            // 
            this.DoctorIDGV.HeaderText = "DoctorID";
            this.DoctorIDGV.MinimumWidth = 6;
            this.DoctorIDGV.Name = "DoctorIDGV";
            this.DoctorIDGV.Visible = false;
            // 
            // appIDGV
            // 
            this.appIDGV.HeaderText = "APPID";
            this.appIDGV.MinimumWidth = 6;
            this.appIDGV.Name = "appIDGV";
            this.appIDGV.Visible = false;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // PaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "PaymentWindow";
            this.Text = "PaymentWindow";
            this.groupBox1.ResumeLayout(false);
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

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn TurnGV;
        private DataGridViewTextBoxColumn patientIDGV;
        private DataGridViewTextBoxColumn patientGV;
        private DataGridViewTextBoxColumn GuardGV;
        private DataGridViewTextBoxColumn ageGV;
        private DataGridViewTextBoxColumn phoneGV;
        private DataGridViewTextBoxColumn apointDateGV;
        private DataGridViewTextBoxColumn doctorGV;
        private DataGridViewTextBoxColumn DoctorIDGV;
        private DataGridViewTextBoxColumn appIDGV;
        private DataGridViewTextBoxColumn statusGV;
    }
}