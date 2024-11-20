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
            this.lblLoan = new System.Windows.Forms.Label();
            this.cmbLoan = new System.Windows.Forms.ComboBox();
            this.lblInstallmentAmount = new System.Windows.Forms.Label();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.btnRegisterPayment = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoan
            // 
            this.lblLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLoan.Location = new System.Drawing.Point(40, 137);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(272, 50);
            this.lblLoan.TabIndex = 0;
            this.lblLoan.Text = "Préstamo:";
            this.lblLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLoan
            // 
            this.cmbLoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbLoan.Location = new System.Drawing.Point(385, 137);
            this.cmbLoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLoan.Name = "cmbLoan";
            this.cmbLoan.Size = new System.Drawing.Size(280, 40);
            this.cmbLoan.TabIndex = 1;
            // 
            // lblInstallmentAmount
            // 
            this.lblInstallmentAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstallmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblInstallmentAmount.Location = new System.Drawing.Point(40, 272);
            this.lblInstallmentAmount.Name = "lblInstallmentAmount";
            this.lblInstallmentAmount.Size = new System.Drawing.Size(272, 50);
            this.lblInstallmentAmount.TabIndex = 6;
            this.lblInstallmentAmount.Text = "Monto de Cuota:";
            this.lblInstallmentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtInstallmentAmount.Location = new System.Drawing.Point(385, 272);
            this.txtInstallmentAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.Size = new System.Drawing.Size(280, 39);
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
            this.btnRegisterPayment.Location = new System.Drawing.Point(58, 425);
            this.btnRegisterPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnCancel.Location = new System.Drawing.Point(429, 425);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            // PayLoanInstallmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterPayment);
            this.Controls.Add(this.txtInstallmentAmount);
            this.Controls.Add(this.lblInstallmentAmount);
            this.Controls.Add(this.cmbLoan);
            this.Controls.Add(this.lblLoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PayLoanInstallmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar Cuota";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.ComboBox cmbLoan;
        private System.Windows.Forms.Label lblInstallmentAmount;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private FontAwesome.Sharp.IconButton btnRegisterPayment;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
