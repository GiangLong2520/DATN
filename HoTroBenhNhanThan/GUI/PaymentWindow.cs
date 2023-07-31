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
    public partial class PaymentWindow : Sample2
    {
        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            ListBox loadData = new ListBox();
            loadData.Items.Add(TurnGV);
            loadData.Items.Add(patientIDGV);
            loadData.Items.Add(patientGV);
            loadData.Items.Add(GuardGV);
            loadData.Items.Add(apointDateGV);
            loadData.Items.Add(ageGV);
            loadData.Items.Add(doctorGV);
            loadData.Items.Add(DoctorIDGV);
            loadData.Items.Add(statusGV);
            loadData.Items.Add(appIDGV);
            loadData.Items.Add(phoneGV);

            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            ht.Add("@status", 1);
            LibCRUD.loadData("st_GetPatientAppointmentRegConsulted", dataGridView1, loadData, ht);
        }

        private void PaymentWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
