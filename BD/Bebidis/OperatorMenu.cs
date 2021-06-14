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
    public partial class OperatorMenu : Form
    {
        public OperatorMenu()
        {
            InitializeComponent();
        }

        private void OperatorMenu_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT * FROM BW.viewStock";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewStock.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewStock.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewStock.Columns[0].Width = 80;
                viewStock.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewStock.Columns[2].Width = 80;
                viewStock.Columns[3].Width = 80;
                viewStock.Columns[4].Width = 80;
                viewStock.Columns[5].Width = 100;
                viewStock.Columns[6].Width = 180;
            }
        }
    }
}
