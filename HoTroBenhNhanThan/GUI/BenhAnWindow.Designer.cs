namespace HoTroBenhNhanThan
{
    partial class BenhAnWindow
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
            this.dgv_BenhAn = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.LEFTPANEL.SuspendLayout();
            this.left_panel_common.SuspendLayout();
            this.BtnBackPanel.SuspendLayout();
            this.RIGHTPANEL.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhAn)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_BenhAn);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // dgv_BenhAn
            // 
            this.dgv_BenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BenhAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BenhAn.Location = new System.Drawing.Point(3, 23);
            this.dgv_BenhAn.Name = "dgv_BenhAn";
            this.dgv_BenhAn.RowHeadersWidth = 51;
            this.dgv_BenhAn.RowTemplate.Height = 29;
            this.dgv_BenhAn.Size = new System.Drawing.Size(943, 601);
            this.dgv_BenhAn.TabIndex = 0;
            // 
            // BenhAnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "BenhAnWindow";
            this.Text = "BenhAnWindow";
            this.groupBox1.ResumeLayout(false);
            this.LEFTPANEL.ResumeLayout(false);
            this.left_panel_common.ResumeLayout(false);
            this.BtnBackPanel.ResumeLayout(false);
            this.RIGHTPANEL.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_BenhAn;
    }
}