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
            LibMainClass.LibMainClass.showWindow(homeWindow, this, MDI.ActiveForm);
        }

        private void btn_Add_Click(object sender, EventArgs e)               // add
        {
            LibMainClass.LibMainClass.resetEnable(left_panel);
            edit = 0;
        }

        private void btn_Edit_Click(object sender, EventArgs e)              // edit
        {
            edit = 1;
            LibMainClass.LibMainClass.EnableControl(left_panel);
        }

        public virtual void btn_Save_Click(object sender, EventArgs e)               //save
        {

        }

        public virtual void btn_Delete_Click(object sender, EventArgs e)           // delete
        {

        }

        public virtual void btn_View_Click(object sender, EventArgs e)             // view
        {

        }
    }
}
