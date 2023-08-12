using HoTroBenhNhanThan.API;
using Microsoft.Data.SqlClient;
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
    public partial class BenhAnWindow : Sample2
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable   = new DataTable();
        public BenhAnWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadBenhAn()
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"select * from BenhAn ";
            sqlDataAdapter.SelectCommand= sqlCommand;
            dataTable.Clear();
            sqlDataAdapter.Fill(dataTable);
            dgv_BenhAn.DataSource = dataTable;
        }
        private void LoadData()
        {
            sqlConnection = new SqlConnection(LibMainClass.LibMainClass.connectionString());
            sqlConnection.Open();
            LoadBenhAn();
        }
    }
}
