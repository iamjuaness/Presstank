using System.Windows.Forms;
using System;

namespace PresentationLayer
{
    partial class FormPrincipal
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
        private void InitializeComponent()
        {
            this.btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarse = new FontAwesome.Sharp.IconButton();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.labelSide = new System.Windows.Forms.Label();
            this.iconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSize = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIniciarSesion.IconColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesion.Location = new System.Drawing.Point(76, 190);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(300, 67);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AutoSize = true;
            this.btnRegistrarse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrarse.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarse.Location = new System.Drawing.Point(76, 279);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(300, 67);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(57, 77);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(331, 37);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenido al Sistema";
            // 
            // labelSide
            // 
            this.labelSide.BackColor = System.Drawing.Color.SteelBlue;
            this.labelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSide.Location = new System.Drawing.Point(446, 0);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(200, 464);
            this.labelSide.TabIndex = 3;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox.IconSize = 54;
            this.iconPictureBox.Location = new System.Drawing.Point(196, 20);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(57, 54);
            this.iconPictureBox.TabIndex = 4;
            this.iconPictureBox.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 35;
            this.btnSalir.Location = new System.Drawing.Point(76, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(300, 67);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 464);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private FontAwesome.Sharp.IconButton btnRegistrarse;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private System.Windows.Forms.Label labelSide;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}