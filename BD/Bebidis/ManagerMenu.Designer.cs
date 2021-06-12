
namespace Bebidis
{
    partial class ManagerMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manageInventoryAndProducts = new System.Windows.Forms.Button();
            this.setDelivery = new System.Windows.Forms.Button();
            this.setRoles = new System.Windows.Forms.Button();
            this.salesHistory = new System.Windows.Forms.Button();
            this.routesHistory = new System.Windows.Forms.Button();
            this.visualizeHistoryQuery = new System.Windows.Forms.ListBox();
            this.salesSelection = new System.Windows.Forms.CheckedListBox();
            this.routesSelection = new System.Windows.Forms.CheckedListBox();
            this.manageVehicles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageInventoryAndProducts
            // 
            this.manageInventoryAndProducts.Location = new System.Drawing.Point(12, 12);
            this.manageInventoryAndProducts.Name = "manageInventoryAndProducts";
            this.manageInventoryAndProducts.Size = new System.Drawing.Size(120, 45);
            this.manageInventoryAndProducts.TabIndex = 0;
            this.manageInventoryAndProducts.Text = "Gerir Inventário / Produtos";
            this.manageInventoryAndProducts.UseVisualStyleBackColor = true;
            this.manageInventoryAndProducts.Click += new System.EventHandler(this.manageInventory_Click);
            // 
            // setDelivery
            // 
            this.setDelivery.Location = new System.Drawing.Point(169, 12);
            this.setDelivery.Name = "setDelivery";
            this.setDelivery.Size = new System.Drawing.Size(120, 45);
            this.setDelivery.TabIndex = 1;
            this.setDelivery.Text = "Preparar Encomenda";
            this.setDelivery.UseVisualStyleBackColor = true;
            this.setDelivery.Click += new System.EventHandler(this.setDelivery_Click);
            // 
            // setRoles
            // 
            this.setRoles.Location = new System.Drawing.Point(324, 12);
            this.setRoles.Name = "setRoles";
            this.setRoles.Size = new System.Drawing.Size(120, 45);
            this.setRoles.TabIndex = 2;
            this.setRoles.Text = "Cargos";
            this.setRoles.UseVisualStyleBackColor = true;
            this.setRoles.Click += new System.EventHandler(this.setRoles_Click);
            // 
            // salesHistory
            // 
            this.salesHistory.Location = new System.Drawing.Point(749, 142);
            this.salesHistory.Name = "salesHistory";
            this.salesHistory.Size = new System.Drawing.Size(145, 45);
            this.salesHistory.TabIndex = 4;
            this.salesHistory.Text = "Histórico de Vendas";
            this.salesHistory.UseVisualStyleBackColor = true;
            this.salesHistory.Click += new System.EventHandler(this.salesHistory_Click);
            // 
            // routesHistory
            // 
            this.routesHistory.Location = new System.Drawing.Point(749, 418);
            this.routesHistory.Name = "routesHistory";
            this.routesHistory.Size = new System.Drawing.Size(145, 45);
            this.routesHistory.TabIndex = 5;
            this.routesHistory.Text = "Histórico de Rotas";
            this.routesHistory.UseVisualStyleBackColor = true;
            this.routesHistory.Click += new System.EventHandler(this.routesHistory_Click);
            // 
            // visualizeHistoryQuery
            // 
            this.visualizeHistoryQuery.FormattingEnabled = true;
            this.visualizeHistoryQuery.ItemHeight = 15;
            this.visualizeHistoryQuery.Location = new System.Drawing.Point(12, 142);
            this.visualizeHistoryQuery.Name = "visualizeHistoryQuery";
            this.visualizeHistoryQuery.Size = new System.Drawing.Size(731, 439);
            this.visualizeHistoryQuery.TabIndex = 7;
            // 
            // salesSelection
            // 
            this.salesSelection.FormattingEnabled = true;
            this.salesSelection.Items.AddRange(new object[] {
            "Mais Antigas",
            "Mais Recentes",
            "Preço Ascendente",
            "Preço Descendente",
            "Por Vendedor",
            "Por Produto"});
            this.salesSelection.Location = new System.Drawing.Point(749, 193);
            this.salesSelection.Name = "salesSelection";
            this.salesSelection.Size = new System.Drawing.Size(145, 112);
            this.salesSelection.TabIndex = 8;
            // 
            // routesSelection
            // 
            this.routesSelection.FormattingEnabled = true;
            this.routesSelection.Items.AddRange(new object[] {
            "Mais Antigas",
            "Mais Recentes",
            "Ligeiros",
            "Pesados",
            "Por Vendedor",
            "Por Transportador"});
            this.routesSelection.Location = new System.Drawing.Point(749, 469);
            this.routesSelection.Name = "routesSelection";
            this.routesSelection.Size = new System.Drawing.Size(145, 112);
            this.routesSelection.TabIndex = 9;
            // 
            // manageVehicles
            // 
            this.manageVehicles.Location = new System.Drawing.Point(480, 12);
            this.manageVehicles.Name = "manageVehicles";
            this.manageVehicles.Size = new System.Drawing.Size(145, 45);
            this.manageVehicles.TabIndex = 10;
            this.manageVehicles.Text = "Gerir Veículos";
            this.manageVehicles.UseVisualStyleBackColor = true;
            this.manageVehicles.Click += new System.EventHandler(this.manageVehicles_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 593);
            this.Controls.Add(this.manageVehicles);
            this.Controls.Add(this.routesSelection);
            this.Controls.Add(this.salesSelection);
            this.Controls.Add(this.visualizeHistoryQuery);
            this.Controls.Add(this.routesHistory);
            this.Controls.Add(this.salesHistory);
            this.Controls.Add(this.setRoles);
            this.Controls.Add(this.setDelivery);
            this.Controls.Add(this.manageInventoryAndProducts);
            this.Name = "ManagerMenu";
            this.Text = "Bebidis Warehouse Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageInventoryAndProducts;
        private System.Windows.Forms.Button setDelivery;
        private System.Windows.Forms.Button setRoles;
        private System.Windows.Forms.Button salesHistory;
        private System.Windows.Forms.Button routesHistory;
        private System.Windows.Forms.ListBox visualizeHistoryQuery;
        private System.Windows.Forms.CheckedListBox salesSelection;
        private System.Windows.Forms.CheckedListBox routesSelection;
        private System.Windows.Forms.Button manageVehicles;
    }
}

