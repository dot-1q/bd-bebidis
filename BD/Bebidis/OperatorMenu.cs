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
        private string utilizador;
        public OperatorMenu(string utilizador)
        {
            InitializeComponent();
            this.utilizador = utilizador;
        }

        private void OperatorMenu_Load(object sender, EventArgs e)
        {
            updateDateGrid();
        }
        private void viewStock_SelectionChanged(object sender, EventArgs e)
        {
            if (viewStock.SelectedRows.Count > 0)
            {

                string codigo = viewStock.SelectedRows[0].Cells[0].Value.ToString();
                string quantidade = viewStock.SelectedRows[0].Cells[3].Value.ToString();

                productName.Text = codigo;
                quant.Value = Int32.Parse(quantidade);
            }
        }

        private void updateInventory_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string queryString = "EXEC BW.p_insertStock @codigo = "+productName.Text+", @quantidade ="+quant.Value.ToString()+" , @responsavel = "+utilizador+", @data = '"+date+"';";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            updateDateGrid();
        }

        private void updateDateGrid()
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

        private void OperatorMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.MainMenu.Show();
        }
    }
}
