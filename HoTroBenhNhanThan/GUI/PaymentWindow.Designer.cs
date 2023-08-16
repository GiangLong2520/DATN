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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.SymptomGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeesGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InMedicineGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExMedicineGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.picker_DateTime = new System.Windows.Forms.DateTimePicker();
            this.btn_load = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.LEFTPANEL.SuspendLayout();
            this.left_panel_common.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.reportViewer1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.reportViewer1);
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.label12);
            this.left_panel.Controls.Add(this.picker_DateTime);
            this.left_panel.Controls.Add(this.checkBox1);
            this.left_panel.Controls.Add(this.btn_load);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(941, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Controls.Add(this.button2);
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 1;
            this.reportViewer1.Location = new System.Drawing.Point(3, 23);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(943, 601);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.statusGV,
            this.SymptomGV,
            this.RemarkGV,
            this.FeesGV,
            this.DiseaseGV,
            this.InMedicineGV,
            this.ExMedicineGV,
            this.DiscountGV,
            this.TotalGV,
            this.printBtn});
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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 601);
            this.dataGridView1.TabIndex = 2;
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
            // TurnGV
            // 
            this.TurnGV.HeaderText = "Turn";
            this.TurnGV.MinimumWidth = 6;
            this.TurnGV.Name = "TurnGV";
            this.TurnGV.ReadOnly = true;
            this.TurnGV.Visible = false;
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
            this.apointDateGV.HeaderText = "Date Time";
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
            // SymptomGV
            // 
            this.SymptomGV.HeaderText = "Symptom";
            this.SymptomGV.MinimumWidth = 6;
            this.SymptomGV.Name = "SymptomGV";
            this.SymptomGV.ReadOnly = true;
            this.SymptomGV.Visible = false;
            // 
            // RemarkGV
            // 
            this.RemarkGV.HeaderText = "Remark";
            this.RemarkGV.MinimumWidth = 6;
            this.RemarkGV.Name = "RemarkGV";
            this.RemarkGV.ReadOnly = true;
            this.RemarkGV.Visible = false;
            // 
            // FeesGV
            // 
            this.FeesGV.HeaderText = "Fees";
            this.FeesGV.MinimumWidth = 6;
            this.FeesGV.Name = "FeesGV";
            this.FeesGV.ReadOnly = true;
            // 
            // DiseaseGV
            // 
            this.DiseaseGV.HeaderText = "Disease";
            this.DiseaseGV.MinimumWidth = 6;
            this.DiseaseGV.Name = "DiseaseGV";
            this.DiseaseGV.ReadOnly = true;
            this.DiseaseGV.Visible = false;
            // 
            // InMedicineGV
            // 
            this.InMedicineGV.HeaderText = "InMedicine";
            this.InMedicineGV.MinimumWidth = 6;
            this.InMedicineGV.Name = "InMedicineGV";
            this.InMedicineGV.ReadOnly = true;
            this.InMedicineGV.Visible = false;
            // 
            // ExMedicineGV
            // 
            this.ExMedicineGV.HeaderText = "ExMedicine";
            this.ExMedicineGV.MinimumWidth = 6;
            this.ExMedicineGV.Name = "ExMedicineGV";
            this.ExMedicineGV.ReadOnly = true;
            this.ExMedicineGV.Visible = false;
            // 
            // DiscountGV
            // 
            this.DiscountGV.HeaderText = "Discount %";
            this.DiscountGV.MinimumWidth = 6;
            this.DiscountGV.Name = "DiscountGV";
            this.DiscountGV.ReadOnly = true;
            // 
            // TotalGV
            // 
            this.TotalGV.HeaderText = "Total Fees";
            this.TotalGV.MinimumWidth = 6;
            this.TotalGV.Name = "TotalGV";
            this.TotalGV.ReadOnly = true;
            // 
            // printBtn
            // 
            this.printBtn.HeaderText = "Action";
            this.printBtn.MinimumWidth = 6;
            this.printBtn.Name = "printBtn";
            this.printBtn.Text = "Print";
            this.printBtn.UseColumnTextForButtonValue = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = "Select Date";
            // 
            // picker_DateTime
            // 
            this.picker_DateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picker_DateTime.CustomFormat = "dd-MMM-yyyy";
            this.picker_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.picker_DateTime.Location = new System.Drawing.Point(3, 29);
            this.picker_DateTime.Name = "picker_DateTime";
            this.picker_DateTime.Size = new System.Drawing.Size(314, 27);
            this.picker_DateTime.TabIndex = 68;
            this.picker_DateTime.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.FlatAppearance.BorderSize = 2;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_load.Location = new System.Drawing.Point(3, 92);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(314, 45);
            this.btn_load.TabIndex = 69;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 24);
            this.checkBox1.TabIndex = 70;
            this.checkBox1.Text = "Take both completed";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "PaymentWindow";
            this.Text = "PaymentWindow";
            this.Load += new System.EventHandler(this.PaymentWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.LEFTPANEL.ResumeLayout(false);
            this.left_panel_common.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.reportViewer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label12;
        public DateTimePicker picker_DateTime;
        private Button btn_load;

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button button2;
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
        private DataGridViewTextBoxColumn SymptomGV;
        private DataGridViewTextBoxColumn RemarkGV;
        private DataGridViewTextBoxColumn FeesGV;
        private DataGridViewTextBoxColumn DiseaseGV;
        private DataGridViewTextBoxColumn InMedicineGV;
        private DataGridViewTextBoxColumn ExMedicineGV;
        private DataGridViewTextBoxColumn DiscountGV;
        private DataGridViewTextBoxColumn TotalGV;
        private DataGridViewButtonColumn printBtn;
        private CheckBox checkBox1;
    }
}