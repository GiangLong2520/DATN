using HoTroBenhNhanThan.GUI.BaseScreen;
using System;
using System.Collections;
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
    public partial class BioTestWinform : Sample01
    {
        public BioTestWinform()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BioTestWinform_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.loadList("[st_getTodayPatient]", cb_selectPatient, "Patient ID", "Patient", ht);
        }

        public static int turnNo;
        public static string patientName;
        private void btnCall_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            ht.Add("@patID", Convert.ToInt64(cb_selectPatient.SelectedValue.ToString()));
            turnNo = LibCRUD.getTurnNumber("[st_getTurnNumberPatient]", ht);

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void cb_selectPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.loadList("[st_getTodayPatient]", cb_selectPatient, "Patient ID", "Patient", ht);


        }

        private void dropdown(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.loadList("[st_getTodayPatient]", cb_selectPatient, "Patient ID", "Patient", ht);
        }
    }
}
