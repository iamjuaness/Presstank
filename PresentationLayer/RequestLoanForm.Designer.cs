using System.Windows.Forms;
using System;

namespace PresentationLayer
{
    partial class RequestLoanForm
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
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.lblLoanPeriod = new System.Windows.Forms.Label();
            this.cmbLoanPeriod = new System.Windows.Forms.ComboBox();
            this.btnSubmitRequest = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmount.Location = new System.Drawing.Point(239, 180);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(495, 60);
            this.lblLoanAmount.TabIndex = 0;
            this.lblLoanAmount.Text = "Monto del Préstamo:";
            this.lblLoanAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtLoanAmount.Location = new System.Drawing.Point(754, 180);
            this.txtLoanAmount.Multiline = true;
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(300, 50);
            this.txtLoanAmount.TabIndex = 1;
            // 
            // lblLoanPeriod
            // 
            this.lblLoanPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoanPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanPeriod.Location = new System.Drawing.Point(239, 320);
            this.lblLoanPeriod.Name = "lblLoanPeriod";
            this.lblLoanPeriod.Size = new System.Drawing.Size(400, 60);
            this.lblLoanPeriod.TabIndex = 2;
            this.lblLoanPeriod.Text = "Plazo (meses):";
            this.lblLoanPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLoanPeriod
            // 
            this.cmbLoanPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cmbLoanPeriod.Items.AddRange(new object[] {
            "24",
            "36",
            "48",
            "60",
            "72"});
            this.cmbLoanPeriod.Location = new System.Drawing.Point(754, 320);
            this.cmbLoanPeriod.Name = "cmbLoanPeriod";
            this.cmbLoanPeriod.Size = new System.Drawing.Size(300, 54);
            this.cmbLoanPeriod.TabIndex = 3;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.AutoSize = true;
            this.btnSubmitRequest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmitRequest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnSubmitRequest.ForeColor = System.Drawing.Color.White;
            this.btnSubmitRequest.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSubmitRequest.IconColor = System.Drawing.Color.White;
            this.btnSubmitRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmitRequest.IconSize = 40;
            this.btnSubmitRequest.Location = new System.Drawing.Point(334, 500);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(305, 70);
            this.btnSubmitRequest.TabIndex = 4;
            this.btnSubmitRequest.Text = "Enviar Solicitud";
            this.btnSubmitRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmitRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 40;
            this.btnCancel.Location = new System.Drawing.Point(754, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(300, 70);
            this.btnCancel.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(1564, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 900);
            this.label1.TabIndex = 6;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 129;
            this.iconPictureBox1.Location = new System.Drawing.Point(1692, 268);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(129, 129);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1625, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRESSTANK";
            // 
            // RequestLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1932, 900);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.cmbLoanPeriod);
            this.Controls.Add(this.lblLoanPeriod);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.lblLoanAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestLoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Préstamo";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label lblLoanPeriod;
        private System.Windows.Forms.ComboBox cmbLoanPeriod;
        private FontAwesome.Sharp.IconButton btnSubmitRequest;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
