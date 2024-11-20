using System.Windows.Forms;
using System;

namespace PresentationLayer
{
    partial class ManageSucursalForm
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
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblIDMunicipio = new System.Windows.Forms.Label();
            this.cmbIDMunicipio = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sucursalesDataView = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.Location = new System.Drawing.Point(50, 30);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(150, 25);
            this.lblNombreSucursal.TabIndex = 0;
            this.lblNombreSucursal.Text = "Nombre Sucursal:";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(200, 30);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(200, 26);
            this.txtNombreSucursal.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(50, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(150, 25);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(200, 80);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblIDMunicipio
            // 
            this.lblIDMunicipio.Location = new System.Drawing.Point(50, 130);
            this.lblIDMunicipio.Name = "lblIDMunicipio";
            this.lblIDMunicipio.Size = new System.Drawing.Size(150, 25);
            this.lblIDMunicipio.TabIndex = 4;
            this.lblIDMunicipio.Text = "Municipio:";
            // 
            // cmbIDMunicipio
            // 
            this.cmbIDMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDMunicipio.Items.AddRange(new object[] {
            "1 - Municipio A",
            "2 - Municipio B"});
            this.cmbIDMunicipio.Location = new System.Drawing.Point(200, 130);
            this.cmbIDMunicipio.Name = "cmbIDMunicipio";
            this.cmbIDMunicipio.Size = new System.Drawing.Size(200, 28);
            this.cmbIDMunicipio.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(95, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(245, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sucursalesDataView
            // 
            this.sucursalesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursalesDataView.Location = new System.Drawing.Point(457, 30);
            this.sucursalesDataView.Name = "sucursalesDataView";
            this.sucursalesDataView.RowHeadersWidth = 62;
            this.sucursalesDataView.RowTemplate.Height = 28;
            this.sucursalesDataView.Size = new System.Drawing.Size(916, 312);
            this.sucursalesDataView.TabIndex = 8;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSize = true;
            this.Eliminar.Location = new System.Drawing.Point(856, 381);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(98, 32);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // ManageSucursalForm
            // 
            this.ClientSize = new System.Drawing.Size(1456, 633);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.sucursalesDataView);
            this.Controls.Add(this.lblNombreSucursal);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblIDMunicipio);
            this.Controls.Add(this.cmbIDMunicipio);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "ManageSucursalForm";
            this.Text = "Gestión de Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblNombreSucursal;
        private TextBox txtNombreSucursal;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblIDMunicipio;
        private ComboBox cmbIDMunicipio;
        private Button btnSave;
        private Button btnCancel;
        private DataGridView sucursalesDataView;
        private Button Eliminar;
    }

    #endregion
}