
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
            this.confirmDeliveries = new System.Windows.Forms.Button();
            this.viewSalesNotEnc = new System.Windows.Forms.DataGridView();
            this.viewTrucks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewTruckers = new System.Windows.Forms.DataGridView();
            this.salesNum = new System.Windows.Forms.TextBox();
            this.Transportador = new System.Windows.Forms.Label();
            this.truckNum = new System.Windows.Forms.TextBox();
            this.truckerNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesNotEnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTruckers)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmDeliveries
            // 
            this.confirmDeliveries.Location = new System.Drawing.Point(252, 9);
            this.confirmDeliveries.Name = "confirmDeliveries";
            this.confirmDeliveries.Size = new System.Drawing.Size(120, 81);
            this.confirmDeliveries.TabIndex = 2;
            this.confirmDeliveries.Text = "Confirmar Encomenda";
            this.confirmDeliveries.UseVisualStyleBackColor = true;
            this.confirmDeliveries.Click += new System.EventHandler(this.confirmDeliveries_Click);
            // 
            // viewSalesNotEnc
            // 
            this.viewSalesNotEnc.AllowUserToAddRows = false;
            this.viewSalesNotEnc.AllowUserToDeleteRows = false;
            this.viewSalesNotEnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSalesNotEnc.Location = new System.Drawing.Point(12, 96);
            this.viewSalesNotEnc.MultiSelect = false;
            this.viewSalesNotEnc.Name = "viewSalesNotEnc";
            this.viewSalesNotEnc.RowTemplate.Height = 25;
            this.viewSalesNotEnc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewSalesNotEnc.Size = new System.Drawing.Size(943, 363);
            this.viewSalesNotEnc.TabIndex = 7;
            this.viewSalesNotEnc.SelectionChanged += new System.EventHandler(this.viewSalesNotEnc_SelectionChanged);
            // 
            // viewTrucks
            // 
            this.viewTrucks.AllowUserToAddRows = false;
            this.viewTrucks.AllowUserToDeleteRows = false;
            this.viewTrucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTrucks.Location = new System.Drawing.Point(961, 96);
            this.viewTrucks.MultiSelect = false;
            this.viewTrucks.Name = "viewTrucks";
            this.viewTrucks.RowTemplate.Height = 25;
            this.viewTrucks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewTrucks.Size = new System.Drawing.Size(260, 179);
            this.viewTrucks.TabIndex = 8;
            this.viewTrucks.SelectionChanged += new System.EventHandler(this.viewTrucks_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Venda(s) : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pesado : ";
            // 
            // viewTruckers
            // 
            this.viewTruckers.AllowUserToAddRows = false;
            this.viewTruckers.AllowUserToDeleteRows = false;
            this.viewTruckers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTruckers.Location = new System.Drawing.Point(961, 280);
            this.viewTruckers.Name = "viewTruckers";
            this.viewTruckers.RowTemplate.Height = 25;
            this.viewTruckers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewTruckers.Size = new System.Drawing.Size(260, 179);
            this.viewTruckers.TabIndex = 11;
            this.viewTruckers.SelectionChanged += new System.EventHandler(this.viewTruckers_SelectionChanged);
            // 
            // salesNum
            // 
            this.salesNum.Location = new System.Drawing.Point(105, 10);
            this.salesNum.Name = "salesNum";
            this.salesNum.Size = new System.Drawing.Size(100, 23);
            this.salesNum.TabIndex = 12;
            // 
            // Transportador
            // 
            this.Transportador.AutoSize = true;
            this.Transportador.Location = new System.Drawing.Point(13, 70);
            this.Transportador.Name = "Transportador";
            this.Transportador.Size = new System.Drawing.Size(89, 15);
            this.Transportador.TabIndex = 13;
            this.Transportador.Text = "Transportador : ";
            // 
            // truckNum
            // 
            this.truckNum.Location = new System.Drawing.Point(105, 39);
            this.truckNum.Name = "truckNum";
            this.truckNum.Size = new System.Drawing.Size(100, 23);
            this.truckNum.TabIndex = 14;
            // 
            // truckerNum
            // 
            this.truckerNum.Location = new System.Drawing.Point(105, 67);
            this.truckerNum.Name = "truckerNum";
            this.truckerNum.Size = new System.Drawing.Size(100, 23);
            this.truckerNum.TabIndex = 15;
            // 
            // PlaceDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 473);
            this.Controls.Add(this.truckerNum);
            this.Controls.Add(this.truckNum);
            this.Controls.Add(this.Transportador);
            this.Controls.Add(this.salesNum);
            this.Controls.Add(this.viewTruckers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewTrucks);
            this.Controls.Add(this.viewSalesNotEnc);
            this.Controls.Add(this.confirmDeliveries);
            this.Name = "PlaceDelivery";
            this.Text = "PlaceDelivery";
            this.Load += new System.EventHandler(this.PlaceDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesNotEnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTruckers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmDeliveries;
        private System.Windows.Forms.DataGridView viewSalesNotEnc;
        private System.Windows.Forms.DataGridView viewTrucks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView viewTruckers;
        private System.Windows.Forms.TextBox salesNum;
        private System.Windows.Forms.Label Transportador;
        private System.Windows.Forms.TextBox truckNum;
        private System.Windows.Forms.TextBox truckerNum;
    }
}