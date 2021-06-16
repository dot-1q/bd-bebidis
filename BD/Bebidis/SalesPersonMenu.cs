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
    public partial class SalesPersonMenu : Form
    {
        public SalesPersonMenu()
        {
            InitializeComponent();
        }

        private void checkPrice_Click(object sender, EventArgs e)
        {

        }

        private void SalesPersonMenu_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT Produto,Quantidade=0 FROM BW.viewProdutos";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        productQuantity.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        productQuantity.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                productQuantity.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                productQuantity.Columns[1].Width=80;
                cn.Close();


                queryString = "SELECT * FROM BW.viewProdutos";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewProducts.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewProducts.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewProducts.Columns[0].Width = 50;
                viewProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewProducts.Columns[2].Width = 80;
                viewProducts.Columns[3].Width = 80;
                viewProducts.Columns[4].Width = 100;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
