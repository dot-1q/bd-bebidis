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

        private void update_gridview()
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

        private void InventoryProdutsMenu_Load(object sender, EventArgs e)
        {
            update_gridview(); 
        }

        private void viewProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (viewProdutos.SelectedRows.Count > 0)
            {

                string codigo = viewProdutos.SelectedRows[0].Cells[0].Value.ToString();
                string produto = viewProdutos.SelectedRows[0].Cells[1].Value.ToString();
                string preco = viewProdutos.SelectedRows[0].Cells[2].Value.ToString();
                string peso = viewProdutos.SelectedRows[0].Cells[3].Value.ToString();
                string quantidade = viewProdutos.SelectedRows[0].Cells[4].Value.ToString();

                codeBox.Text = codigo;
                nameBox.Text = produto;
                priceBox.Text = preco;
                pesoBox.Text = peso;
                quantBox.Text = quantidade;
            }
        }

        private void addUpdate_Click(object sender, EventArgs e)
        {

            string codigo = codeBox.Text;
            string produto = nameBox.Text;
            string preco = priceBox.Text;
            string peso = pesoBox.Text;
            string quantidade = quantBox.Text;

            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT Produto FROM BW.viewProdutos WHERE Código="+codigo;

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //significa o produto existe, logo é update
                        cn.Close();
                        queryString = "UPDATE BW.Produto SET preco = " + preco.Replace(',','.') + ", nome='" + produto + "', peso=" + peso.Replace(',', '.') + " WHERE codigo=" + codigo + ";";
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
                        queryString = "EXEC BW.p_insertAlterProduct @preco = " + preco.Replace(',', '.') + ", @nome='" + produto + "', @peso=" + peso.Replace(',', '.') + ", @quantidade=" + quantidade + ";";
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
            update_gridview();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (viewProdutos.SelectedRows.Count > 0)
            {

                string codigo = viewProdutos.SelectedRows[0].Cells[0].Value.ToString();
                using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
                {
                    string queryString = "DELETE FROM BW.Produto WHERE BW.Produto.codigo="+codigo+";";

                    using (var cmd = new SqlCommand(queryString, cn))
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            update_gridview();
        }
    }
}
