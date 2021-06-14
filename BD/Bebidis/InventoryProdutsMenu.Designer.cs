
namespace Bebidis
{
    partial class InventoryProdutsMenu
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
            this.updatePrice = new System.Windows.Forms.Button();
            this.insertProduct = new System.Windows.Forms.Button();
            this.updateName = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.viewProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // updatePrice
            // 
            this.updatePrice.Location = new System.Drawing.Point(542, 8);
            this.updatePrice.Name = "updatePrice";
            this.updatePrice.Size = new System.Drawing.Size(120, 45);
            this.updatePrice.TabIndex = 1;
            this.updatePrice.Text = "Atualizar Preço";
            this.updatePrice.UseVisualStyleBackColor = true;
            // 
            // insertProduct
            // 
            this.insertProduct.Location = new System.Drawing.Point(12, 8);
            this.insertProduct.Name = "insertProduct";
            this.insertProduct.Size = new System.Drawing.Size(120, 45);
            this.insertProduct.TabIndex = 2;
            this.insertProduct.Text = "Inserir Produto";
            this.insertProduct.UseVisualStyleBackColor = true;
            this.insertProduct.Click += new System.EventHandler(this.insertProduct_Click);
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(668, 8);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(120, 45);
            this.updateName.TabIndex = 3;
            this.updateName.Text = "Atualizar Nome";
            this.updateName.UseVisualStyleBackColor = true;
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(138, 8);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(120, 45);
            this.deleteProduct.TabIndex = 4;
            this.deleteProduct.Text = "Remover Produto";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // viewProdutos
            // 
            this.viewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProdutos.Location = new System.Drawing.Point(12, 71);
            this.viewProdutos.Name = "viewProdutos";
            this.viewProdutos.RowTemplate.Height = 25;
            this.viewProdutos.Size = new System.Drawing.Size(776, 367);
            this.viewProdutos.TabIndex = 5;
            // 
            // InventoryProdutsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewProdutos);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.insertProduct);
            this.Controls.Add(this.updatePrice);
            this.Name = "InventoryProdutsMenu";
            this.Text = "Produtos e Iventário";
            this.Load += new System.EventHandler(this.InventoryProdutsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button updatePrice;
        private System.Windows.Forms.Button insertProduct;
        private System.Windows.Forms.Button updateName;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.DataGridView viewProdutos;
    }
}