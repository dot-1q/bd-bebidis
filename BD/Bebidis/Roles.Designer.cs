
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
            this.seePromotors = new System.Windows.Forms.ListBox();
            this.insertWorker = new System.Windows.Forms.Button();
            this.updateRole = new System.Windows.Forms.Button();
            this.fireWorker = new System.Windows.Forms.Button();
            this.seeOperators = new System.Windows.Forms.ListBox();
            this.seeTruckers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // seePromotors
            // 
            this.seePromotors.FormattingEnabled = true;
            this.seePromotors.ItemHeight = 15;
            this.seePromotors.Location = new System.Drawing.Point(12, 81);
            this.seePromotors.Name = "seePromotors";
            this.seePromotors.Size = new System.Drawing.Size(776, 169);
            this.seePromotors.TabIndex = 0;
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
            // seeOperators
            // 
            this.seeOperators.FormattingEnabled = true;
            this.seeOperators.ItemHeight = 15;
            this.seeOperators.Location = new System.Drawing.Point(12, 256);
            this.seeOperators.Name = "seeOperators";
            this.seeOperators.Size = new System.Drawing.Size(776, 169);
            this.seeOperators.TabIndex = 7;
            // 
            // seeTruckers
            // 
            this.seeTruckers.FormattingEnabled = true;
            this.seeTruckers.ItemHeight = 15;
            this.seeTruckers.Location = new System.Drawing.Point(12, 431);
            this.seeTruckers.Name = "seeTruckers";
            this.seeTruckers.Size = new System.Drawing.Size(776, 169);
            this.seeTruckers.TabIndex = 8;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.seeTruckers);
            this.Controls.Add(this.seeOperators);
            this.Controls.Add(this.fireWorker);
            this.Controls.Add(this.updateRole);
            this.Controls.Add(this.insertWorker);
            this.Controls.Add(this.seePromotors);
            this.Name = "Roles";
            this.Text = "Roles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox seePromotors;
        private System.Windows.Forms.Button insertWorker;
        private System.Windows.Forms.Button updateRole;
        private System.Windows.Forms.Button fireWorker;
        private System.Windows.Forms.ListBox seeOperators;
        private System.Windows.Forms.ListBox seeTruckers;
    }
}