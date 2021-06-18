
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
            this.deleteVehicle = new System.Windows.Forms.Button();
            this.viewVehiclesLig = new System.Windows.Forms.DataGridView();
            this.viewVehiclesPes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.matriculaRemove = new System.Windows.Forms.TextBox();
            this.insertAlterVehicle = new System.Windows.Forms.Button();
            this.cargaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.defResp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiclesLig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiclesPes)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteVehicle
            // 
            this.deleteVehicle.Location = new System.Drawing.Point(839, 393);
            this.deleteVehicle.Name = "deleteVehicle";
            this.deleteVehicle.Size = new System.Drawing.Size(69, 45);
            this.deleteVehicle.TabIndex = 6;
            this.deleteVehicle.Text = "Remover Veículo";
            this.deleteVehicle.UseVisualStyleBackColor = true;
            this.deleteVehicle.Click += new System.EventHandler(this.deleteVehicle_Click);
            // 
            // viewVehiclesLig
            // 
            this.viewVehiclesLig.AllowUserToAddRows = false;
            this.viewVehiclesLig.AllowUserToDeleteRows = false;
            this.viewVehiclesLig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewVehiclesLig.Location = new System.Drawing.Point(12, 12);
            this.viewVehiclesLig.Name = "viewVehiclesLig";
            this.viewVehiclesLig.RowTemplate.Height = 25;
            this.viewVehiclesLig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewVehiclesLig.Size = new System.Drawing.Size(693, 200);
            this.viewVehiclesLig.TabIndex = 8;
            this.viewVehiclesLig.SelectionChanged += new System.EventHandler(this.viewVehiclesLig_SelectionChanged);
            // 
            // viewVehiclesPes
            // 
            this.viewVehiclesPes.AllowUserToAddRows = false;
            this.viewVehiclesPes.AllowUserToDeleteRows = false;
            this.viewVehiclesPes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewVehiclesPes.Location = new System.Drawing.Point(12, 218);
            this.viewVehiclesPes.Name = "viewVehiclesPes";
            this.viewVehiclesPes.RowTemplate.Height = 25;
            this.viewVehiclesPes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewVehiclesPes.Size = new System.Drawing.Size(693, 217);
            this.viewVehiclesPes.TabIndex = 9;
            this.viewVehiclesPes.SelectionChanged += new System.EventHandler(this.viewVehiclesPes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Matrícula: ";
            // 
            // matriculaRemove
            // 
            this.matriculaRemove.Location = new System.Drawing.Point(711, 412);
            this.matriculaRemove.Name = "matriculaRemove";
            this.matriculaRemove.Size = new System.Drawing.Size(122, 23);
            this.matriculaRemove.TabIndex = 12;
            // 
            // insertAlterVehicle
            // 
            this.insertAlterVehicle.Location = new System.Drawing.Point(711, 116);
            this.insertAlterVehicle.Name = "insertAlterVehicle";
            this.insertAlterVehicle.Size = new System.Drawing.Size(190, 32);
            this.insertAlterVehicle.TabIndex = 18;
            this.insertAlterVehicle.Text = "Adicionar / Alterar Veículo";
            this.insertAlterVehicle.UseVisualStyleBackColor = true;
            this.insertAlterVehicle.Click += new System.EventHandler(this.insertAlterVehicle_Click);
            // 
            // cargaBox
            // 
            this.cargaBox.Location = new System.Drawing.Point(799, 87);
            this.cargaBox.Name = "cargaBox";
            this.cargaBox.Size = new System.Drawing.Size(100, 23);
            this.cargaBox.TabIndex = 17;
            this.cargaBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Carga : ";
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(799, 12);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(100, 23);
            this.matricula.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Matrícula: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Caso seja Pesado, indique a carga";
            // 
            // defResp
            // 
            this.defResp.Location = new System.Drawing.Point(715, 203);
            this.defResp.Name = "defResp";
            this.defResp.Size = new System.Drawing.Size(193, 45);
            this.defResp.TabIndex = 20;
            this.defResp.Text = "Definir Responsável do Ligeiro";
            this.defResp.UseVisualStyleBackColor = true;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.defResp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertAlterVehicle);
            this.Controls.Add(this.cargaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matriculaRemove);
            this.Controls.Add(this.viewVehiclesPes);
            this.Controls.Add(this.viewVehiclesLig);
            this.Controls.Add(this.deleteVehicle);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiclesLig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiclesPes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteVehicle;
        private System.Windows.Forms.DataGridView viewVehiclesLig;
        private System.Windows.Forms.DataGridView viewVehiclesPes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matriculaRemove;
        private System.Windows.Forms.Button insertAlterVehicle;
        private System.Windows.Forms.TextBox cargaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button defResp;
    }
}