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
            updateAllGrids();
            viewOperators.ClearSelection();
            viewTruckers.ClearSelection();
            viewPromotors.ClearSelection();
        }
        private void viewPromotors_SelectionChanged(object sender, EventArgs e)
        {
            viewOperators.ClearSelection();
            viewTruckers.ClearSelection();

            if(viewPromotors.SelectedRows.Count > 0)
            {
                funcNum.Text = viewPromotors.SelectedRows[0].Cells[0].Value.ToString();
                funcName.Text = viewPromotors.SelectedRows[0].Cells[1].Value.ToString();
                funcTel.Text = viewPromotors.SelectedRows[0].Cells[2].Value.ToString();
                DateTime date = (DateTime) viewPromotors.SelectedRows[0].Cells[3].Value;
                funcData.Text = date.ToString("yyyy-MM-dd");
                funcSal.Text = viewPromotors.SelectedRows[0].Cells[4].Value.ToString();

                using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
                {
                    // get role
                    string queryString = "SELECT role FROM BW.Login WHERE BW.Login.num_funcionario="+funcNum.Text+";";

                    using (var cmd = new SqlCommand(queryString, cn))
                    {
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string role = reader.GetString(0);
                            funcRole.Text = role;
                        }
                    }
                }
            }
        }

        private void viewOperators_SelectionChanged(object sender, EventArgs e)
        {
            viewPromotors.ClearSelection();
            viewTruckers.ClearSelection();

            if (viewOperators.SelectedRows.Count > 0)
            {
                funcNum.Text = viewOperators.SelectedRows[0].Cells[0].Value.ToString();
                funcName.Text = viewOperators.SelectedRows[0].Cells[1].Value.ToString();
                funcTel.Text = viewOperators.SelectedRows[0].Cells[2].Value.ToString();
                DateTime date = (DateTime)viewOperators.SelectedRows[0].Cells[3].Value;
                funcData.Text = date.ToString("yyyy-MM-dd");
                funcSal.Text = viewOperators.SelectedRows[0].Cells[4].Value.ToString();

                using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
                {
                    // get role
                    string queryString = "SELECT role FROM BW.Login WHERE BW.Login.num_funcionario=" + funcNum.Text + ";";

                    using (var cmd = new SqlCommand(queryString, cn))
                    {
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string role = reader.GetString(0);
                            funcRole.Text = role;
                        }
                    }
                }
            }
        }

        private void viewTruckers_SelectionChanged(object sender, EventArgs e)
        {
            viewPromotors.ClearSelection();
            viewOperators.ClearSelection();

            if (viewTruckers.SelectedRows.Count > 0)
            {
                funcNum.Text = viewTruckers.SelectedRows[0].Cells[0].Value.ToString();
                funcName.Text = viewTruckers.SelectedRows[0].Cells[1].Value.ToString();
                funcTel.Text = viewTruckers.SelectedRows[0].Cells[2].Value.ToString();
                DateTime date = (DateTime)viewTruckers.SelectedRows[0].Cells[3].Value;
                funcData.Text = date.ToString("yyyy-MM-dd");
                funcSal.Text = viewTruckers.SelectedRows[0].Cells[4].Value.ToString();

                using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
                {
                    // get role
                    string queryString = "SELECT role FROM BW.Login WHERE BW.Login.num_funcionario=" + funcNum.Text + ";";

                    using (var cmd = new SqlCommand(queryString, cn))
                    {
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string role = reader.GetString(0);
                            funcRole.Text = role;
                        }
                    }
                }
            }

        }

        private void updateAllGrids()
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

        private void AddAlterWorker_Click(object sender, EventArgs e)
        {
            string num_func = funcNum.Text;
            string funcionario = funcName.Text;
            string tel = funcTel.Text;
            string data = funcData.Text;
            string sal = funcSal.Text;
            string cargo = funcRole.Text;
            string zona = funcZona.Text;
            string responsvel = funcRes.Text;


            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT num_funcionario from BW.Funcionario WHERE n_telemovel=" + tel+";";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //significa o produto existe, logo é update
                        cn.Close();
                        queryString = "EXEC BW.p_updateFunc @num_func="+num_func+",@nome='"+funcionario+"',@n_telemovel="+tel+",@data='"+data+"',@sal="+sal+",@cargo='"+cargo+"',@zona='"+zona+"',@responsavel="+responsvel+"";
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
                        queryString = "EXEC BW.p_createFunc @nome='" + funcionario + "',@n_telemovel=" + tel + ",@data='" + data + "',@sal=" + sal + ",@cargo='" + cargo +"',@zona='" + zona + "',@responsavel=" + responsvel + "";
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

        private void fireWorker_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
               
                string queryString = "DELETE FROM BW.Funcionario WHERE BW.Funcionario.num_funcionario=" + funcNum.Text + ";";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                }
            }
            updateAllGrids();
        }
    }
}
