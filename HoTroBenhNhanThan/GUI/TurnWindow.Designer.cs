namespace HoTroBenhNhanThan.GUI
{
    partial class TurnWindow
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_token = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LEFTPANEL.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel_common
            // 
            this.left_panel_common.Paint += new System.Windows.Forms.PaintEventHandler(this.left_panel_common_Paint);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // RIGHTPANEL
            // 
            this.RIGHTPANEL.Size = new System.Drawing.Size(868, 760);
            // 
            // UserPanel
            // 
            this.UserPanel.Size = new System.Drawing.Size(868, 71);
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.label2);
            this.right_panel.Controls.Add(this.lb_token);
            this.right_panel.Size = new System.Drawing.Size(868, 689);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_token
            // 
            this.lb_token.AutoSize = true;
            this.lb_token.Font = new System.Drawing.Font("Segoe UI", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_token.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_token.Location = new System.Drawing.Point(140, 275);
            this.lb_token.Name = "lb_token";
            this.lb_token.Size = new System.Drawing.Size(591, 221);
            this.lb_token.TabIndex = 0;
            this.lb_token.Text = "CLINIC";
            this.lb_token.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "It\'s your turn number...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TurnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 760);
            this.Name = "TurnWindow";
            this.Text = "TurnWindow";
            this.Load += new System.EventHandler(this.TurnWindow_Load);
            this.LEFTPANEL.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.right_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label lb_token;
    }
}