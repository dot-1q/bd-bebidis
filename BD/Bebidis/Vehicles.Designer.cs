
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
            this.insertVehicle = new System.Windows.Forms.Button();
            this.deleteVehicle = new System.Windows.Forms.Button();
            this.viewVehiclesLig = new System.Windows.Forms.DataGridView();
            this.setResponsable = new System.Windows.Forms.Button();
            this.viewVehiclesPes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiclesLig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiclesPes)).BeginInit();
            this.SuspendLayout();
            // 
            // insertVehicle
            // 
            this.insertVehicle.Location = new System.Drawing.Point(12, 12);
            this.insertVehicle.Name = "insertVehicle";
            this.insertVehicle.Size = new System.Drawing.Size(120, 45);
            this.insertVehicle.TabIndex = 5;
            this.insertVehicle.Text = "Adicionar Veículo";
            this.insertVehicle.UseVisualStyleBackColor = true;
            this.insertVehicle.Click += new System.EventHandler(this.insertVehicle_Click);
            // 
            // deleteVehicle
            // 
            this.deleteVehicle.Location = new System.Drawing.Point(443, 12);
            this.deleteVehicle.Name = "deleteVehicle";
            this.deleteVehicle.Size = new System.Drawing.Size(120, 45);
            this.deleteVehicle.TabIndex = 6;
            this.deleteVehicle.Text = "Remover Veículo";
            this.deleteVehicle.UseVisualStyleBackColor = true;
            // 
            // viewVehiclesLig
            // 
            this.viewVehiclesLig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewVehiclesLig.Location = new System.Drawing.Point(13, 64);
            this.viewVehiclesLig.Name = "viewVehiclesLig";
            this.viewVehiclesLig.RowTemplate.Height = 25;
            this.viewVehiclesLig.Size = new System.Drawing.Size(693, 200);
            this.viewVehiclesLig.TabIndex = 8;
            // 
            // setResponsable
            // 
            this.setResponsable.Location = new System.Drawing.Point(138, 12);
            this.setResponsable.Name = "setResponsable";
            this.setResponsable.Size = new System.Drawing.Size(120, 45);
            this.setResponsable.TabIndex = 7;
            this.setResponsable.Text = "Definir Responsável";
            this.setResponsable.UseVisualStyleBackColor = true;
            // 
            // viewVehiclesPes
            // 
            this.viewVehiclesPes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewVehiclesPes.Location = new System.Drawing.Point(12, 270);
            this.viewVehiclesPes.Name = "viewVehiclesPes";
            this.viewVehiclesPes.RowTemplate.Height = 25;
            this.viewVehiclesPes.Size = new System.Drawing.Size(693, 165);
            this.viewVehiclesPes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Matrícula: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 12;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.viewVehiclesPes);
            this.Controls.Add(this.viewVehiclesLig);
            this.Controls.Add(this.setResponsable);
            this.Controls.Add(this.deleteVehicle);
            this.Controls.Add(this.insertVehicle);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiclesLig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiclesPes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insertVehicle;
        private System.Windows.Forms.Button deleteVehicle;
        private System.Windows.Forms.DataGridView viewVehiclesLig;
        private System.Windows.Forms.Button setResponsable;
        private System.Windows.Forms.DataGridView viewVehiclesPes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}