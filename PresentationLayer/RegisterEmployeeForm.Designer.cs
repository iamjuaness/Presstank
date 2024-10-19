namespace PresentationLayer
{
    partial class RegisterEmployeeForm
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
        /// Method to initialize components.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblIDSucursal = new System.Windows.Forms.Label();
            this.cmbIDSucursal = new System.Windows.Forms.ComboBox();
            this.lblIDCargo = new System.Windows.Forms.Label();
            this.cmbIDCargo = new System.Windows.Forms.ComboBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblIDNivel = new System.Windows.Forms.Label();
            this.cmbIDNivel = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(20, 20);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(106, 20);
            this.lblIDEmpleado.TabIndex = 0;
            this.lblIDEmpleado.Text = "ID Empleado:";

            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(150, 20);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(200, 26);
            this.txtIDEmpleado.TabIndex = 1;

            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";

            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 26);
            this.txtNombre.TabIndex = 3;

            // 
            // lblIDSucursal
            // 
            this.lblIDSucursal.AutoSize = true;
            this.lblIDSucursal.Location = new System.Drawing.Point(20, 100);
            this.lblIDSucursal.Name = "lblIDSucursal";
            this.lblIDSucursal.Size = new System.Drawing.Size(96, 20);
            this.lblIDSucursal.TabIndex = 4;
            this.lblIDSucursal.Text = "ID Sucursal:";

            // 
            // cmbIDSucursal
            // 
            this.cmbIDSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDSucursal.Location = new System.Drawing.Point(150, 100);
            this.cmbIDSucursal.Name = "cmbIDSucursal";
            this.cmbIDSucursal.Size = new System.Drawing.Size(200, 28);
            this.cmbIDSucursal.TabIndex = 5;

            // 
            // lblIDCargo
            // 
            this.lblIDCargo.AutoSize = true;
            this.lblIDCargo.Location = new System.Drawing.Point(20, 140);
            this.lblIDCargo.Name = "lblIDCargo";
            this.lblIDCargo.Size = new System.Drawing.Size(77, 20);
            this.lblIDCargo.TabIndex = 8;
            this.lblIDCargo.Text = "ID Cargo:";

            // 
            // cmbIDCargo
            // 
            this.cmbIDCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDCargo.Location = new System.Drawing.Point(150, 140);
            this.cmbIDCargo.Name = "cmbIDCargo";
            this.cmbIDCargo.Size = new System.Drawing.Size(200, 28);
            this.cmbIDCargo.TabIndex = 9;

            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(20, 180);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(128, 20);
            this.lblNombreUsuario.TabIndex = 10;
            this.lblNombreUsuario.Text = "Nombre Usuario:";

            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(150, 180);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtNombreUsuario.TabIndex = 11;

            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(20, 220);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(96, 20);
            this.lblContrasenia.TabIndex = 12;
            this.lblContrasenia.Text = "Contraseña:";

            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(150, 220);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(200, 26);
            this.txtContrasenia.TabIndex = 13;
            this.txtContrasenia.UseSystemPasswordChar = true;

            // 
            // lblIDNivel
            // 
            this.lblIDNivel.AutoSize = true;
            this.lblIDNivel.Location = new System.Drawing.Point(20, 260);
            this.lblIDNivel.Name = "lblIDNivel";
            this.lblIDNivel.Size = new System.Drawing.Size(67, 20);
            this.lblIDNivel.TabIndex = 14;
            this.lblIDNivel.Text = "ID Nivel:";

            // 
            // cmbIDNivel
            // 
            this.cmbIDNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDNivel.Location = new System.Drawing.Point(150, 260);
            this.cmbIDNivel.Name = "cmbIDNivel";
            this.cmbIDNivel.Size = new System.Drawing.Size(200, 28);
            this.cmbIDNivel.TabIndex = 15;

            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(150, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 40);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // 
            // RegisterEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbIDNivel);
            this.Controls.Add(this.lblIDNivel);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.cmbIDCargo);
            this.Controls.Add(this.lblIDCargo);
            this.Controls.Add(this.cmbIDSucursal);
            this.Controls.Add(this.lblIDSucursal);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.lblIDEmpleado);
            this.Name = "RegisterEmployeeForm";
            this.Text = "Registrar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblIDSucursal;
        private System.Windows.Forms.ComboBox cmbIDSucursal;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblIDCargo;
        private System.Windows.Forms.ComboBox cmbIDCargo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblIDNivel;
        private System.Windows.Forms.ComboBox cmbIDNivel;
        private System.Windows.Forms.Button btnGuardar;
    }
}
