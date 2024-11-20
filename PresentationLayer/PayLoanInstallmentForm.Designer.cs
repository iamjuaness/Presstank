using System.Windows.Forms;
using System;

namespace PresentationLayer
{
    partial class PayLoanInstallmentForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblInstallmentAmount = new System.Windows.Forms.Label();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.btnRegisterPayment = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.LoanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstallmentAmount
            // 
            this.lblInstallmentAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstallmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInstallmentAmount.Location = new System.Drawing.Point(20, 340);
            this.lblInstallmentAmount.Name = "lblInstallmentAmount";
            this.lblInstallmentAmount.Size = new System.Drawing.Size(210, 50);
            this.lblInstallmentAmount.TabIndex = 6;
            this.lblInstallmentAmount.Text = "Monto de Cuota:";
            this.lblInstallmentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtInstallmentAmount.Location = new System.Drawing.Point(250, 350);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.Size = new System.Drawing.Size(200, 39);
            this.txtInstallmentAmount.TabIndex = 7;
            // 
            // btnRegisterPayment
            // 
            this.btnRegisterPayment.AutoSize = true;
            this.btnRegisterPayment.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisterPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegisterPayment.ForeColor = System.Drawing.Color.White;
            this.btnRegisterPayment.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnRegisterPayment.IconColor = System.Drawing.Color.White;
            this.btnRegisterPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterPayment.IconSize = 25;
            this.btnRegisterPayment.Location = new System.Drawing.Point(470, 470);
            this.btnRegisterPayment.Name = "btnRegisterPayment";
            this.btnRegisterPayment.Size = new System.Drawing.Size(236, 56);
            this.btnRegisterPayment.TabIndex = 8;
            this.btnRegisterPayment.Text = "Registrar Pago";
            this.btnRegisterPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegisterPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegisterPayment.UseVisualStyleBackColor = false;
            this.btnRegisterPayment.Click += new System.EventHandler(this.btnRegisterPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 25;
            this.btnCancel.Location = new System.Drawing.Point(720, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(236, 56);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(1157, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 587);
            this.label1.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 135;
            this.iconPictureBox1.Location = new System.Drawing.Point(1264, 177);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(135, 150);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1220, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "PRESSTANK";
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoanId,
            this.LoanAmount,
            this.PendingAmount,
            this.DueDate});
            this.dgvLoans.Location = new System.Drawing.Point(20, 20);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowHeadersWidth = 62;
            this.dgvLoans.RowTemplate.Height = 28;
            this.dgvLoans.Size = new System.Drawing.Size(1100, 300);
            this.dgvLoans.TabIndex = 13;
            // 
            // LoanId
            // 
            this.LoanId.HeaderText = "ID Préstamo";
            this.LoanId.MinimumWidth = 8;
            this.LoanId.Name = "LoanId";
            this.LoanId.Width = 200;
            // 
            // LoanAmount
            // 
            this.LoanAmount.HeaderText = "Monto Total";
            this.LoanAmount.MinimumWidth = 8;
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.Width = 200;
            // 
            // PendingAmount
            // 
            this.PendingAmount.HeaderText = "Saldo Pendiente";
            this.PendingAmount.MinimumWidth = 8;
            this.PendingAmount.Name = "PendingAmount";
            this.PendingAmount.Width = 200;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Fecha Vencimiento";
            this.DueDate.MinimumWidth = 8;
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 200;
            // 
            // PayLoanInstallmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 587);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterPayment);
            this.Controls.Add(this.txtInstallmentAmount);
            this.Controls.Add(this.lblInstallmentAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayLoanInstallmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar Cuota";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstallmentAmount;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private FontAwesome.Sharp.IconButton btnRegisterPayment;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PendingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
    }
}
