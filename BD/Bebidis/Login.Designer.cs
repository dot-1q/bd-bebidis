
namespace Bebidis
{
    partial class Login
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
            this.productName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.manager = new System.Windows.Forms.Button();
            this.promotor = new System.Windows.Forms.Button();
            this.operador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(320, 103);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(152, 23);
            this.productName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nº Funcionário";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(320, 144);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(152, 71);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // manager
            // 
            this.manager.Location = new System.Drawing.Point(91, 268);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(152, 71);
            this.manager.TabIndex = 20;
            this.manager.Text = "Manager";
            this.manager.UseVisualStyleBackColor = true;
            this.manager.Click += new System.EventHandler(this.manager_Click);
            // 
            // promotor
            // 
            this.promotor.Location = new System.Drawing.Point(303, 268);
            this.promotor.Name = "promotor";
            this.promotor.Size = new System.Drawing.Size(152, 71);
            this.promotor.TabIndex = 21;
            this.promotor.Text = "Promotor";
            this.promotor.UseVisualStyleBackColor = true;
            this.promotor.Click += new System.EventHandler(this.promotor_Click);
            // 
            // operador
            // 
            this.operador.Location = new System.Drawing.Point(519, 268);
            this.operador.Name = "operador";
            this.operador.Size = new System.Drawing.Size(152, 71);
            this.operador.TabIndex = 22;
            this.operador.Text = "Operador";
            this.operador.UseVisualStyleBackColor = true;
            this.operador.Click += new System.EventHandler(this.operador_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.operador);
            this.Controls.Add(this.promotor);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button manager;
        private System.Windows.Forms.Button promotor;
        private System.Windows.Forms.Button operador;
    }
}