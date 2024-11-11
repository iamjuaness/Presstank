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
            this.gestionUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.transactions = new FontAwesome.Sharp.IconMenuItem();
            this.requestLoan = new FontAwesome.Sharp.IconMenuItem();
            this.payLoanInstallment = new FontAwesome.Sharp.IconMenuItem();
            this.gestionPrestamos = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesAceptadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosRechazadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMorososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_consults = new FontAwesome.Sharp.IconMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosPorSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarHistorialDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstadoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utils = new FontAwesome.Sharp.IconMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacora = new FontAwesome.Sharp.IconMenuItem();
            this.help = new FontAwesome.Sharp.IconMenuItem();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.menuTitle = new System.Windows.Forms.MenuStrip();
            this.title = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtNameUser = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUsuarios,
            this.transactions,
            this.gestionPrestamos,
            this.reports_consults,
            this.utils,
            this.bitacora,
            this.help});
            this.menu.Location = new System.Drawing.Point(0, 72);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1478, 83);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // gestionUsuarios
            // 
            this.gestionUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem2,
            this.iconMenuItem3});
            this.gestionUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.gestionUsuarios.IconColor = System.Drawing.Color.Black;
            this.gestionUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gestionUsuarios.IconSize = 50;
            this.gestionUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestionUsuarios.Name = "gestionUsuarios";
            this.gestionUsuarios.Size = new System.Drawing.Size(184, 79);
            this.gestionUsuarios.Text = "Gestion de usuarios";
            this.gestionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 40;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(256, 34);
            this.iconMenuItem2.Text = "Solicitar Préstamo";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 40;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(256, 34);
            this.iconMenuItem3.Text = "Pagar Cuota";
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.requestLoan.Size = new System.Drawing.Size(256, 34);
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
            this.payLoanInstallment.Size = new System.Drawing.Size(256, 34);
            this.payLoanInstallment.Text = "Pagar Cuota";
            this.payLoanInstallment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payLoanInstallment.Click += new System.EventHandler(this.payLoanInstallment_Click);
            // 
            // gestionPrestamos
            // 
            this.gestionPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.solicitudesAceptadasToolStripMenuItem,
            this.prestamosRechazadosToolStripMenuItem,
            this.usuariosMorososToolStripMenuItem});
            this.gestionPrestamos.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.gestionPrestamos.IconColor = System.Drawing.Color.Black;
            this.gestionPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gestionPrestamos.IconSize = 50;
            this.gestionPrestamos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestionPrestamos.Name = "gestionPrestamos";
            this.gestionPrestamos.Size = new System.Drawing.Size(202, 79);
            this.gestionPrestamos.Text = "Gestión de prestamos";
            this.gestionPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(295, 34);
            this.toolStripMenuItem3.Text = "Solicitudes Pendientes";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(295, 34);
            this.toolStripMenuItem4.Text = "Solicitudes en Estudio";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // solicitudesAceptadasToolStripMenuItem
            // 
            this.solicitudesAceptadasToolStripMenuItem.Name = "solicitudesAceptadasToolStripMenuItem";
            this.solicitudesAceptadasToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.solicitudesAceptadasToolStripMenuItem.Text = "Solicitudes Aceptadas";
            // 
            // prestamosRechazadosToolStripMenuItem
            // 
            this.prestamosRechazadosToolStripMenuItem.Name = "prestamosRechazadosToolStripMenuItem";
            this.prestamosRechazadosToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.prestamosRechazadosToolStripMenuItem.Text = "Solicitudes Rechazadas";
            this.prestamosRechazadosToolStripMenuItem.Click += new System.EventHandler(this.prestamosRechazadosToolStripMenuItem_Click);
            // 
            // usuariosMorososToolStripMenuItem
            // 
            this.usuariosMorososToolStripMenuItem.Name = "usuariosMorososToolStripMenuItem";
            this.usuariosMorososToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.usuariosMorososToolStripMenuItem.Text = "Usuarios Morosos";
            // 
            // reports_consults
            // 
            this.reports_consults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.misSolicitudesToolStripMenuItem,
            this.prestamosPorSucursalToolStripMenuItem,
            this.buscarHistorialDePagosToolStripMenuItem,
            this.consultarEstadoDeCuentaToolStripMenuItem,
            this.historialDePagosToolStripMenuItem});
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
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // misSolicitudesToolStripMenuItem
            // 
            this.misSolicitudesToolStripMenuItem.Name = "misSolicitudesToolStripMenuItem";
            this.misSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.misSolicitudesToolStripMenuItem.Text = "Mis solicitudes";
            this.misSolicitudesToolStripMenuItem.Click += new System.EventHandler(this.misSolicitudesToolStripMenuItem_Click);
            // 
            // prestamosPorSucursalToolStripMenuItem
            // 
            this.prestamosPorSucursalToolStripMenuItem.Name = "prestamosPorSucursalToolStripMenuItem";
            this.prestamosPorSucursalToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.prestamosPorSucursalToolStripMenuItem.Text = "Prestamos por sucursal";
            // 
            // buscarHistorialDePagosToolStripMenuItem
            // 
            this.buscarHistorialDePagosToolStripMenuItem.Name = "buscarHistorialDePagosToolStripMenuItem";
            this.buscarHistorialDePagosToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.buscarHistorialDePagosToolStripMenuItem.Text = "Buscar Historial de pagos";
            // 
            // consultarEstadoDeCuentaToolStripMenuItem
            // 
            this.consultarEstadoDeCuentaToolStripMenuItem.Name = "consultarEstadoDeCuentaToolStripMenuItem";
            this.consultarEstadoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.consultarEstadoDeCuentaToolStripMenuItem.Text = "Consultar estado de cuenta";
            // 
            // historialDePagosToolStripMenuItem
            // 
            this.historialDePagosToolStripMenuItem.Name = "historialDePagosToolStripMenuItem";
            this.historialDePagosToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.historialDePagosToolStripMenuItem.Text = "Historial de pagos";
            // 
            // utils
            // 
            this.utils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.calendarioToolStripMenuItem});
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
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // bitacora
            // 
            this.bitacora.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.bitacora.IconColor = System.Drawing.Color.Black;
            this.bitacora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bitacora.IconSize = 50;
            this.bitacora.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bitacora.Name = "bitacora";
            this.bitacora.Size = new System.Drawing.Size(91, 79);
            this.bitacora.Text = "Bitácora";
            this.bitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(100, 100);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.Visible = false;
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
            this.menuTitle.Size = new System.Drawing.Size(1478, 72);
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
            this.container.Controls.Add(this.monthCalendar);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 155);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1478, 689);
            this.container.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(1521, 18);
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
            this.txtNameUser.Location = new System.Drawing.Point(1629, 18);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(60, 29);
            this.txtNameUser.TabIndex = 5;
            this.txtNameUser.Text = "user";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 844);
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
            this.container.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ToolStripMenuItem misSolicitudesToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem gestionPrestamos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private FontAwesome.Sharp.IconMenuItem bitacora;
        private System.Windows.Forms.ToolStripMenuItem solicitudesAceptadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosRechazadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMorososToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosPorSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarHistorialDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstadoDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePagosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem gestionUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
    }
}
