namespace HoTroBenhNhanThan
{
    partial class Sample
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sample));
            this.LEFTPANEL = new System.Windows.Forms.Panel();
            this.left_panel_common = new System.Windows.Forms.Panel();
            this.BtnBackPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RIGHTPANEL = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.LEFTPANEL.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LEFTPANEL
            // 
            this.LEFTPANEL.BackColor = System.Drawing.Color.DarkGreen;
            this.LEFTPANEL.Controls.Add(this.left_panel_common);
            this.LEFTPANEL.Controls.Add(this.BtnBackPanel);
            this.LEFTPANEL.Dock = System.Windows.Forms.DockStyle.Left;
            this.LEFTPANEL.ForeColor = System.Drawing.Color.White;
            this.LEFTPANEL.Location = new System.Drawing.Point(0, 0);
            this.LEFTPANEL.Name = "LEFTPANEL";
            this.LEFTPANEL.Size = new System.Drawing.Size(323, 760);
            this.LEFTPANEL.TabIndex = 0;
            // 
            // left_panel_common
            // 
            this.left_panel_common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_panel_common.Location = new System.Drawing.Point(0, 71);
            this.left_panel_common.Name = "left_panel_common";
            this.left_panel_common.Size = new System.Drawing.Size(323, 689);
            this.left_panel_common.TabIndex = 1;
            // 
            // BtnBackPanel
            // 
            this.BtnBackPanel.Controls.Add(this.btnBack);
            this.BtnBackPanel.Controls.Add(this.label1);
            this.BtnBackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBackPanel.Location = new System.Drawing.Point(0, 0);
            this.BtnBackPanel.Name = "BtnBackPanel";
            this.BtnBackPanel.Size = new System.Drawing.Size(323, 71);
            this.BtnBackPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 71);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(183, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RIGHTPANEL
            // 
            this.RIGHTPANEL.Controls.Add(this.right_panel);
            this.RIGHTPANEL.Controls.Add(this.UserPanel);
            this.RIGHTPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RIGHTPANEL.Location = new System.Drawing.Point(323, 0);
            this.RIGHTPANEL.Name = "RIGHTPANEL";
            this.RIGHTPANEL.Size = new System.Drawing.Size(949, 760);
            this.RIGHTPANEL.TabIndex = 0;
            // 
            // right_panel
            // 
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.Location = new System.Drawing.Point(0, 71);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(949, 689);
            this.right_panel.TabIndex = 1;
            this.right_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.right_panel_Paint);
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.User);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(949, 71);
            this.UserPanel.TabIndex = 0;
            // 
            // User
            // 
            this.User.Dock = System.Windows.Forms.DockStyle.Left;
            this.User.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.ForeColor = System.Drawing.Color.DarkGreen;
            this.User.Location = new System.Drawing.Point(0, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(623, 71);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.ControlBox = false;
            this.Controls.Add(this.RIGHTPANEL);
            this.Controls.Add(this.LEFTPANEL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sample";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Sample_Load);
            this.LEFTPANEL.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Panel LEFTPANEL;
        protected Panel left_panel_common;
        protected Panel BtnBackPanel;
        protected Button btnBack;
        protected Label label1;
        protected Panel RIGHTPANEL;
        protected Panel UserPanel;
        protected Label User;
        protected Panel right_panel;
    }
}