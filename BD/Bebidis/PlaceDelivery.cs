using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bebidis
{
    public partial class PlaceDelivery : Form
    {
        public PlaceDelivery()
        {
            InitializeComponent();
        }

        private void PlaceDelivery_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                // vendas nao encomendadas
                string queryString = "SELECT * FROM BW.viewVendasNaoEnc";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewSalesNotEnc.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewSalesNotEnc.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewSalesNotEnc.Columns[0].Width = 50;
                viewSalesNotEnc.Columns[1].Width = 80;
                viewSalesNotEnc.Columns[2].Width = 80;
                viewSalesNotEnc.Columns[3].Width = 80;
                viewSalesNotEnc.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewSalesNotEnc.Columns[5].Width = 80;
                viewSalesNotEnc.Columns[6].Width = 100;
                viewSalesNotEnc.Columns[7].Width = 80;
                cn.Close();


                // transportadores
                queryString = "SELECT Transportador, Nome FROM BW.viewTruckers";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewTruckers.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewTruckers.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewTruckers.Columns[0].Width = 100;
                viewTruckers.Columns[1].Width = 100;
                cn.Close();

                // camioes
                queryString = "SELECT Matrícula, Carga FROM BW.viewVehiclesPes";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewTrucks.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewTrucks.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewTrucks.Columns[0].Width = 100;
                viewTrucks.Columns[1].Width = 100;
                cn.Close();


            }
        }
    }
}
