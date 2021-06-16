
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
            this.deleteProduct = new System.Windows.Forms.Button();
            this.viewProdutos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.quantBox = new System.Windows.Forms.TextBox();
            this.pesoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addUpdate = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(798, 334);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(120, 45);
            this.deleteProduct.TabIndex = 4;
            this.deleteProduct.Text = "Remover Produto";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // viewProdutos
            // 
            this.viewProdutos.AllowUserToAddRows = false;
            this.viewProdutos.AllowUserToDeleteRows = false;
            this.viewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProdutos.Location = new System.Drawing.Point(12, 12);
            this.viewProdutos.MultiSelect = false;
            this.viewProdutos.Name = "viewProdutos";
            this.viewProdutos.ReadOnly = true;
            this.viewProdutos.RowTemplate.Height = 25;
            this.viewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewProdutos.Size = new System.Drawing.Size(776, 367);
            this.viewProdutos.TabIndex = 5;
            this.viewProdutos.SelectionChanged += new System.EventHandler(this.viewProdutos_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(917, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Quantidade";
            // 
            // quantBox
            // 
            this.quantBox.Location = new System.Drawing.Point(917, 75);
            this.quantBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.quantBox.Name = "quantBox";
            this.quantBox.Size = new System.Drawing.Size(82, 23);
            this.quantBox.TabIndex = 24;
            // 
            // pesoBox
            // 
            this.pesoBox.Location = new System.Drawing.Point(917, 30);
            this.pesoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pesoBox.Name = "pesoBox";
            this.pesoBox.Size = new System.Drawing.Size(82, 23);
            this.pesoBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(917, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Peso";
            // 
            // addUpdate
            // 
            this.addUpdate.Location = new System.Drawing.Point(819, 159);
            this.addUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addUpdate.Name = "addUpdate";
            this.addUpdate.Size = new System.Drawing.Size(154, 28);
            this.addUpdate.TabIndex = 20;
            this.addUpdate.Text = "Adicionar / Alterar";
            this.addUpdate.UseVisualStyleBackColor = true;
            this.addUpdate.Click += new System.EventHandler(this.addUpdate_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(795, 75);
            this.priceBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(97, 23);
            this.priceBox.TabIndex = 19;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(795, 130);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(204, 23);
            this.nameBox.TabIndex = 18;
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(795, 30);
            this.codeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(97, 23);
            this.codeBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Código";
            // 
            // InventoryProdutsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantBox);
            this.Controls.Add(this.pesoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addUpdate);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.viewProdutos);
            this.Controls.Add(this.deleteProduct);
            this.Name = "InventoryProdutsMenu";
            this.Text = "Produtos e Iventário";
            this.Load += new System.EventHandler(this.InventoryProdutsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.DataGridView viewProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantBox;
        private System.Windows.Forms.TextBox pesoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addUpdate;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}