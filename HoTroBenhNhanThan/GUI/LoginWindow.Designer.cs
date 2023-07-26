namespace HoTroBenhNhanThan
{
    partial class LoginWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.LEFTPANEL.SuspendLayout();
            this.left_panel_common.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LEFTPANEL
            // 
            this.LEFTPANEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LEFTPANEL.Size = new System.Drawing.Size(369, 760);
            // 
            // left_panel_common
            // 
            this.left_panel_common.Controls.Add(this.btn_Login);
            this.left_panel_common.Controls.Add(this.txt_password);
            this.left_panel_common.Controls.Add(this.label3);
            this.left_panel_common.Controls.Add(this.txt_user);
            this.left_panel_common.Controls.Add(this.label2);
            this.left_panel_common.Location = new System.Drawing.Point(0, 95);
            this.left_panel_common.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.left_panel_common.Size = new System.Drawing.Size(369, 665);
            // 
            // BtnBackPanel
            // 
            this.BtnBackPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBackPanel.Size = new System.Drawing.Size(369, 95);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Size = new System.Drawing.Size(107, 95);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(209, 0);
            this.label1.Size = new System.Drawing.Size(160, 95);
            // 
            // RIGHTPANEL
            // 
            this.RIGHTPANEL.Location = new System.Drawing.Point(369, 0);
            this.RIGHTPANEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RIGHTPANEL.Size = new System.Drawing.Size(903, 760);
            // 
            // UserPanel
            // 
            this.UserPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPanel.Size = new System.Drawing.Size(903, 95);
            // 
            // User
            // 
            this.User.Size = new System.Drawing.Size(712, 95);
            // 
            // right_panel
            // 
            this.right_panel.BackgroundImage = global::HoTroBenhNhanThan.Properties.Resources.bachmaihospital;
            this.right_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.right_panel.Location = new System.Drawing.Point(0, 95);
            this.right_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.right_panel.Size = new System.Drawing.Size(903, 665);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(11, 253);
            this.txt_user.MaxLength = 50;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(297, 27);
            this.txt_user.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(11, 309);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(297, 27);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.FlatAppearance.BorderSize = 2;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(11, 352);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(296, 47);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // LoginWindow
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.LEFTPANEL.ResumeLayout(false);
            this.left_panel_common.ResumeLayout(false);
            this.left_panel_common.PerformLayout();
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Login;
        private TextBox txt_password;
        private Label label3;
        private TextBox txt_user;
        private Label label2;
    }
}