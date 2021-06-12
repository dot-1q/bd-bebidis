using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            addProduto addMenu = new addProduto();
            addMenu.Show();

        }
    }
}
