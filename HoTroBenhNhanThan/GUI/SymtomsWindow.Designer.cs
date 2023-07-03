namespace HoTroBenhNhanThan.GUI
{
    partial class SymtomsWindow
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_symptom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_disease = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.flowPanel.Controls.Add(this.label7);
            this.flowPanel.Controls.Add(this.txt_symptom);
            this.flowPanel.Controls.Add(this.label8);
            this.flowPanel.Controls.Add(this.cb_disease);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(10, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Symptom";
            // 
            // txt_symptom
            // 
            this.txt_symptom.Enabled = false;
            this.txt_symptom.Location = new System.Drawing.Point(10, 29);
            this.txt_symptom.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_symptom.MaxLength = 50;
            this.txt_symptom.Name = "txt_symptom";
            this.txt_symptom.Size = new System.Drawing.Size(303, 27);
            this.txt_symptom.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(10, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Disease";
            // 
            // cb_disease
            // 
            this.cb_disease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_disease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_disease.FormattingEnabled = true;
            this.cb_disease.Location = new System.Drawing.Point(10, 82);
            this.cb_disease.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cb_disease.Name = "cb_disease";
            this.cb_disease.Size = new System.Drawing.Size(303, 28);
            this.cb_disease.TabIndex = 16;
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
            this.symptomGV,
            this.symptomIDGV,
            this.diseaseIDGV,
            this.DiseaseGV});
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
            this.dataGridView1.TabIndex = 2;
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
            // symptomGV
            // 
            this.symptomGV.HeaderText = "Symptom";
            this.symptomGV.MinimumWidth = 6;
            this.symptomGV.Name = "symptomGV";
            this.symptomGV.ReadOnly = true;
            // 
            // symptomIDGV
            // 
            this.symptomIDGV.HeaderText = "SymptomIDGV";
            this.symptomIDGV.MinimumWidth = 6;
            this.symptomIDGV.Name = "symptomIDGV";
            this.symptomIDGV.ReadOnly = true;
            this.symptomIDGV.Visible = false;
            // 
            // diseaseIDGV
            // 
            this.diseaseIDGV.HeaderText = "DiseaseID";
            this.diseaseIDGV.MinimumWidth = 6;
            this.diseaseIDGV.Name = "diseaseIDGV";
            this.diseaseIDGV.ReadOnly = true;
            this.diseaseIDGV.Visible = false;
            // 
            // DiseaseGV
            // 
            this.DiseaseGV.HeaderText = "Disease";
            this.DiseaseGV.MinimumWidth = 6;
            this.DiseaseGV.Name = "DiseaseGV";
            this.DiseaseGV.ReadOnly = true;
            // 
            // SymtomsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Name = "SymtomsWindow";
            this.Text = "SymtomsWindow";
            this.Load += new System.EventHandler(this.SymtomsWindow_Load);
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

        private Label label7;
        private TextBox txt_symptom;
        private Label label8;
        private ComboBox cb_disease;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn symptomGV;
        private DataGridViewTextBoxColumn symptomIDGV;
        private DataGridViewTextBoxColumn diseaseIDGV;
        private DataGridViewTextBoxColumn DiseaseGV;
    }
}