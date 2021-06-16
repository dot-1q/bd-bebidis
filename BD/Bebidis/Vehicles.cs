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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void insertVehicle_Click(object sender, EventArgs e)
        {
            new VehicleMenu().Show();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT * FROM BW.viewVehiclesLig";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewVehiclesLig.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewVehiclesLig.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewVehiclesLig.Columns[0].Width = 100;
                viewVehiclesLig.Columns[1].Width = 100;
                viewVehiclesLig.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewVehiclesLig.Columns[3].Width = 100;
                cn.Close();

                //pesados
                queryString = "SELECT * FROM BW.viewVehiclesPes";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewVehiclesPes.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewVehiclesPes.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewVehiclesPes.Columns[0].Width = 100;
                viewVehiclesPes.Columns[1].Width = 50;
                viewVehiclesPes.Columns[2].Width = 100;
                viewVehiclesPes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cn.Close();
            }
        }
    }
}
