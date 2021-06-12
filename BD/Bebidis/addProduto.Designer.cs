namespace Bebidis
{
    partial class addProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(137, 66);
            this.codeBox.Name = "codeBox";
            this.codeBox.ReadOnly = true;
            this.codeBox.Size = new System.Drawing.Size(116, 20);
            this.codeBox.TabIndex = 5;
            this.codeBox.TextChanged += new System.EventHandler(this.CodeBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(15, 23);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(238, 20);
            this.nameBox.TabIndex = 6;
            this.nameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(15, 66);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(116, 20);
            this.priceBox.TabIndex = 7;
            this.priceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            this.priceBox.LostFocus += new System.EventHandler(this.PriceBox_LostFocus);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 118);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(137, 118);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 159);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addProduto";
            this.Text = "Adicionar Produto";
            this.Load += new System.EventHandler(this.AddProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

