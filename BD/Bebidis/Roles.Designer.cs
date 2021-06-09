
namespace Bebidis
{
    partial class Roles
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
            this.seeWorkers = new System.Windows.Forms.ListBox();
            this.insertWorker = new System.Windows.Forms.Button();
            this.updateRole = new System.Windows.Forms.Button();
            this.fireWorker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seeWorkers
            // 
            this.seeWorkers.FormattingEnabled = true;
            this.seeWorkers.ItemHeight = 15;
            this.seeWorkers.Location = new System.Drawing.Point(12, 81);
            this.seeWorkers.Name = "seeWorkers";
            this.seeWorkers.Size = new System.Drawing.Size(776, 364);
            this.seeWorkers.TabIndex = 0;
            // 
            // insertWorker
            // 
            this.insertWorker.Location = new System.Drawing.Point(12, 12);
            this.insertWorker.Name = "insertWorker";
            this.insertWorker.Size = new System.Drawing.Size(120, 45);
            this.insertWorker.TabIndex = 4;
            this.insertWorker.Text = "Adicionar Trabalhador";
            this.insertWorker.UseVisualStyleBackColor = true;
            // 
            // updateRole
            // 
            this.updateRole.Location = new System.Drawing.Point(138, 12);
            this.updateRole.Name = "updateRole";
            this.updateRole.Size = new System.Drawing.Size(120, 45);
            this.updateRole.TabIndex = 5;
            this.updateRole.Text = "Atualizar Cargo";
            this.updateRole.UseVisualStyleBackColor = true;
            // 
            // fireWorker
            // 
            this.fireWorker.Location = new System.Drawing.Point(668, 12);
            this.fireWorker.Name = "fireWorker";
            this.fireWorker.Size = new System.Drawing.Size(120, 45);
            this.fireWorker.TabIndex = 6;
            this.fireWorker.Text = "Despedir Trabalhador";
            this.fireWorker.UseVisualStyleBackColor = true;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fireWorker);
            this.Controls.Add(this.updateRole);
            this.Controls.Add(this.insertWorker);
            this.Controls.Add(this.seeWorkers);
            this.Name = "Roles";
            this.Text = "Roles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox seeWorkers;
        private System.Windows.Forms.Button insertWorker;
        private System.Windows.Forms.Button updateRole;
        private System.Windows.Forms.Button fireWorker;
    }
}