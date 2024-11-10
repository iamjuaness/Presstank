namespace PresentationLayer
{
    partial class Solicitudes
    {
        private System.ComponentModel.IContainer components = null;

        // Agregar un componente DataGridView para mostrar la tabla
        private System.Windows.Forms.DataGridView solicitudesDataGridView;

        /// <summary>
        /// Limpiar los recursos utilizados.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben ser eliminados; en caso contrario, false.</param>
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
        /// Método requerido para el soporte del diseñador: no modificar el contenido
        /// de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.solicitudesDataGridView = new System.Windows.Forms.DataGridView();
            this.revisar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // solicitudesDataGridView
            // 
            this.solicitudesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solicitudesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.solicitudesDataGridView.Name = "solicitudesDataGridView";
            this.solicitudesDataGridView.ReadOnly = true;
            this.solicitudesDataGridView.RowHeadersWidth = 62;
            this.solicitudesDataGridView.Size = new System.Drawing.Size(966, 400);
            this.solicitudesDataGridView.TabIndex = 0;

            // 
            // button1
            // 
            this.revisar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.revisar.ForeColor = System.Drawing.Color.White;
            this.revisar.Location = new System.Drawing.Point(164, 430);
            this.revisar.Name = "button1";
            this.revisar.Size = new System.Drawing.Size(254, 60);
            this.revisar.TabIndex = 1;
            this.revisar.Text = "Revisar Solicitud";
            this.revisar.UseVisualStyleBackColor = false;
            this.revisar.Click += new System.EventHandler(this.button1_Click);

            // 
            // button2
            // 
            this.cancelar.BackColor = System.Drawing.Color.LightCoral;
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Location = new System.Drawing.Point(563, 430);
            this.cancelar.Name = "button2";
            this.cancelar.Size = new System.Drawing.Size(254, 60);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "Cancelar solicitud";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 517);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.revisar);
            this.Controls.Add(this.solicitudesDataGridView);
            this.Name = "Solicitudes";
            this.Text = "Solicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button revisar;
        private System.Windows.Forms.Button cancelar;
    }
}
