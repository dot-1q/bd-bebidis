
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
            this.insertWorker = new System.Windows.Forms.Button();
            this.updateRole = new System.Windows.Forms.Button();
            this.fireWorker = new System.Windows.Forms.Button();
            this.viewPromotors = new System.Windows.Forms.DataGridView();
            this.viewOperators = new System.Windows.Forms.DataGridView();
            this.viewTruckers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewPromotors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTruckers)).BeginInit();
            this.SuspendLayout();
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
            // viewPromotors
            // 
            this.viewPromotors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewPromotors.Location = new System.Drawing.Point(12, 89);
            this.viewPromotors.Name = "viewPromotors";
            this.viewPromotors.RowTemplate.Height = 25;
            this.viewPromotors.Size = new System.Drawing.Size(776, 172);
            this.viewPromotors.TabIndex = 7;
            // 
            // viewOperators
            // 
            this.viewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOperators.Location = new System.Drawing.Point(12, 266);
            this.viewOperators.Name = "viewOperators";
            this.viewOperators.RowTemplate.Height = 25;
            this.viewOperators.Size = new System.Drawing.Size(776, 172);
            this.viewOperators.TabIndex = 8;
            // 
            // viewTruckers
            // 
            this.viewTruckers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTruckers.Location = new System.Drawing.Point(12, 444);
            this.viewTruckers.Name = "viewTruckers";
            this.viewTruckers.RowTemplate.Height = 25;
            this.viewTruckers.Size = new System.Drawing.Size(776, 172);
            this.viewTruckers.TabIndex = 9;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.viewTruckers);
            this.Controls.Add(this.viewOperators);
            this.Controls.Add(this.viewPromotors);
            this.Controls.Add(this.fireWorker);
            this.Controls.Add(this.updateRole);
            this.Controls.Add(this.insertWorker);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewPromotors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTruckers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertWorker;
        private System.Windows.Forms.Button updateRole;
        private System.Windows.Forms.Button fireWorker;
        private System.Windows.Forms.DataGridView viewPromotors;
        private System.Windows.Forms.DataGridView viewOperators;
        private System.Windows.Forms.DataGridView viewTruckers;
    }
}