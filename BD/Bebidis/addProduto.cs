using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bebidis
{
    public partial class addProduto : Form
    {
        public addProduto()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

     
        private void AddProduto_Load(object sender, EventArgs e)
        {

        }

        private void CodeBox_TextChanged(object sender, EventArgs e)
        {
            //TODO: tem de ir buscar o auto number 
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PriceBox_LostFocus(object sender, EventArgs e)
        {
            //this.Text = String.Format("€ {0:c}", this.Text);
            priceBox.Text = String.Format("€ {0:c0}", priceBox.Text);
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }




    }
}
