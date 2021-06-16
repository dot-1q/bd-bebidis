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
        private string utilizador;
        public SalesPersonMenu(string utilizador)
        {
            InitializeComponent();
            this.utilizador = utilizador;
        }

        private void SalesPersonMenu_Load(object sender, EventArgs e)
        {
            updateAllGrids();
        }

        private void updateAllGrids()
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT Código as ID,Produto,Quantidade=0 FROM BW.viewProdutos";

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
                productQuantity.Columns[0].Width = 20;
                productQuantity.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                productQuantity.Columns[2].Width = 80;
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
                cn.Close();

                // view compradores
                queryString = "SELECT nome as Nome,localizacao as Localização,n_telefone as Telefone from BW.Comprador;";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        viewCompradores.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        viewCompradores.DataSource = dt;
                    }
                }
                // Hard coded width depending on the query
                viewCompradores.Columns[0].Width = 150;
                viewCompradores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                viewCompradores.Columns[2].Width = 80;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comprador = nameBox.Text;
            string telefone = telBox.Text;
            string local = localBox.Text;

            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "INSERT INTO BW.Comprador(n_telefone,nome,localizacao) VALUES ("+telefone+",'"+comprador+"','"+local+"');";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            updateAllGrids();
        }

        private void makeSell_Click(object sender, EventArgs e)
        {
            makeSellToBuyer();
            string id_venda = getVendaID();

            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString="";
                string quantity = "";
                string id = "";
                foreach (DataGridViewRow row in productQuantity.Rows)
                {
                    id = row.Cells[0].Value.ToString();
                    quantity = row.Cells[2].Value.ToString();
                    // foi adicionada quantidade
                    if (quantity != "0")
                    {
                        queryString = "EXEC BW.p_makeSellProd @venda="+id_venda+",@codigo="+id+",@quantidade="+quantity+";";
                        using (var cmd = new SqlCommand(queryString, cn))
                        {
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                    }
                }
                
            }
        }

        private void makeSellToBuyer()
        {
            string comprador = getBuyerNum();

            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string queryString = "EXEC BW.p_makeSellTo @data = '"+date+"', @feita_por = "+this.utilizador+", @num_comprador = "+comprador+";";

                using (var cmd = new SqlCommand(queryString, cn))
                {

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private string getBuyerNum()
        {
            string num_telefone = viewCompradores.SelectedRows[0].Cells[2].Value.ToString();
            string buyer_id="";
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string queryString = "SELECT num_comprador from BW.Comprador WHERE n_telefone="+num_telefone+";";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        buyer_id = reader[0].ToString();
                    }

                }
            }
            return buyer_id;
        }

        private string getVendaID()
        {
            string id_venda = "";
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string queryString = "SELECT TOP 1 numero from BW.Venda WHERE data_realizacao = '"+date+"' ORDER BY data_realizacao DESC, numero DESC";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id_venda = reader[0].ToString();
                    }

                }
            }
            return id_venda;
        }
    }
}
