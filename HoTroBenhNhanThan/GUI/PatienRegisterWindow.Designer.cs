namespace HoTroBenhNhanThan.GUI
{
    partial class PatienRegisterWindow
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
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Father = new System.Windows.Forms.TextBox();
            this.Picker_ApointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_ApointmentFor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picker_LastApointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_consultsTo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Patient = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apointDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.flowPanel.Controls.Add(this.label4);
            this.flowPanel.Controls.Add(this.txt_Phone);
            this.flowPanel.Controls.Add(this.label2);
            this.flowPanel.Controls.Add(this.txt_Patient);
            this.flowPanel.Controls.Add(this.label12);
            this.flowPanel.Controls.Add(this.txt_age);
            this.flowPanel.Controls.Add(this.label5);
            this.flowPanel.Controls.Add(this.txt_Father);
            this.flowPanel.Controls.Add(this.label6);
            this.flowPanel.Controls.Add(this.Picker_ApointmentDate);
            this.flowPanel.Controls.Add(this.label8);
            this.flowPanel.Controls.Add(this.cb_ApointmentFor);
            this.flowPanel.Controls.Add(this.label7);
            this.flowPanel.Controls.Add(this.label9);
            this.flowPanel.Controls.Add(this.picker_LastApointmentDate);
            this.flowPanel.Controls.Add(this.label10);
            this.flowPanel.Controls.Add(this.txt_consultsTo);
            this.flowPanel.Controls.Add(this.label11);
            this.flowPanel.Controls.Add(this.txt_Status);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(10, 29);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_Phone.MaxLength = 50;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(303, 27);
            this.txt_Phone.TabIndex = 4;
            this.txt_Phone.UseSystemPasswordChar = true;
            this.txt_Phone.Leave += new System.EventHandler(this.PhoneTxt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patient";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(10, 147);
            this.txt_age.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_age.MaxLength = 50;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(303, 27);
            this.txt_age.TabIndex = 6;
            this.txt_age.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Father/Mother/Guardian";
            // 
            // txt_Father
            // 
            this.txt_Father.Location = new System.Drawing.Point(10, 206);
            this.txt_Father.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_Father.MaxLength = 50;
            this.txt_Father.Name = "txt_Father";
            this.txt_Father.Size = new System.Drawing.Size(303, 27);
            this.txt_Father.TabIndex = 8;
            this.txt_Father.UseSystemPasswordChar = true;
            // 
            // Picker_ApointmentDate
            // 
            this.Picker_ApointmentDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Picker_ApointmentDate.CustomFormat = "dd-MMM-yyyy hh:mm";
            this.Picker_ApointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Picker_ApointmentDate.Location = new System.Drawing.Point(10, 265);
            this.Picker_ApointmentDate.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Picker_ApointmentDate.Name = "Picker_ApointmentDate";
            this.Picker_ApointmentDate.ShowUpDown = true;
            this.Picker_ApointmentDate.Size = new System.Drawing.Size(303, 27);
            this.Picker_ApointmentDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Appointment Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 298);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Apointment For";
            // 
            // cb_ApointmentFor
            // 
            this.cb_ApointmentFor.FormattingEnabled = true;
            this.cb_ApointmentFor.Location = new System.Drawing.Point(10, 324);
            this.cb_ApointmentFor.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cb_ApointmentFor.Name = "cb_ApointmentFor";
            this.cb_ApointmentFor.Size = new System.Drawing.Size(303, 28);
            this.cb_ApointmentFor.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 60);
            this.label7.TabIndex = 17;
            this.label7.Text = "Patient History";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 436);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Last Apointment Date";
            // 
            // picker_LastApointmentDate
            // 
            this.picker_LastApointmentDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picker_LastApointmentDate.CustomFormat = "dd-MMM-yyyy";
            this.picker_LastApointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.picker_LastApointmentDate.Location = new System.Drawing.Point(10, 462);
            this.picker_LastApointmentDate.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.picker_LastApointmentDate.Name = "picker_LastApointmentDate";
            this.picker_LastApointmentDate.Size = new System.Drawing.Size(303, 27);
            this.picker_LastApointmentDate.TabIndex = 19;
            this.picker_LastApointmentDate.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 495);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Consults To";
            // 
            // txt_consultsTo
            // 
            this.txt_consultsTo.Location = new System.Drawing.Point(10, 521);
            this.txt_consultsTo.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_consultsTo.MaxLength = 50;
            this.txt_consultsTo.Name = "txt_consultsTo";
            this.txt_consultsTo.Size = new System.Drawing.Size(303, 27);
            this.txt_consultsTo.TabIndex = 21;
            this.txt_consultsTo.TabStop = false;
            this.txt_consultsTo.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 554);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Status";
            // 
            // txt_Status
            // 
            this.txt_Status.Enabled = false;
            this.txt_Status.Location = new System.Drawing.Point(10, 580);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_Status.MaxLength = 50;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(303, 27);
            this.txt_Status.TabIndex = 23;
            this.txt_Status.TabStop = false;
            this.txt_Status.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Age";
            // 
            // txt_Patient
            // 
            this.txt_Patient.Location = new System.Drawing.Point(10, 88);
            this.txt_Patient.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_Patient.MaxLength = 50;
            this.txt_Patient.Name = "txt_Patient";
            this.txt_Patient.Size = new System.Drawing.Size(303, 27);
            this.txt_Patient.TabIndex = 25;
            this.txt_Patient.UseSystemPasswordChar = true;
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
            this.turnGV,
            this.statusGV,
            this.phoneGV,
            this.doctorGV,
            this.DoctorIDGV,
            this.patientIDGV,
            this.patientGV,
            this.GuardGV,
            this.ageGV,
            this.apointDateGV,
            this.appIDGV});
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
            // turnGV
            // 
            this.turnGV.HeaderText = "turn";
            this.turnGV.MinimumWidth = 6;
            this.turnGV.Name = "turnGV";
            this.turnGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.MinimumWidth = 6;
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
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
            this.DoctorIDGV.ReadOnly = true;
            this.DoctorIDGV.Visible = false;
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
            // apointDateGV
            // 
            this.apointDateGV.HeaderText = "Apointment For";
            this.apointDateGV.MinimumWidth = 6;
            this.apointDateGV.Name = "apointDateGV";
            this.apointDateGV.ReadOnly = true;
            // 
            // appIDGV
            // 
            this.appIDGV.HeaderText = "APPID";
            this.appIDGV.MinimumWidth = 6;
            this.appIDGV.Name = "appIDGV";
            this.appIDGV.ReadOnly = true;
            this.appIDGV.Visible = false;
            // 
            // PatienRegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "PatienRegisterWindow";
            this.Text = "Patien Registeration";
            this.Load += new System.EventHandler(this.PatienRegisterWindow_Load);
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

        private Label label4;
        private TextBox txt_Phone;
        private Label label2;
        private TextBox txt_age;
        private Label label5;
        private TextBox txt_Father;
        private Label label6;
        private DateTimePicker Picker_ApointmentDate;
        private Label label8;
        private ComboBox cb_ApointmentFor;
        private Label label7;
        private Label label9;
        private DateTimePicker picker_LastApointmentDate;
        private Label label10;
        private TextBox txt_consultsTo;
        private Label label11;
        private TextBox txt_Status;
        private TextBox txt_Patient;
        private Label label12;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn turnGV;
        private DataGridViewTextBoxColumn statusGV;
        private DataGridViewTextBoxColumn phoneGV;
        private DataGridViewTextBoxColumn doctorGV;
        private DataGridViewTextBoxColumn DoctorIDGV;
        private DataGridViewTextBoxColumn patientIDGV;
        private DataGridViewTextBoxColumn patientGV;
        private DataGridViewTextBoxColumn GuardGV;
        private DataGridViewTextBoxColumn ageGV;
        private DataGridViewTextBoxColumn apointDateGV;
        private DataGridViewTextBoxColumn appIDGV;
    }
}