namespace TinyGUI.UI.Windows
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlMenu = new Panel();
            pnlNav = new Panel();
            btnConsole = new Button();
            btnCompress = new Button();
            btnSettings = new Button();
            btnDashboard = new Button();
            pnlLogo = new Panel();
            lblLogo = new Label();
            btnNewVersion = new Button();
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            kpForm = new Krypton.Toolkit.KryptonPanel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kpForm).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(51, 51, 76);
            pnlMenu.Controls.Add(pnlNav);
            pnlMenu.Controls.Add(btnConsole);
            pnlMenu.Controls.Add(btnCompress);
            pnlMenu.Controls.Add(btnSettings);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Controls.Add(btnNewVersion);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 582);
            pnlMenu.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Cyan;
            pnlNav.Location = new Point(0, 86);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(5, 51);
            pnlNav.TabIndex = 4;
            // 
            // btnConsole
            // 
            btnConsole.Dock = DockStyle.Bottom;
            btnConsole.FlatAppearance.BorderSize = 0;
            btnConsole.FlatStyle = FlatStyle.Flat;
            btnConsole.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsole.ForeColor = Color.Gainsboro;
            btnConsole.Image = Properties.Resources.Progress;
            btnConsole.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsole.Location = new Point(0, 432);
            btnConsole.Name = "btnConsole";
            btnConsole.Padding = new Padding(12, 0, 0, 0);
            btnConsole.Size = new Size(220, 60);
            btnConsole.TabIndex = 1;
            btnConsole.Text = "Console";
            btnConsole.TextAlign = ContentAlignment.MiddleLeft;
            btnConsole.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsole.UseVisualStyleBackColor = true;
            // 
            // btnCompress
            // 
            btnCompress.Dock = DockStyle.Top;
            btnCompress.FlatAppearance.BorderSize = 0;
            btnCompress.FlatStyle = FlatStyle.Flat;
            btnCompress.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompress.ForeColor = Color.Gainsboro;
            btnCompress.Image = Properties.Resources.Progress;
            btnCompress.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompress.Location = new Point(0, 140);
            btnCompress.Name = "btnCompress";
            btnCompress.Padding = new Padding(12, 0, 0, 0);
            btnCompress.Size = new Size(220, 60);
            btnCompress.TabIndex = 1;
            btnCompress.Text = "Compress";
            btnCompress.TextAlign = ContentAlignment.MiddleLeft;
            btnCompress.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompress.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Image = Properties.Resources.Settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 492);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(12, 0, 0, 0);
            btnSettings.Size = new Size(220, 60);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.Image = Properties.Resources.Dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 80);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(36, 36, 54);
            pnlLogo.Controls.Add(lblLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 80);
            pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.Font = new Font("BPreplay PL", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(15, 15);
            lblLogo.Margin = new Padding(15);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(187, 50);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "TinyGUI";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewVersion
            // 
            btnNewVersion.BackColor = Color.FromArgb(36, 36, 54);
            btnNewVersion.Dock = DockStyle.Bottom;
            btnNewVersion.FlatAppearance.BorderSize = 0;
            btnNewVersion.FlatStyle = FlatStyle.Flat;
            btnNewVersion.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewVersion.ForeColor = Color.FromArgb(255, 128, 128);
            btnNewVersion.Location = new Point(0, 552);
            btnNewVersion.Name = "btnNewVersion";
            btnNewVersion.Size = new Size(220, 30);
            btnNewVersion.TabIndex = 5;
            btnNewVersion.Text = "New Version {version}";
            btnNewVersion.UseVisualStyleBackColor = false;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(220, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(715, 80);
            pnlTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.DeepSkyBlue;
            lblTitle.Location = new Point(292, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(123, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kpForm
            // 
            kpForm.Location = new Point(220, 80);
            kpForm.Margin = new Padding(0);
            kpForm.Name = "kpForm";
            kpForm.Size = new Size(715, 502);
            kpForm.StateCommon.Color1 = Color.FromArgb(76, 76, 114);
            kpForm.StateCommon.Color2 = Color.FromArgb(90, 81, 121);
            kpForm.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear33;
            kpForm.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 582);
            Controls.Add(kpForm);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(951, 621);
            MinimumSize = new Size(951, 621);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinyGUI";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kpForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlLogo;
        private Button btnCompress;
        private Button btnSettings;
        private Button btnDashboard;
        private Panel pnlTitleBar;
        private Label lblTitle;
        private Label lblLogo;
        private Panel pnlNav;
        private Button btnConsole;
        private Krypton.Toolkit.KryptonPanel kpForm;
        private Button btnNewVersion;
    }
}