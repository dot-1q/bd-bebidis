
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
            this.checkStock = new System.Windows.Forms.Button();
            this.checkPrice = new System.Windows.Forms.Button();
            this.checkPricesAndStock = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // setZone
            // 
            this.setZone.Location = new System.Drawing.Point(330, 12);
            this.setZone.Name = "setZone";
            this.setZone.Size = new System.Drawing.Size(100, 45);
            this.setZone.TabIndex = 14;
            this.setZone.Text = "Definir Zonas";
            this.setZone.UseVisualStyleBackColor = true;
            // 
            // makeSell
            // 
            this.makeSell.Location = new System.Drawing.Point(224, 12);
            this.makeSell.Name = "makeSell";
            this.makeSell.Size = new System.Drawing.Size(100, 45);
            this.makeSell.TabIndex = 13;
            this.makeSell.Text = "Venda";
            this.makeSell.UseVisualStyleBackColor = true;
            // 
            // checkStock
            // 
            this.checkStock.Location = new System.Drawing.Point(118, 12);
            this.checkStock.Name = "checkStock";
            this.checkStock.Size = new System.Drawing.Size(100, 45);
            this.checkStock.TabIndex = 12;
            this.checkStock.Text = "Stock";
            this.checkStock.UseVisualStyleBackColor = true;
            // 
            // checkPrice
            // 
            this.checkPrice.Location = new System.Drawing.Point(12, 12);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(100, 45);
            this.checkPrice.TabIndex = 11;
            this.checkPrice.Text = "Preçário";
            this.checkPrice.UseVisualStyleBackColor = true;
            this.checkPrice.Click += new System.EventHandler(this.checkPrice_Click);
            // 
            // checkPricesAndStock
            // 
            this.checkPricesAndStock.FormattingEnabled = true;
            this.checkPricesAndStock.ItemHeight = 15;
            this.checkPricesAndStock.Location = new System.Drawing.Point(12, 89);
            this.checkPricesAndStock.Name = "checkPricesAndStock";
            this.checkPricesAndStock.Size = new System.Drawing.Size(754, 349);
            this.checkPricesAndStock.TabIndex = 15;
            // 
            // SalesPersonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkPricesAndStock);
            this.Controls.Add(this.setZone);
            this.Controls.Add(this.makeSell);
            this.Controls.Add(this.checkStock);
            this.Controls.Add(this.checkPrice);
            this.Name = "SalesPersonMenu";
            this.Text = "Menu Promotor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setZone;
        private System.Windows.Forms.Button makeSell;
        private System.Windows.Forms.Button checkStock;
        private System.Windows.Forms.Button checkPrice;
        private System.Windows.Forms.ListBox checkPricesAndStock;
    }
}