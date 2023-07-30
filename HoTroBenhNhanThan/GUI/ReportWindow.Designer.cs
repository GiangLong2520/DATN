using System.Windows.Forms;

namespace HoTroBenhNhanThan.GUI
{
    partial class ReportWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.left_panel_common = new System.Windows.Forms.Panel();
            this.LEFTPANEL = new System.Windows.Forms.Panel();
            this.BtnBackPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.right_panel = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RIGHTPANEL = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.LEFTPANEL.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // left_panel_common
            // 
            this.left_panel_common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_panel_common.Location = new System.Drawing.Point(0, 71);
            this.left_panel_common.Name = "left_panel_common";
            this.left_panel_common.Size = new System.Drawing.Size(323, 680);
            this.left_panel_common.TabIndex = 1;
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
            this.LEFTPANEL.Size = new System.Drawing.Size(323, 751);
            this.LEFTPANEL.TabIndex = 1;
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
            // right_panel
            // 
            this.right_panel.Controls.Add(this.reportViewer1);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.Location = new System.Drawing.Point(0, 0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(568, 680);
            this.right_panel.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
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
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(568, 680);
            this.reportViewer1.TabIndex = 0;
            // 
            // RIGHTPANEL
            // 
            this.RIGHTPANEL.Controls.Add(this.panel1);
            this.RIGHTPANEL.Controls.Add(this.UserPanel);
            this.RIGHTPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RIGHTPANEL.Location = new System.Drawing.Point(323, 0);
            this.RIGHTPANEL.Name = "RIGHTPANEL";
            this.RIGHTPANEL.Size = new System.Drawing.Size(568, 751);
            this.RIGHTPANEL.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.right_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 680);
            this.panel1.TabIndex = 1;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.User);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(568, 71);
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
            // ReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 751);
            this.Controls.Add(this.RIGHTPANEL);
            this.Controls.Add(this.LEFTPANEL);
            this.Name = "ReportWindow";
            this.Text = "ReportWindow";
            this.Load += new System.EventHandler(this.ReportWindow_Load);
            this.LEFTPANEL.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Panel LEFTPANEL;
        protected Panel left_panel_common;
        protected Panel BtnBackPanel;
        protected Label label1;
        protected Panel right_panel;
        private Button button1;
        protected Button btnBack;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        protected Panel RIGHTPANEL;
        protected Panel panel1;
        protected Panel UserPanel;
        protected Label User;
    }
}