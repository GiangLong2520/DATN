using Microsoft.Reporting.WinForms;
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
            loadData.Items.Add(FeesGV);

            Hashtable ht = new Hashtable();
            ht.Add("@day", picker_DateTime.Value.Day);
            ht.Add("@month", picker_DateTime.Value.Month);
            ht.Add("@year", picker_DateTime.Value.Year);
            ht.Add("@status", 1);
            LibCRUD.LibCRUD.loadData("st_GetPatientAppointmentRegConsulted", dataGridView1, loadData, ht);

            dataGridView1.Columns["DiscountGV"].DataPropertyName = Convert.ToString(0);
            dataGridView1.Columns["TotalGV"].DataPropertyName = dataGridView1.Columns["FeesGV"].DataPropertyName;
        }
        private void PaymentWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }
        int rowSelect = -1;

        string name, age, guard, Doctor,status,phone,Fees;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                rowSelect = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                name = row.Cells["patientGV"].Value.ToString();
                age = row.Cells["ageGV"].Value.ToString();
                guard = row.Cells["GuardGV"].Value.ToString();
                Doctor  = row.Cells["doctorGV"].Value.ToString();
                phone = row.Cells["phoneGV"].Value.ToString();
                Fees = row.Cells["FeesGV"].Value.ToString();



                DataTable dataTable = new DataTable();
                // Thêm cột "Name" kiểu string vào DataTable
                dataTable.Columns.Add("Name", typeof(string));
                // Thêm cột "Age" kiểu string vào DataTable
                dataTable.Columns.Add("Age", typeof(string));
                // Thêm cột "Guardian" kiểu string vào DataTable
                dataTable.Columns.Add("Guardian", typeof(string));
                // Thêm cột "Doctor" kiểu string vào DataTable
                dataTable.Columns.Add("Doctor", typeof(string));
                // Thêm cột "Phone" kiểu string vào DataTable
                dataTable.Columns.Add("Phone", typeof(string));
                // Thêm cột "Fees" kiểu string vào DataTable
                dataTable.Columns.Add("Fees", typeof(string));

                // Thêm dòng dữ liệu với Name, Age và các trường còn lại
                DataRow newRow = dataTable.NewRow();
                newRow["Name"] = name;
                newRow["Age"] = age;
                newRow["Guardian"] = guard;
                newRow["Doctor"] = Doctor;
                newRow["Phone"] = phone;
                newRow["Fees"] = Fees;

                // Thêm dòng vào DataTable
                dataTable.Rows.Add(newRow);



                ReportDataSource s = new ReportDataSource("DataSet1", dataTable);
                reportViewer1.LocalReport.DataSources.Add(s);


                dataGridView1.Hide();
                reportViewer1.Show();
                reportViewer1.Enabled = true;

                reportViewer1.LocalReport.ReportPath = "C:\\Users\\longd\\source\\repos\\HoTroBenhNhanThan\\HoTroBenhNhanThan\\Report1.rdlc";
                reportViewer1.RefreshReport();
            }
        }
    }
}
