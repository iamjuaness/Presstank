namespace PresentationLayer
{
    partial class ReportsAndQueries
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.queryResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(361, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Reportes y Consultas";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(20, 80);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(200, 40);
            this.generateReportButton.TabIndex = 1;
            this.generateReportButton.Text = "Generar Reporte PDF";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // queryResultsTextBox
            // 
            this.queryResultsTextBox.Location = new System.Drawing.Point(20, 140);
            this.queryResultsTextBox.Multiline = true;
            this.queryResultsTextBox.Name = "queryResultsTextBox";
            this.queryResultsTextBox.ReadOnly = true;
            this.queryResultsTextBox.Size = new System.Drawing.Size(600, 300);
            this.queryResultsTextBox.TabIndex = 2;
            // 
            // ReportsAndQueries
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.queryResultsTextBox);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "ReportsAndQueries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes y Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox queryResultsTextBox;
    }
}