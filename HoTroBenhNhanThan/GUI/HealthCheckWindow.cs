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
    public partial class HealthCheckWindow : Sample01
    {
        public HealthCheckWindow()
        {
            InitializeComponent();
        }

        private void loadTodayPatient()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.loadList("[st_getTodayPatientApointment]", cb_selectPatient, "PatientApointment ID", "Patient", ht);
        }
        private void HealthCheckWindow_Load(object sender, EventArgs e)
        {
            loadTodayPatient();

        }

        public static int turnNo;
        public static string patentName;
        private void btnCall_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            ht.Add("@partID", Convert.ToInt64(cb_selectPatient.SelectedValue).ToString());
            turnNo = LibCRUD.getTurnNumber("st_getTurnNumberWRTpatientWRTToday", ht);

        }

        private void Dropdown(object sender, EventArgs e)
        {
            loadTodayPatient();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
