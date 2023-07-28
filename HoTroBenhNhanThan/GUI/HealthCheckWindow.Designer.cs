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
            this.t = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.v = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_selectPatient = new System.Windows.Forms.ComboBox();
            this.left_panel_common.SuspendLayout();
            this.LEFTPANEL.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel_common
            // 
            this.left_panel_common.Size = new System.Drawing.Size(500, 932);
            // 
            // LEFTPANEL
            // 
            this.LEFTPANEL.Size = new System.Drawing.Size(500, 1003);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // right_panel
            // 
            this.right_panel.Size = new System.Drawing.Size(772, 932);
            // 
            // RIGHTPANEL
            // 
            this.RIGHTPANEL.Size = new System.Drawing.Size(772, 1003);
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.label9);
            this.left_panel.Controls.Add(this.picker_DateTime);
            this.left_panel.Controls.Add(this.label24);
            this.left_panel.Controls.Add(this.cb_selectPatient);
            this.left_panel.Controls.Add(this.t);
            this.left_panel.Controls.Add(this.txt_phone);
            this.left_panel.Controls.Add(this.v);
            this.left_panel.Controls.Add(this.txtage);
            this.left_panel.Size = new System.Drawing.Size(500, 870);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(772, 870);
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
            this.picker_DateTime.Size = new System.Drawing.Size(479, 27);
            this.picker_DateTime.TabIndex = 21;
            this.picker_DateTime.TabStop = false;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(10, 122);
            this.t.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(50, 20);
            this.t.TabIndex = 85;
            this.t.Text = "Phone";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(10, 148);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_phone.MaxLength = 50;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(479, 27);
            this.txt_phone.TabIndex = 87;
            this.txt_phone.TabStop = false;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(10, 181);
            this.v.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(36, 20);
            this.v.TabIndex = 86;
            this.v.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(10, 207);
            this.txtage.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtage.MaxLength = 50;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(479, 27);
            this.txtage.TabIndex = 88;
            this.txtage.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 62);
            this.label24.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 20);
            this.label24.TabIndex = 89;
            this.label24.Text = "Select Patient";
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
            this.cb_selectPatient.Size = new System.Drawing.Size(479, 28);
            this.cb_selectPatient.TabIndex = 90;
            this.cb_selectPatient.DropDown += new System.EventHandler(this.Dropdown);
            // 
            // HealthCheckWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 1003);
            this.Name = "HealthCheckWindow";
            this.Text = "HealthCheck";
            this.Load += new System.EventHandler(this.HealthCheckWindow_Load);
            this.left_panel_common.ResumeLayout(false);
            this.LEFTPANEL.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label9;
        private DateTimePicker picker_DateTime;
        private Label t;
        private TextBox txt_phone;
        private Label v;
        private TextBox txtage;
        private Label label24;
        private ComboBox cb_selectPatient;
    }
}