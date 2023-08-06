namespace HoTroBenhNhanThan
{
    partial class SettingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWindow));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Db = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.LEFTPANEL.SuspendLayout();
            this.left_panel_common.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel_common
            // 
            this.left_panel_common.Controls.Add(this.btn_Save);
            this.left_panel_common.Controls.Add(this.isCB);
            this.left_panel_common.Controls.Add(this.txt_source);
            this.left_panel_common.Controls.Add(this.label5);
            this.left_panel_common.Controls.Add(this.txt_Db);
            this.left_panel_common.Controls.Add(this.label4);
            this.left_panel_common.Controls.Add(this.txt_userid);
            this.left_panel_common.Controls.Add(this.label3);
            this.left_panel_common.Controls.Add(this.txt_pass);
            this.left_panel_common.Controls.Add(this.label2);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // right_panel
            // 
            this.right_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_panel.BackgroundImage")));
            this.right_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(3, 327);
            this.txt_pass.MaxLength = 50;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(313, 27);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "User ID";
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(3, 274);
            this.txt_userid.MaxLength = 50;
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(313, 27);
            this.txt_userid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Database";
            // 
            // txt_Db
            // 
            this.txt_Db.Location = new System.Drawing.Point(3, 221);
            this.txt_Db.MaxLength = 200;
            this.txt_Db.Name = "txt_Db";
            this.txt_Db.Size = new System.Drawing.Size(313, 27);
            this.txt_Db.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "DataSource";
            // 
            // txt_source
            // 
            this.txt_source.Location = new System.Drawing.Point(3, 168);
            this.txt_source.MaxLength = 200;
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(313, 27);
            this.txt_source.TabIndex = 1;
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(4, 364);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(166, 24);
            this.isCB.TabIndex = 2;
            this.isCB.Text = "Intergrated Sercurity";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 2;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(7, 408);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(309, 53);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "SettingWindow";
            this.Text = "Setting...";
            this.LEFTPANEL.ResumeLayout(false);
            this.left_panel_common.ResumeLayout(false);
            this.left_panel_common.PerformLayout();
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Save;
        private CheckBox isCB;
        private TextBox txt_source;
        private Label label5;
        private TextBox txt_Db;
        private Label label4;
        private TextBox txt_userid;
        private Label label3;
        private TextBox txt_pass;
        private Label label2;
    }
}