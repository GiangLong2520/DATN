namespace HoTroBenhNhanThan.GUI
{
    partial class HealthCheckWindow
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
            this.label9 = new System.Windows.Forms.Label();
            this.picker_DateTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_selectPatient = new System.Windows.Forms.ComboBox();
            this.btnCall = new System.Windows.Forms.Button();
            this.flowPanel.SuspendLayout();
            this.LEFTPANEL.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 2;
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.label9);
            this.flowPanel.Controls.Add(this.picker_DateTime);
            this.flowPanel.Controls.Add(this.label8);
            this.flowPanel.Controls.Add(this.cb_selectPatient);
            this.flowPanel.Controls.Add(this.btnCall);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Date";
            // 
            // picker_DateTime
            // 
            this.picker_DateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picker_DateTime.CustomFormat = "dd-MMM-yyyy";
            this.picker_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.picker_DateTime.Location = new System.Drawing.Point(10, 29);
            this.picker_DateTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.picker_DateTime.Name = "picker_DateTime";
            this.picker_DateTime.Size = new System.Drawing.Size(303, 27);
            this.picker_DateTime.TabIndex = 21;
            this.picker_DateTime.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(10, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Select Patient";
            // 
            // cb_selectPatient
            // 
            this.cb_selectPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_selectPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_selectPatient.FormattingEnabled = true;
            this.cb_selectPatient.Items.AddRange(new object[] {
            "Internal",
            "External"});
            this.cb_selectPatient.Location = new System.Drawing.Point(10, 88);
            this.cb_selectPatient.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cb_selectPatient.Name = "cb_selectPatient";
            this.cb_selectPatient.Size = new System.Drawing.Size(303, 28);
            this.cb_selectPatient.TabIndex = 23;
            // 
            // btnCall
            // 
            this.btnCall.FlatAppearance.BorderSize = 2;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.Location = new System.Drawing.Point(10, 122);
            this.btnCall.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(301, 53);
            this.btnCall.TabIndex = 24;
            this.btnCall.Text = "CALL PATIENT";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // HealthCheckWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "HealthCheckWindow";
            this.Text = "HealthCheck";
            this.Load += new System.EventHandler(this.HealthCheckWindow_Load);
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.LEFTPANEL.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label9;
        private DateTimePicker picker_DateTime;
        private Label label8;
        private ComboBox cb_selectPatient;
        private Button btnCall;
    }
}