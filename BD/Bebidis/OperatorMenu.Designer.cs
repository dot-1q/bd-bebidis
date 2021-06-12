
namespace Bebidis
{
    partial class OperatorMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.updateInventory = new System.Windows.Forms.Button();
            this.seeStock = new System.Windows.Forms.ListBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateInventory
            // 
            this.updateInventory.Location = new System.Drawing.Point(12, 12);
            this.updateInventory.Name = "updateInventory";
            this.updateInventory.Size = new System.Drawing.Size(100, 45);
            this.updateInventory.TabIndex = 13;
            this.updateInventory.Text = "Atualizar Inventário";
            this.updateInventory.UseVisualStyleBackColor = true;
            // 
            // seeStock
            // 
            this.seeStock.FormattingEnabled = true;
            this.seeStock.ItemHeight = 15;
            this.seeStock.Location = new System.Drawing.Point(12, 82);
            this.seeStock.Name = "seeStock";
            this.seeStock.Size = new System.Drawing.Size(754, 349);
            this.seeStock.TabIndex = 14;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(135, 24);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(120, 23);
            this.productName.TabIndex = 15;
            this.productName.Text = "Produto:";
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(271, 24);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(120, 23);
            this.productQuantity.TabIndex = 16;
            this.productQuantity.Text = "Quantity:";
            // 
            // OperatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.seeStock);
            this.Controls.Add(this.updateInventory);
            this.Name = "OperatorMenu";
            this.Text = "Menu Operador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateInventory;
        private System.Windows.Forms.ListBox seeStock;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productQuantity;
    }
}