
namespace Bebidis
{
    partial class Vehicles
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
            this.seeVehiclesInUse = new System.Windows.Forms.ListBox();
            this.insertVehicle = new System.Windows.Forms.Button();
            this.deleteVehicle = new System.Windows.Forms.Button();
            this.setResponsable = new System.Windows.Forms.Button();
            this.seeVehiclesUnused = new System.Windows.Forms.ListBox();
            this.seeTrucksInUse = new System.Windows.Forms.ListBox();
            this.seeTrucksUnused = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // seeVehiclesInUse
            // 
            this.seeVehiclesInUse.FormattingEnabled = true;
            this.seeVehiclesInUse.ItemHeight = 15;
            this.seeVehiclesInUse.Location = new System.Drawing.Point(12, 89);
            this.seeVehiclesInUse.Name = "seeVehiclesInUse";
            this.seeVehiclesInUse.Size = new System.Drawing.Size(397, 169);
            this.seeVehiclesInUse.TabIndex = 0;
            // 
            // insertVehicle
            // 
            this.insertVehicle.Location = new System.Drawing.Point(12, 12);
            this.insertVehicle.Name = "insertVehicle";
            this.insertVehicle.Size = new System.Drawing.Size(120, 45);
            this.insertVehicle.TabIndex = 5;
            this.insertVehicle.Text = "Adicionar Veículo";
            this.insertVehicle.UseVisualStyleBackColor = true;
            // 
            // deleteVehicle
            // 
            this.deleteVehicle.Location = new System.Drawing.Point(138, 12);
            this.deleteVehicle.Name = "deleteVehicle";
            this.deleteVehicle.Size = new System.Drawing.Size(120, 45);
            this.deleteVehicle.TabIndex = 6;
            this.deleteVehicle.Text = "Remover Veículo";
            this.deleteVehicle.UseVisualStyleBackColor = true;
            // 
            // setResponsable
            // 
            this.setResponsable.Location = new System.Drawing.Point(264, 12);
            this.setResponsable.Name = "setResponsable";
            this.setResponsable.Size = new System.Drawing.Size(120, 45);
            this.setResponsable.TabIndex = 7;
            this.setResponsable.Text = "Definir Responsável";
            this.setResponsable.UseVisualStyleBackColor = true;
            // 
            // seeVehiclesUnused
            // 
            this.seeVehiclesUnused.FormattingEnabled = true;
            this.seeVehiclesUnused.ItemHeight = 15;
            this.seeVehiclesUnused.Location = new System.Drawing.Point(415, 89);
            this.seeVehiclesUnused.Name = "seeVehiclesUnused";
            this.seeVehiclesUnused.Size = new System.Drawing.Size(397, 169);
            this.seeVehiclesUnused.TabIndex = 8;
            // 
            // seeTrucksInUse
            // 
            this.seeTrucksInUse.FormattingEnabled = true;
            this.seeTrucksInUse.ItemHeight = 15;
            this.seeTrucksInUse.Location = new System.Drawing.Point(12, 264);
            this.seeTrucksInUse.Name = "seeTrucksInUse";
            this.seeTrucksInUse.Size = new System.Drawing.Size(397, 169);
            this.seeTrucksInUse.TabIndex = 9;
            // 
            // seeTrucksUnused
            // 
            this.seeTrucksUnused.FormattingEnabled = true;
            this.seeTrucksUnused.ItemHeight = 15;
            this.seeTrucksUnused.Location = new System.Drawing.Point(415, 264);
            this.seeTrucksUnused.Name = "seeTrucksUnused";
            this.seeTrucksUnused.Size = new System.Drawing.Size(397, 169);
            this.seeTrucksUnused.TabIndex = 10;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.seeTrucksUnused);
            this.Controls.Add(this.seeTrucksInUse);
            this.Controls.Add(this.seeVehiclesUnused);
            this.Controls.Add(this.setResponsable);
            this.Controls.Add(this.deleteVehicle);
            this.Controls.Add(this.insertVehicle);
            this.Controls.Add(this.seeVehiclesInUse);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox seeVehiclesInUse;
        private System.Windows.Forms.Button insertVehicle;
        private System.Windows.Forms.Button deleteVehicle;
        private System.Windows.Forms.Button setResponsable;
        private System.Windows.Forms.ListBox seeVehiclesUnused;
        private System.Windows.Forms.ListBox seeTrucksInUse;
        private System.Windows.Forms.ListBox seeTrucksUnused;
    }
}