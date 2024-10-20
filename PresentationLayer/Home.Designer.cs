namespace PresentationLayer
{
    partial class Home
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.transactions = new FontAwesome.Sharp.IconMenuItem();
            this.requestLoan = new FontAwesome.Sharp.IconMenuItem();
            this.payLoanInstallment = new FontAwesome.Sharp.IconMenuItem();
            this.reports_consults = new FontAwesome.Sharp.IconMenuItem();
            this.utils = new FontAwesome.Sharp.IconMenuItem();
            this.help = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitle = new System.Windows.Forms.MenuStrip();
            this.title = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtNameUser = new System.Windows.Forms.Label();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactions,
            this.reports_consults,
            this.utils,
            this.help});
            this.menu.Location = new System.Drawing.Point(0, 72);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1038, 83);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // transactions
            // 
            this.transactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestLoan,
            this.payLoanInstallment});
            this.transactions.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.transactions.IconColor = System.Drawing.Color.Black;
            this.transactions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.transactions.IconSize = 50;
            this.transactions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(135, 79);
            this.transactions.Text = "Transacciones";
            this.transactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // requestLoan
            // 
            this.requestLoan.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.requestLoan.IconColor = System.Drawing.Color.Black;
            this.requestLoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.requestLoan.IconSize = 40;
            this.requestLoan.Name = "requestLoan";
            this.requestLoan.Size = new System.Drawing.Size(270, 34);
            this.requestLoan.Text = "Solicitar Préstamo";
            this.requestLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.requestLoan.Click += new System.EventHandler(this.requestLoan_Click);
            // 
            // payLoanInstallment
            // 
            this.payLoanInstallment.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.payLoanInstallment.IconColor = System.Drawing.Color.Black;
            this.payLoanInstallment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.payLoanInstallment.IconSize = 40;
            this.payLoanInstallment.Name = "payLoanInstallment";
            this.payLoanInstallment.Size = new System.Drawing.Size(270, 34);
            this.payLoanInstallment.Text = "Pagar Cuota";
            this.payLoanInstallment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payLoanInstallment.Click += new System.EventHandler(this.payLoanInstallment_Click);
            // 
            // reports_consults
            // 
            this.reports_consults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.reports_consults.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.reports_consults.IconColor = System.Drawing.Color.Black;
            this.reports_consults.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reports_consults.IconSize = 50;
            this.reports_consults.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reports_consults.Name = "reports_consults";
            this.reports_consults.Size = new System.Drawing.Size(194, 79);
            this.reports_consults.Text = "Reportes y Consultas";
            this.reports_consults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // utils
            // 
            this.utils.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.utils.IconColor = System.Drawing.Color.Black;
            this.utils.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.utils.IconSize = 50;
            this.utils.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utils.Name = "utils";
            this.utils.Size = new System.Drawing.Size(106, 79);
            this.utils.Text = "Utilidades";
            this.utils.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // help
            // 
            this.help.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.help.IconColor = System.Drawing.Color.Black;
            this.help.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.help.IconSize = 50;
            this.help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(79, 79);
            this.help.Text = "Ayuda";
            this.help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = false;
            this.menuTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitle.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuTitle.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuTitle.Location = new System.Drawing.Point(0, 0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitle.Size = new System.Drawing.Size(1038, 72);
            this.menuTitle.TabIndex = 1;
            this.menuTitle.Text = "menuTitulo";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.SteelBlue;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(42, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(235, 40);
            this.title.TabIndex = 2;
            this.title.Text = "PRESSTANK";
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 155);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1038, 541);
            this.container.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(692, 18);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(102, 29);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "Usuario:";
            // 
            // txtNameUser
            // 
            this.txtNameUser.AutoSize = true;
            this.txtNameUser.BackColor = System.Drawing.Color.SteelBlue;
            this.txtNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUser.ForeColor = System.Drawing.Color.White;
            this.txtNameUser.Location = new System.Drawing.Point(800, 18);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(60, 29);
            this.txtNameUser.TabIndex = 5;
            this.txtNameUser.Text = "user";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 696);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.container);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitle);
            this.MainMenuStrip = this.menu;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitle;
        private System.Windows.Forms.Label title;
        private FontAwesome.Sharp.IconMenuItem help;
        private FontAwesome.Sharp.IconMenuItem transactions;
        private FontAwesome.Sharp.IconMenuItem reports_consults;
        private FontAwesome.Sharp.IconMenuItem utils;
        private FontAwesome.Sharp.IconMenuItem requestLoan;
        private FontAwesome.Sharp.IconMenuItem payLoanInstallment;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtNameUser;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}

