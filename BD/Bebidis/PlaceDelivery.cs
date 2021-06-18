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
        public Boolean firstTime;
        public PlaceDelivery()
        {
            InitializeComponent();
        }

        private void PlaceDelivery_Load(object sender, EventArgs e)
        {
            updateAllGrids();
            this.firstTime = true;

        }
        
        private void updateAllGrids()
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

        private void viewSalesNotEnc_SelectionChanged(object sender, EventArgs e)
        {
            if (viewSalesNotEnc.SelectedRows.Count > 0)
            {
                string venda = viewSalesNotEnc.SelectedRows[0].Cells[0].Value.ToString();
                salesNum.Text = venda;
            }
        }

        private void viewTrucks_SelectionChanged(object sender, EventArgs e)
        {
            if (viewTrucks.SelectedRows.Count > 0)
            {
                string truck = viewTrucks.SelectedRows[0].Cells[0].Value.ToString();
                truckNum.Text = truck;
            }
        }

        private void viewTruckers_SelectionChanged(object sender, EventArgs e)
        {
            if (viewTruckers.SelectedRows.Count > 0)
            {
                string trucker = viewTruckers.SelectedRows[0].Cells[0].Value.ToString();
                truckerNum.Text = trucker;
            }
        }

        private void confirmDeliveries_Click(object sender, EventArgs e)
        {
            string matricula = truckNum.Text;
            string transportador = truckerNum.Text;
            string local = viewSalesNotEnc.SelectedRows[0].Cells[7].Value.ToString();
            string venda = salesNum.Text;

            if (firstTime)
            {
                createRoute(matricula);
                createEncomenda(matricula, transportador);
                firstTime = !firstTime;
            }

            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "EXEC BW.p_insertVendas @venda="+venda+",@zona='"+local+"'";

                using (var cmd = new SqlCommand(queryString, cn))
                {

                    cn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex)
                    {
                        if (ex.Errors[0].Class == 17)
                        {
                            MessageBox.Show("Peso Máximo excedido", "Erro de Carga",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Console.WriteLine("Zona já se encontra na rota");
                    }
                }


            }
            updateAllGrids();
        }

        private void createRoute(string matricula)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string queryString = "EXEC BW.p_createRoute @tipo='distribuição',@carro_usado='"+matricula+"',@data='"+date+"'";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void createEncomenda(string matricula,string transportador)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string queryString = "EXEC  BW.p_createEncomenda @data='"+date+"',@transportador="+transportador+",@pesado='"+matricula+"'";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
