using HoTroBenhNhanThan.GUI;
using HoTroBenhNhanThan.GUI.BaseScreen;
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
            StaffWindow staff = new StaffWindow();
            LibMainClass.showWindow(staff, this, MDI.ActiveForm);
        }

        private void btn_benhAn_Click(object sender, EventArgs e)
        {
            BenhAnWindow benhAnform = new BenhAnWindow();
            LibMainClass.showWindow(benhAnform, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserWindow userform = new UserWindow();
            LibMainClass.showWindow(userform, this, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MedicineWindow Mediform = new MedicineWindow();
            LibMainClass.showWindow(Mediform, this, MDI.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PatienRegisterWindow patienform = new PatienRegisterWindow();
            LibMainClass.showWindow(patienform, this, MDI.ActiveForm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BioTestWinform bioform = new BioTestWinform();
            LibMainClass.showWindow(bioform, this, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TurnWindow turnWin = new TurnWindow();
            LibMainClass.showWindow(turnWin, this, MDI.ActiveForm);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UrineTestWinform sam = new UrineTestWinform();

            LibMainClass.showWindow(sam, this, MDI.ActiveForm);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            BloodTestWinform blood = new BloodTestWinform();
            LibMainClass.showWindow(blood, this, MDI.ActiveForm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SymtomsWindow scr= new SymtomsWindow();
            LibMainClass.showWindow(scr, this, MDI.ActiveForm);
        }
    }
}
