
namespace Bebidis
{
    partial class RoleMenu
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
            this.funcNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.funcName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.funcSal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.funcTel = new System.Windows.Forms.TextBox();
            this.updateRole = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.funcRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // funcNum
            // 
            this.funcNum.Location = new System.Drawing.Point(85, 10);
            this.funcNum.Name = "funcNum";
            this.funcNum.Size = new System.Drawing.Size(166, 23);
            this.funcNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome :";
            // 
            // funcName
            // 
            this.funcName.Location = new System.Drawing.Point(85, 39);
            this.funcName.Name = "funcName";
            this.funcName.Size = new System.Drawing.Size(166, 23);
            this.funcName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salário :";
            // 
            // funcSal
            // 
            this.funcSal.Location = new System.Drawing.Point(85, 97);
            this.funcSal.Name = "funcSal";
            this.funcSal.Size = new System.Drawing.Size(166, 23);
            this.funcSal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telemóvel :";
            // 
            // funcTel
            // 
            this.funcTel.Location = new System.Drawing.Point(85, 68);
            this.funcTel.Name = "funcTel";
            this.funcTel.Size = new System.Drawing.Size(166, 23);
            this.funcTel.TabIndex = 4;
            // 
            // updateRole
            // 
            this.updateRole.Location = new System.Drawing.Point(131, 155);
            this.updateRole.Name = "updateRole";
            this.updateRole.Size = new System.Drawing.Size(120, 63);
            this.updateRole.TabIndex = 8;
            this.updateRole.Text = "Adicionar / Atualizar Trabalhador";
            this.updateRole.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cargo :";
            // 
            // funcRole
            // 
            this.funcRole.Location = new System.Drawing.Point(85, 126);
            this.funcRole.Name = "funcRole";
            this.funcRole.Size = new System.Drawing.Size(166, 23);
            this.funcRole.TabIndex = 9;
            // 
            // RoleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 228);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.funcRole);
            this.Controls.Add(this.updateRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.funcSal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.funcTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.funcName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcNum);
            this.Name = "RoleMenu";
            this.Text = "RoleMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox funcNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox funcName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox funcSal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox funcTel;
        private System.Windows.Forms.Button updateRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox funcRole;
    }
}