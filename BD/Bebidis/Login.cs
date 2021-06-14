using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            new ManagerMenu().Show();
            this.Hide();
        }

        private void manager_Click(object sender, EventArgs e)
        {
            new ManagerMenu().Show();
            this.Hide();
        }

        private void promotor_Click(object sender, EventArgs e)
        {
            new SalesPersonMenu().Show();
            this.Hide();
        }

        private void operador_Click(object sender, EventArgs e)
        {
            new OperatorMenu().Show();
            this.Hide();
        }
    }
}
