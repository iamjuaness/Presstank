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
            this.menuTitle = new System.Windows.Forms.MenuStrip();
            this.title = new System.Windows.Forms.Label();
            this.help = new FontAwesome.Sharp.IconMenuItem();
            this.utils = new FontAwesome.Sharp.IconMenuItem();
            this.reports_consults = new FontAwesome.Sharp.IconMenuItem();
            this.transactions = new FontAwesome.Sharp.IconMenuItem();
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
            this.menu.Size = new System.Drawing.Size(990, 84);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
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
            this.menuTitle.Size = new System.Drawing.Size(990, 72);
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
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // help
            // 
            this.help.AutoSize = false;
            this.help.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.help.IconColor = System.Drawing.Color.Black;
            this.help.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.help.IconSize = 50;
            this.help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(182, 80);
            this.help.Text = "Ayuda";
            this.help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.help.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // utils
            // 
            this.utils.AutoSize = false;
            this.utils.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.utils.IconColor = System.Drawing.Color.Black;
            this.utils.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.utils.IconSize = 50;
            this.utils.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utils.Name = "utils";
            this.utils.Size = new System.Drawing.Size(182, 80);
            this.utils.Text = "Utilidades";
            this.utils.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reports_consults
            // 
            this.reports_consults.AutoSize = false;
            this.reports_consults.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.reports_consults.IconColor = System.Drawing.Color.Black;
            this.reports_consults.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reports_consults.IconSize = 50;
            this.reports_consults.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reports_consults.Name = "reports_consults";
            this.reports_consults.Size = new System.Drawing.Size(182, 80);
            this.reports_consults.Text = "Reportes y Consultas";
            this.reports_consults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // transactions
            // 
            this.transactions.AutoSize = false;
            this.transactions.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.transactions.IconColor = System.Drawing.Color.Black;
            this.transactions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.transactions.IconSize = 50;
            this.transactions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(182, 80);
            this.transactions.Text = "Transacciones";
            this.transactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 696);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitle);
            this.MainMenuStrip = this.menu;
            this.Name = "Home";
            this.Text = "Form1";
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
    }
}

