using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroBenhNhanThan
{
    public partial class HomeWindow : Sample
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void btn_Roles_Click(object sender, EventArgs e)
        {
            RoleWindow rw = new RoleWindow();
            LibMainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btn_staffs_Click(object sender, EventArgs e)
        {

        }

        private void btn_benhAn_Click(object sender, EventArgs e)
        {
            BenhAnWindow benhAnform = new BenhAnWindow();
            LibMainClass.showWindow(benhAnform, this, MDI.ActiveForm);
        }
    }
}
