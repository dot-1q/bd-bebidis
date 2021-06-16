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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT role FROM BW.Login WHERE BW.Login.num_funcionario="+loginID.Text;

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string role = reader.GetString(0);
                        if (role == "gerente")
                        {
                            new ManagerMenu().Show();
                            this.Hide();
                        }
                        else if(role == "promotor")
                        {
                            new SalesPersonMenu(loginID.Text).Show();
                            this.Hide();
                        }
                        else if(role == "operador")
                        {
                            new OperatorMenu(loginID.Text).Show();
                            this.Hide();
                        }
                    }
                }

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
