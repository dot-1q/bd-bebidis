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
    public partial class InventoryProdutsMenu : Form
    {
        public InventoryProdutsMenu()
        {
            InitializeComponent();
        }

        private void insertProduct_Click(object sender, EventArgs e)
        {
            MenuProduto addMenu = new MenuProduto();
            addMenu.Show();

        }

        private void iventoryProdutsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InventoryProdutsMenu_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT * FROM BW.viewProdutos";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewProdutos.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewProdutos.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewProdutos.Columns[0].Width = 50;
                viewProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewProdutos.Columns[2].Width = 80;
                viewProdutos.Columns[3].Width = 80;
                viewProdutos.Columns[4].Width = 80;
            }
        }
    }
}
