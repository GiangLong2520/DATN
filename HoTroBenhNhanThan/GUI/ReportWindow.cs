using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroBenhNhanThan.GUI
{
    public partial class ReportWindow : Form
    {
        public ReportWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            LibMainClass.showWindow(homeWindow, this, MDI.ActiveForm);
        }

        private void ReportWindow_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "HoTroBenhNhanThan.Report1.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
