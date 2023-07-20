using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroBenhNhanThan.GUI.BaseScreen
{
    public partial class Sample01 : Form
    {
        public Sample01()
        {
            InitializeComponent();
        }
        public static int edit = 0;
        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            LibMainClass.showWindow(homeWindow, this, MDI.ActiveForm);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            LibMainClass.resetEnable(left_panel);
            edit = 0;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            edit = 1;
            LibMainClass.EnableControl(left_panel);
        }
    }
}
