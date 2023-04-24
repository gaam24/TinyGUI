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
            kbConsole = new Krypton.Toolkit.KryptonButton();
            kbSettings = new Krypton.Toolkit.KryptonButton();
            kbCompress = new Krypton.Toolkit.KryptonButton();
            kbDashboard = new Krypton.Toolkit.KryptonButton();
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
            pnlMenu.Controls.Add(kbConsole);
            pnlMenu.Controls.Add(kbSettings);
            pnlMenu.Controls.Add(kbCompress);
            pnlMenu.Controls.Add(kbDashboard);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Controls.Add(btnNewVersion);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 582);
            pnlMenu.TabIndex = 0;
            // 
            // kbConsole
            // 
            kbConsole.CornerRoundingRadius = 8F;
            kbConsole.Location = new Point(118, 502);
            kbConsole.Margin = new Padding(15, 5, 15, 5);
            kbConsole.Name = "kbConsole";
            kbConsole.OverrideDefault.Back.Color1 = Color.FromArgb(76, 76, 114);
            kbConsole.OverrideDefault.Border.Color1 = Color.FromArgb(76, 76, 114);
            kbConsole.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbConsole.Size = new Size(87, 42);
            kbConsole.StateCommon.Back.Color1 = Color.FromArgb(76, 76, 114);
            kbConsole.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbConsole.StateCommon.Border.Color1 = Color.FromArgb(76, 76, 114);
            kbConsole.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbConsole.StateCommon.Border.Rounding = 8F;
            kbConsole.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            kbConsole.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbConsole.StateCommon.Content.ShortText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbConsole.StateDisabled.Back.Color1 = Color.FromArgb(42, 42, 63);
            kbConsole.StateDisabled.Border.Color1 = Color.FromArgb(42, 42, 63);
            kbConsole.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbConsole.StatePressed.Back.Color1 = Color.FromArgb(42, 42, 63);
            kbConsole.StatePressed.Border.Color1 = Color.FromArgb(42, 42, 63);
            kbConsole.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbConsole.TabIndex = 6;
            kbConsole.Values.Text = "Console";
            // 
            // kbSettings
            // 
            kbSettings.CornerRoundingRadius = 8F;
            kbSettings.Location = new Point(15, 502);
            kbSettings.Margin = new Padding(15, 5, 15, 5);
            kbSettings.Name = "kbSettings";
            kbSettings.OverrideDefault.Back.Color1 = Color.FromArgb(76, 76, 114);
            kbSettings.OverrideDefault.Border.Color1 = Color.FromArgb(76, 76, 114);
            kbSettings.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbSettings.Size = new Size(87, 42);
            kbSettings.StateCommon.Back.Color1 = Color.FromArgb(76, 76, 114);
            kbSettings.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbSettings.StateCommon.Border.Color1 = Color.FromArgb(76, 76, 114);
            kbSettings.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbSettings.StateCommon.Border.Rounding = 8F;
            kbSettings.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            kbSettings.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbSettings.StateCommon.Content.ShortText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbSettings.StateDisabled.Back.Color1 = Color.FromArgb(42, 42, 63);
            kbSettings.StateDisabled.Border.Color1 = Color.FromArgb(42, 42, 63);
            kbSettings.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbSettings.StatePressed.Back.Color1 = Color.FromArgb(42, 42, 63);
            kbSettings.StatePressed.Border.Color1 = Color.FromArgb(42, 42, 63);
            kbSettings.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbSettings.TabIndex = 6;
            kbSettings.Values.Text = "Settings";
            // 
            // kbCompress
            // 
            kbCompress.CornerRoundingRadius = 8F;
            kbCompress.Location = new Point(15, 150);
            kbCompress.Margin = new Padding(15, 5, 15, 5);
            kbCompress.Name = "kbCompress";
            kbCompress.OverrideDefault.Back.Color1 = Color.FromArgb(76, 76, 114);
            kbCompress.OverrideDefault.Border.Color1 = Color.FromArgb(76, 76, 114);
            kbCompress.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbCompress.Size = new Size(190, 42);
            kbCompress.StateCommon.Back.Color1 = Color.FromArgb(76, 76, 114);
            kbCompress.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbCompress.StateCommon.Border.Color1 = Color.FromArgb(76, 76, 114);
            kbCompress.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbCompress.StateCommon.Border.Rounding = 8F;
            kbCompress.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            kbCompress.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbCompress.StateCommon.Content.ShortText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbCompress.StateDisabled.Back.Color1 = Color.FromArgb(42, 42, 63);
            kbCompress.StateDisabled.Border.Color1 = Color.FromArgb(42, 42, 63);
            kbCompress.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbCompress.StatePressed.Back.Color1 = Color.FromArgb(42, 42, 63);
            kbCompress.StatePressed.Border.Color1 = Color.FromArgb(42, 42, 63);
            kbCompress.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbCompress.TabIndex = 6;
            kbCompress.Values.Text = "Compress";
            // 
            // kbDashboard
            // 
            kbDashboard.CornerRoundingRadius = 8F;
            kbDashboard.Location = new Point(15, 98);
            kbDashboard.Margin = new Padding(15, 15, 15, 5);
            kbDashboard.Name = "kbDashboard";
            kbDashboard.OverrideDefault.Back.Color1 = Color.FromArgb(76, 76, 114);
            kbDashboard.OverrideDefault.Border.Color1 = Color.FromArgb(76, 76, 114);
            kbDashboard.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbDashboard.Size = new Size(190, 42);
            kbDashboard.StateCommon.Back.Color1 = Color.FromArgb(76, 76, 114);
            kbDashboard.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbDashboard.StateCommon.Border.Color1 = Color.FromArgb(76, 76, 114);
            kbDashboard.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbDashboard.StateCommon.Border.Rounding = 8F;
            kbDashboard.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            kbDashboard.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbDashboard.StateCommon.Content.ShortText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbDashboard.StateDisabled.Back.Color1 = Color.FromArgb(42, 42, 63);
            kbDashboard.StateDisabled.Border.Color1 = Color.FromArgb(42, 42, 63);
            kbDashboard.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbDashboard.StatePressed.Back.Color1 = Color.FromArgb(42, 42, 63);
            kbDashboard.StatePressed.Border.Color1 = Color.FromArgb(42, 42, 63);
            kbDashboard.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbDashboard.TabIndex = 6;
            kbDashboard.Values.Text = "Dashboard";
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
            lblLogo.Size = new Size(190, 50);
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
        private Panel pnlTitleBar;
        private Label lblTitle;
        private Label lblLogo;
        private Krypton.Toolkit.KryptonPanel kpForm;
        private Button btnNewVersion;
        private Krypton.Toolkit.KryptonButton kbDashboard;
        private Krypton.Toolkit.KryptonButton kbConsole;
        private Krypton.Toolkit.KryptonButton kbSettings;
        private Krypton.Toolkit.KryptonButton kbCompress;
    }
}