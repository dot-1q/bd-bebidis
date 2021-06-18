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

        private void Vehicles_Load(object sender, EventArgs e)
        {
            updateAllGrids();
        }

        private void viewVehiclesLig_SelectionChanged(object sender, EventArgs e)
        {
            viewVehiclesPes.ClearSelection();

            if (viewVehiclesLig.SelectedRows.Count > 0)
            {
                matricula.Text = viewVehiclesLig.SelectedRows[0].Cells[0].Value.ToString();
                matriculaRemove.Text = viewVehiclesLig.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void viewVehiclesPes_SelectionChanged(object sender, EventArgs e)
        {
            viewVehiclesLig.ClearSelection();

            if (viewVehiclesPes.SelectedRows.Count > 0)
            {
                matricula.Text = viewVehiclesPes.SelectedRows[0].Cells[0].Value.ToString();
                matriculaRemove.Text = viewVehiclesPes.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void updateAllGrids()
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

        private void insertAlterVehicle_Click(object sender, EventArgs e)
        {
            string mat = matricula.Text;
            string carga = cargaBox.Text;
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT * FROM BW.Automoveis WHERE matricula='" + mat+"';";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //significa o automovel existe, logo é update
                        cn.Close();
                        queryString = "UPDATE BW.Pesado SET carga = " + carga + " WHERE matricula='" + mat + "';";
                        using (SqlConnection cn2 = new SqlConnection(DB.getDB().getConnectionString()))
                        {
                            using (var cmd2 = new SqlCommand(queryString, cn2))
                            {
                                cn2.Open();
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        //signiffica que não existe, logo é insert
                        cn.Close();
                        queryString = "EXEC BW.p_createVehicle @matricula='" + mat + "', @carga=" + carga + "";
                        using (SqlConnection cn2 = new SqlConnection(DB.getDB().getConnectionString()))
                        {
                            using (var cmd2 = new SqlCommand(queryString, cn2))
                            {
                                cn2.Open();
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            updateAllGrids();
        }

        private void deleteVehicle_Click(object sender, EventArgs e)
        {
            string mat = matricula.Text;
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "DELETE FROM BW.Automoveis WHERE matricula='" + mat+"';";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            updateAllGrids();
        }
    }
}
