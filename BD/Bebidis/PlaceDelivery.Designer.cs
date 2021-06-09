
namespace Bebidis
{
    partial class PlaceDelivery
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
            this.salesNotDelivered = new System.Windows.Forms.ListBox();
            this.confirmDeliveries = new System.Windows.Forms.Button();
            this.selectDriver = new System.Windows.Forms.Button();
            this.availableTruckers = new System.Windows.Forms.ListBox();
            this.availableTrucks = new System.Windows.Forms.ListBox();
            this.selectTruck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesNotDelivered
            // 
            this.salesNotDelivered.FormattingEnabled = true;
            this.salesNotDelivered.ItemHeight = 15;
            this.salesNotDelivered.Location = new System.Drawing.Point(12, 70);
            this.salesNotDelivered.Name = "salesNotDelivered";
            this.salesNotDelivered.Size = new System.Drawing.Size(552, 364);
            this.salesNotDelivered.TabIndex = 0;
            // 
            // confirmDeliveries
            // 
            this.confirmDeliveries.Location = new System.Drawing.Point(668, 12);
            this.confirmDeliveries.Name = "confirmDeliveries";
            this.confirmDeliveries.Size = new System.Drawing.Size(120, 45);
            this.confirmDeliveries.TabIndex = 2;
            this.confirmDeliveries.Text = "Confirmar Encomenda(s)";
            this.confirmDeliveries.UseVisualStyleBackColor = true;
            // 
            // selectDriver
            // 
            this.selectDriver.Location = new System.Drawing.Point(12, 12);
            this.selectDriver.Name = "selectDriver";
            this.selectDriver.Size = new System.Drawing.Size(120, 45);
            this.selectDriver.TabIndex = 3;
            this.selectDriver.Text = "Selecionar Transportador";
            this.selectDriver.UseVisualStyleBackColor = true;
            // 
            // availableTruckers
            // 
            this.availableTruckers.FormattingEnabled = true;
            this.availableTruckers.ItemHeight = 15;
            this.availableTruckers.Location = new System.Drawing.Point(570, 70);
            this.availableTruckers.Name = "availableTruckers";
            this.availableTruckers.Size = new System.Drawing.Size(218, 169);
            this.availableTruckers.TabIndex = 4;
            // 
            // availableTrucks
            // 
            this.availableTrucks.FormattingEnabled = true;
            this.availableTrucks.ItemHeight = 15;
            this.availableTrucks.Location = new System.Drawing.Point(570, 249);
            this.availableTrucks.Name = "availableTrucks";
            this.availableTrucks.Size = new System.Drawing.Size(218, 184);
            this.availableTrucks.TabIndex = 5;
            // 
            // selectTruck
            // 
            this.selectTruck.Location = new System.Drawing.Point(138, 12);
            this.selectTruck.Name = "selectTruck";
            this.selectTruck.Size = new System.Drawing.Size(120, 45);
            this.selectTruck.TabIndex = 6;
            this.selectTruck.Text = "Selecionar Pesado";
            this.selectTruck.UseVisualStyleBackColor = true;
            // 
            // PlaceDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectTruck);
            this.Controls.Add(this.availableTrucks);
            this.Controls.Add(this.availableTruckers);
            this.Controls.Add(this.selectDriver);
            this.Controls.Add(this.confirmDeliveries);
            this.Controls.Add(this.salesNotDelivered);
            this.Name = "PlaceDelivery";
            this.Text = "PlaceDelivery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox salesNotDelivered;
        private System.Windows.Forms.Button confirmDeliveries;
        private System.Windows.Forms.Button selectDriver;
        private System.Windows.Forms.ListBox availableTruckers;
        private System.Windows.Forms.ListBox availableTrucks;
        private System.Windows.Forms.Button selectTruck;
    }
}