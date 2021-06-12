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
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void manageInventory_Click(object sender, EventArgs e)
        {
            InventoryProdutsMenu invProdMenu = new InventoryProdutsMenu();
            invProdMenu.Show();
        }

        private void setDelivery_Click(object sender, EventArgs e)
        {
            PlaceDelivery deliveryMenu = new PlaceDelivery();
            deliveryMenu.Show();
        }

        private void routesHistory_Click(object sender, EventArgs e)
        {

        }

        private void salesHistory_Click(object sender, EventArgs e)
        {
            Vehicles vehiclesMenu = new Vehicles();
            vehiclesMenu.Show();
        }

        private void setRoles_Click(object sender, EventArgs e)
        {
            Roles rolesMenu = new Roles();
            rolesMenu.Show();
        }

        private void manageVehicles_Click(object sender, EventArgs e)
        {
            Vehicles vehiclesMenu = new Vehicles();
            vehiclesMenu.Show();
        }
    }
}
