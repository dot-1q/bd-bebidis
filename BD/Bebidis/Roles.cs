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
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                // DAtagrid PRomotores
                string queryString = "SELECT * FROM BW.viewPromotors";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewPromotors.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewPromotors.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewPromotors.Columns[0].Width = 100;
                viewPromotors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewPromotors.Columns[2].Width = 120;
                viewPromotors.Columns[3].Width = 100;
                viewPromotors.Columns[4].Width = 80;
                viewPromotors.Columns[5].Width = 100;
                cn.Close();

                // Data grid Operadores
                queryString = "SELECT * FROM BW.viewOperators";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewOperators.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewOperators.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewOperators.Columns[0].Width = 100;
                viewOperators.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewOperators.Columns[2].Width = 120;
                viewOperators.Columns[3].Width = 100;
                viewOperators.Columns[4].Width = 80;
                viewOperators.Columns[5].Width = 150;
                cn.Close();

                //data grid Transportadores
                // Data grid Operadores
                queryString = "SELECT * FROM BW.viewTruckers";

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
                viewTruckers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewTruckers.Columns[2].Width = 120;
                viewTruckers.Columns[3].Width = 100;
                viewTruckers.Columns[4].Width = 80;
            }
        }

        private void insertWorker_Click(object sender, EventArgs e)
        {
            //insert funcionario
            new RoleMenu().Show();
        }

        private void updateRole_Click(object sender, EventArgs e)
        {
            //update funcionario
            new RoleMenu().Show();
        }
    }
}
