using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void ManagerMenu_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DB.getDB().getConnectionString()))
            {
                string queryString = "SELECT * FROM BW.viewVendas";

                using (var cmd = new SqlCommand(queryString, cn))
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dataGridView1.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        MessageBox.Show(dt.ToString());
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
    }
}
