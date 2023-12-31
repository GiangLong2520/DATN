﻿using HoTroBenhNhanThan.GUI;
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
            LibMainClass.LibMainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btn_staffs_Click(object sender, EventArgs e)
        {
            UserWindow userform = new UserWindow();
            LibMainClass.LibMainClass.showWindow(userform, this, MDI.ActiveForm);
        }

        private void btn_benhAn_Click(object sender, EventArgs e)
        {
            BenhAnWindow benhAnform = new BenhAnWindow();
            LibMainClass.LibMainClass.showWindow(benhAnform, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //UserWindow userform = new UserWindow();
            //LibMainClass.showWindow(userform, this, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MedicineWindow Mediform = new MedicineWindow();
            LibMainClass.LibMainClass.showWindow(Mediform, this, MDI.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PatienRegisterWindow patienform = new PatienRegisterWindow();
            LibMainClass    .LibMainClass.showWindow(patienform, this, MDI.ActiveForm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BioTestWinform bioform = new BioTestWinform();
            LibMainClass.LibMainClass.showWindow(bioform, this, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SymtomsWindow scr = new SymtomsWindow();
            LibMainClass.LibMainClass.showWindow(scr, this, MDI.ActiveForm);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UrineTestWinform sam = new UrineTestWinform();

            LibMainClass.LibMainClass.showWindow(sam, this, MDI.ActiveForm);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            BloodTestWinform blood = new BloodTestWinform();
            LibMainClass.LibMainClass.showWindow(blood, this, MDI.ActiveForm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DiseaseWindow des = new DiseaseWindow();
            LibMainClass.LibMainClass.showWindow(des, this, MDI.ActiveForm);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HealthCheckWindow screen = new HealthCheckWindow();
            LibMainClass.LibMainClass.showWindow(screen, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalysisScreen screen = new AnalysisScreen();
            LibMainClass.LibMainClass.showWindow(screen, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentWindow screen = new PaymentWindow();
            LibMainClass.LibMainClass.showWindow(screen, this, MDI.ActiveForm);
        }
    }
}
