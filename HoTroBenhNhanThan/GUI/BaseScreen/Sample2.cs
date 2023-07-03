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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }
        public static int edit = 0;
        private void button1_Click(object sender, EventArgs e) // add click
        {
            LibMainClass.resetEnable(LEFTPANEL);    
            edit= 0;
        }

        private void button2_Click(object sender, EventArgs e) // edit click
        {
            edit = 1;
            LibMainClass.EnableControl(LEFTPANEL);
        }

        public virtual void button3_Click(object sender, EventArgs e)    // save click
        {

        }

        public virtual void button4_Click(object sender, EventArgs e)   //delete click
        {

        }
        public virtual void btn_View_Click(object sender, EventArgs e)         // view click
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            LibMainClass.showWindow(homeWindow, this, MDI.ActiveForm);
        }

      
    }
}
