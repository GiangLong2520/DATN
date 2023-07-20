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
            label2 = new Label();
            txt_user = new TextBox();
            label3 = new Label();
            txt_password = new TextBox();
            btn_Login = new Button();
            LEFTPANEL.SuspendLayout();
            left_panel_common.SuspendLayout();
            BtnBackPanel.SuspendLayout();
            RIGHTPANEL.SuspendLayout();
            UserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // left_panel
            // 
            left_panel_common.Controls.Add(btn_Login);
            left_panel_common.Controls.Add(txt_password);
            left_panel_common.Controls.Add(label3);
            left_panel_common.Controls.Add(txt_user);
            left_panel_common.Controls.Add(label2);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 173);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "User Name";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(10, 190);
            txt_user.Margin = new Padding(3, 2, 3, 2);
            txt_user.MaxLength = 50;
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(260, 23);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += txt_user_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 214);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(10, 232);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.MaxLength = 50;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(260, 23);
            txt_password.TabIndex = 1;
            txt_password.UseSystemPasswordChar = true;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_Login
            // 
            btn_Login.FlatAppearance.BorderSize = 2;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(10, 264);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(259, 35);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // LoginWindow
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 570);
            Name = "LoginWindow";
            Text = "LoginWindow";
            Load += LoginWindow_Load;
            LEFTPANEL.ResumeLayout(false);
            left_panel_common.ResumeLayout(false);
            left_panel_common.PerformLayout();
            BtnBackPanel.ResumeLayout(false);
            RIGHTPANEL.ResumeLayout(false);
            UserPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Login;
        private TextBox txt_password;
        private Label label3;
        private TextBox txt_user;
        private Label label2;
    }
}