
namespace Bebidis
{
    partial class SalesPersonMenu
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
            this.setZone = new System.Windows.Forms.Button();
            this.makeSell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // setZone
            // 
            this.setZone.Location = new System.Drawing.Point(12, 12);
            this.setZone.Name = "setZone";
            this.setZone.Size = new System.Drawing.Size(100, 45);
            this.setZone.TabIndex = 14;
            this.setZone.Text = "Definir Zonas";
            this.setZone.UseVisualStyleBackColor = true;
            // 
            // makeSell
            // 
            this.makeSell.Location = new System.Drawing.Point(744, 395);
            this.makeSell.Name = "makeSell";
            this.makeSell.Size = new System.Drawing.Size(100, 45);
            this.makeSell.TabIndex = 13;
            this.makeSell.Text = "Confirmar Venda";
            this.makeSell.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Produtos: ";
            // 
            // viewProducts
            // 
            this.viewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProducts.Location = new System.Drawing.Point(13, 74);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.RowTemplate.Height = 25;
            this.viewProducts.Size = new System.Drawing.Size(494, 366);
            this.viewProducts.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Comprador: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(656, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 23);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // productQuantity
            // 
            this.productQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productQuantity.Location = new System.Drawing.Point(542, 137);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.RowTemplate.Height = 25;
            this.productQuantity.Size = new System.Drawing.Size(302, 252);
            this.productQuantity.TabIndex = 20;
            // 
            // SalesPersonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 452);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setZone);
            this.Controls.Add(this.makeSell);
            this.Name = "SalesPersonMenu";
            this.Text = "Menu Promotor";
            this.Load += new System.EventHandler(this.SalesPersonMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setZone;
        private System.Windows.Forms.Button makeSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.DataGridView productQuantity;
    }
}