
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
            this.manageVehicles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewEncomendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.salesHistory.Location = new System.Drawing.Point(976, 87);
            this.salesHistory.Name = "salesHistory";
            this.salesHistory.Size = new System.Drawing.Size(145, 110);
            this.salesHistory.TabIndex = 4;
            this.salesHistory.Text = "Histórico de Vendas";
            this.salesHistory.UseVisualStyleBackColor = true;
            this.salesHistory.Click += new System.EventHandler(this.salesHistory_Click);
            // 
            // routesHistory
            // 
            this.routesHistory.Location = new System.Drawing.Point(976, 319);
            this.routesHistory.Name = "routesHistory";
            this.routesHistory.Size = new System.Drawing.Size(145, 110);
            this.routesHistory.TabIndex = 5;
            this.routesHistory.Text = "Histórico de Rotas";
            this.routesHistory.UseVisualStyleBackColor = true;
            this.routesHistory.Click += new System.EventHandler(this.routesHistory_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(945, 494);
            this.dataGridView1.TabIndex = 11;
            // 
            // viewEncomendas
            // 
            this.viewEncomendas.Location = new System.Drawing.Point(976, 203);
            this.viewEncomendas.Name = "viewEncomendas";
            this.viewEncomendas.Size = new System.Drawing.Size(145, 110);
            this.viewEncomendas.TabIndex = 12;
            this.viewEncomendas.Text = "Histórico de Encomendas";
            this.viewEncomendas.UseVisualStyleBackColor = true;
            this.viewEncomendas.Click += new System.EventHandler(this.viewEncomendas_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 593);
            this.Controls.Add(this.viewEncomendas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manageVehicles);
            this.Controls.Add(this.routesHistory);
            this.Controls.Add(this.salesHistory);
            this.Controls.Add(this.setRoles);
            this.Controls.Add(this.setDelivery);
            this.Controls.Add(this.manageInventoryAndProducts);
            this.Name = "ManagerMenu";
            this.Text = "Bebidis Warehouse Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerMenu_FormClosed);
            this.Load += new System.EventHandler(this.ManagerMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageInventoryAndProducts;
        private System.Windows.Forms.Button setDelivery;
        private System.Windows.Forms.Button setRoles;
        private System.Windows.Forms.Button salesHistory;
        private System.Windows.Forms.Button routesHistory;
        private System.Windows.Forms.Button manageVehicles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewEncomendas;
    }
}

