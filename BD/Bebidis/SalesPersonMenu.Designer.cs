
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
            this.makeSell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.telBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.localBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.viewCompradores = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCompradores)).BeginInit();
            this.SuspendLayout();
            // 
            // makeSell
            // 
            this.makeSell.Location = new System.Drawing.Point(512, 462);
            this.makeSell.Name = "makeSell";
            this.makeSell.Size = new System.Drawing.Size(330, 45);
            this.makeSell.TabIndex = 13;
            this.makeSell.Text = "Confirmar Venda";
            this.makeSell.UseVisualStyleBackColor = true;
            this.makeSell.Click += new System.EventHandler(this.makeSell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Produtos: ";
            // 
            // viewProducts
            // 
            this.viewProducts.AllowUserToAddRows = false;
            this.viewProducts.AllowUserToDeleteRows = false;
            this.viewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProducts.Location = new System.Drawing.Point(12, 12);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.RowTemplate.Height = 25;
            this.viewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewProducts.Size = new System.Drawing.Size(494, 495);
            this.viewProducts.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Comprador: ";
            // 
            // productQuantity
            // 
            this.productQuantity.AllowUserToAddRows = false;
            this.productQuantity.AllowUserToDeleteRows = false;
            this.productQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productQuantity.Location = new System.Drawing.Point(512, 235);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.RowTemplate.Height = 25;
            this.productQuantity.Size = new System.Drawing.Size(330, 221);
            this.productQuantity.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nome :";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(925, 236);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 22;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(925, 276);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(100, 23);
            this.telBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(870, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefone :";
            // 
            // localBox
            // 
            this.localBox.Location = new System.Drawing.Point(925, 315);
            this.localBox.Name = "localBox";
            this.localBox.Size = new System.Drawing.Size(100, 23);
            this.localBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Localização :";
            // 
            // viewCompradores
            // 
            this.viewCompradores.AllowUserToAddRows = false;
            this.viewCompradores.AllowUserToDeleteRows = false;
            this.viewCompradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCompradores.Location = new System.Drawing.Point(512, 29);
            this.viewCompradores.Name = "viewCompradores";
            this.viewCompradores.RowTemplate.Height = 25;
            this.viewCompradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewCompradores.Size = new System.Drawing.Size(513, 175);
            this.viewCompradores.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(925, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 28;
            this.button1.Text = "Novo Vendedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalesPersonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewCompradores);
            this.Controls.Add(this.localBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeSell);
            this.Name = "SalesPersonMenu";
            this.Text = "Menu Promotor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesPersonMenu_FormClosed);
            this.Load += new System.EventHandler(this.SalesPersonMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCompradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button makeSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView productQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox localBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView viewCompradores;
        private System.Windows.Forms.Button button1;
    }
}