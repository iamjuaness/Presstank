using System.Windows.Forms;
using System;

namespace PresentationLayer
{
    partial class PayLoanInstallmentForm
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
            this.lblLoan = new System.Windows.Forms.Label();
            this.cmbLoan = new System.Windows.Forms.ComboBox();
            this.lblInstallmentNumber = new System.Windows.Forms.Label();
            this.txtInstallmentNumber = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
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
            this.lblLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(29, 32);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(165, 33);
            this.lblLoan.TabIndex = 0;
            this.lblLoan.Text = "Préstamo:";
            // 
            // cmbLoan
            // 
            this.cmbLoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoan.Location = new System.Drawing.Point(264, 32);
            this.cmbLoan.Name = "cmbLoan";
            this.cmbLoan.Size = new System.Drawing.Size(200, 28);
            this.cmbLoan.TabIndex = 1;
            // 
            // lblInstallmentNumber
            // 
            this.lblInstallmentNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstallmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallmentNumber.Location = new System.Drawing.Point(29, 82);
            this.lblInstallmentNumber.Name = "lblInstallmentNumber";
            this.lblInstallmentNumber.Size = new System.Drawing.Size(165, 33);
            this.lblInstallmentNumber.TabIndex = 2;
            this.lblInstallmentNumber.Text = "Número de Cuota:";
            // 
            // txtInstallmentNumber
            // 
            this.txtInstallmentNumber.Location = new System.Drawing.Point(264, 82);
            this.txtInstallmentNumber.Name = "txtInstallmentNumber";
            this.txtInstallmentNumber.Size = new System.Drawing.Size(200, 26);
            this.txtInstallmentNumber.TabIndex = 3;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(29, 132);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(165, 33);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Fecha de Pago:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(264, 132);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(200, 26);
            this.dtpPaymentDate.TabIndex = 5;
            // 
            // lblInstallmentAmount
            // 
            this.lblInstallmentAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstallmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallmentAmount.Location = new System.Drawing.Point(29, 182);
            this.lblInstallmentAmount.Name = "lblInstallmentAmount";
            this.lblInstallmentAmount.Size = new System.Drawing.Size(165, 33);
            this.lblInstallmentAmount.TabIndex = 6;
            this.lblInstallmentAmount.Text = "Monto de Cuota:";
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Location = new System.Drawing.Point(264, 182);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.Size = new System.Drawing.Size(200, 26);
            this.txtInstallmentAmount.TabIndex = 7;
            // 
            // btnRegisterPayment
            // 
            this.btnRegisterPayment.AutoSize = true;
            this.btnRegisterPayment.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisterPayment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegisterPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPayment.ForeColor = System.Drawing.Color.White;
            this.btnRegisterPayment.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnRegisterPayment.IconColor = System.Drawing.Color.White;
            this.btnRegisterPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterPayment.IconSize = 32;
            this.btnRegisterPayment.Location = new System.Drawing.Point(33, 232);
            this.btnRegisterPayment.Name = "btnRegisterPayment";
            this.btnRegisterPayment.Size = new System.Drawing.Size(183, 52);
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
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 32;
            this.btnCancel.Location = new System.Drawing.Point(294, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 52);
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
            this.label1.Location = new System.Drawing.Point(538, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 320);
            this.label1.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 129;
            this.iconPictureBox1.Location = new System.Drawing.Point(632, 32);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(129, 129);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(591, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "PRESSTANK";
            // 
            // PayLoanInstallmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterPayment);
            this.Controls.Add(this.txtInstallmentAmount);
            this.Controls.Add(this.lblInstallmentAmount);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.txtInstallmentNumber);
            this.Controls.Add(this.lblInstallmentNumber);
            this.Controls.Add(this.cmbLoan);
            this.Controls.Add(this.lblLoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lblInstallmentNumber;
        private System.Windows.Forms.TextBox txtInstallmentNumber;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblInstallmentAmount;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private FontAwesome.Sharp.IconButton btnRegisterPayment;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
   
    }
}