namespace Bebidis
{
    partial class MenuProduto
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
            this.addUpdate = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(160, 76);
            this.codeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(135, 23);
            this.codeBox.TabIndex = 5;
            this.codeBox.TextChanged += new System.EventHandler(this.CodeBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(18, 27);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(277, 23);
            this.nameBox.TabIndex = 6;
            this.nameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(18, 76);
            this.priceBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(135, 23);
            this.priceBox.TabIndex = 7;
            this.priceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            this.priceBox.LostFocus += new System.EventHandler(this.PriceBox_LostFocus);
            // 
            // addUpdate
            // 
            this.addUpdate.Location = new System.Drawing.Point(18, 136);
            this.addUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addUpdate.Name = "addUpdate";
            this.addUpdate.Size = new System.Drawing.Size(135, 27);
            this.addUpdate.TabIndex = 8;
            this.addUpdate.Text = "Adicionar / Alterar";
            this.addUpdate.UseVisualStyleBackColor = true;
            this.addUpdate.Click += new System.EventHandler(this.addUpdate_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(160, 136);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 27);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // MenuProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 183);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addUpdate);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MenuProduto";
            this.Text = "Menu Produto";
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
        private System.Windows.Forms.Button addUpdate;
        private System.Windows.Forms.Button cancelButton;
    }
}

