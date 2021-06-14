
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
            this.productName = new System.Windows.Forms.TextBox();
            this.viewStock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.viewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateInventory
            // 
            this.updateInventory.Location = new System.Drawing.Point(12, 9);
            this.updateInventory.Name = "updateInventory";
            this.updateInventory.Size = new System.Drawing.Size(100, 45);
            this.updateInventory.TabIndex = 13;
            this.updateInventory.Text = "Atualizar Inventário";
            this.updateInventory.UseVisualStyleBackColor = true;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(258, 9);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(120, 23);
            this.productName.TabIndex = 15;
            // 
            // viewStock
            // 
            this.viewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStock.Location = new System.Drawing.Point(12, 77);
            this.viewStock.Name = "viewStock";
            this.viewStock.RowTemplate.Height = 25;
            this.viewStock.Size = new System.Drawing.Size(776, 361);
            this.viewStock.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quantidade:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(258, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 20;
            // 
            // OperatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewStock);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.updateInventory);
            this.Name = "OperatorMenu";
            this.Text = "Menu Operador";
            this.Load += new System.EventHandler(this.OperatorMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateInventory;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.DataGridView viewStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}