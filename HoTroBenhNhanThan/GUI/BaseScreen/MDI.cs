using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoTroBenhNhanThan.API;

namespace HoTroBenhNhanThan
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\cms_connect";
            if (File.Exists(path))
            {
                LoginWindow lw = new LoginWindow();
                LibMainClass.showWindow(lw,  MDI.ActiveForm);
            }
            else
            {
                SettingWindow lw = new SettingWindow();
                LibMainClass.showWindow(lw,  MDI.ActiveForm);
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingWindow lw = new SettingWindow();
            LibMainClass.showWindow(lw, MDI.ActiveForm);
        }
    }
}
