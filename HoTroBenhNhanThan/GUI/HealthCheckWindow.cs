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
    public partial class HealthCheckWindow : Sample2
    {
        public HealthCheckWindow()
        {
            InitializeComponent();
        }

        private void loadTodayPatient()
        {
            cb_selectPatient.DataSource = null;
            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            LibCRUD.loadList("st_getTodayPatients", cb_selectPatient, "Patient ID", "Patient", ht);
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
    }
}
