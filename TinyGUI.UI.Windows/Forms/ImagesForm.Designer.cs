namespace TinyGUI.UI.Windows.Forms
{
    partial class ImagesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlInfoSpaceSaved = new Panel();
            lblInfoSpaceSaved = new Label();
            lblInfoSpaceSavedTitle = new Label();
            pnlInfoOptimized = new Panel();
            lblInfoOptimized = new Label();
            lblInfoOptimizedTitle = new Label();
            pnlInfoFiles = new Panel();
            lblInfoFiles = new Label();
            lblInfoFilesTitle = new Label();
            kpFileDrop = new Krypton.Toolkit.KryptonPanel();
            ktbFileDropTitle = new Krypton.Toolkit.KryptonTextBox();
            klbFileDrop = new Krypton.Toolkit.KryptonListBox();
            kpInfo = new Krypton.Toolkit.KryptonPanel();
            krtbInfo = new Krypton.Toolkit.KryptonRichTextBox();
            kpbCompressProgress = new Krypton.Toolkit.KryptonProgressBar();
            kpCompress = new Krypton.Toolkit.KryptonPanel();
            lblCompressInfo = new Label();
            kbCompressRun = new Krypton.Toolkit.KryptonButton();
            ktnCompressTitle = new Krypton.Toolkit.KryptonTextBox();
            krtbCompress = new Krypton.Toolkit.KryptonRichTextBox();
            kpBackground = new Krypton.Toolkit.KryptonPanel();
            pnlInfoSpaceSaved.SuspendLayout();
            pnlInfoOptimized.SuspendLayout();
            pnlInfoFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kpFileDrop).BeginInit();
            kpFileDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kpInfo).BeginInit();
            kpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kpCompress).BeginInit();
            kpCompress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kpBackground).BeginInit();
            SuspendLayout();
            // 
            // pnlInfoSpaceSaved
            // 
            pnlInfoSpaceSaved.BackColor = Color.FromArgb(47, 47, 71);
            pnlInfoSpaceSaved.Controls.Add(lblInfoSpaceSaved);
            pnlInfoSpaceSaved.Controls.Add(lblInfoSpaceSavedTitle);
            pnlInfoSpaceSaved.Location = new Point(328, 10);
            pnlInfoSpaceSaved.Margin = new Padding(3, 10, 10, 10);
            pnlInfoSpaceSaved.Name = "pnlInfoSpaceSaved";
            pnlInfoSpaceSaved.Size = new Size(106, 54);
            pnlInfoSpaceSaved.TabIndex = 8;
            // 
            // lblInfoSpaceSaved
            // 
            lblInfoSpaceSaved.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfoSpaceSaved.BackColor = Color.PaleGreen;
            lblInfoSpaceSaved.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoSpaceSaved.Location = new Point(3, 30);
            lblInfoSpaceSaved.Margin = new Padding(3);
            lblInfoSpaceSaved.Name = "lblInfoSpaceSaved";
            lblInfoSpaceSaved.Size = new Size(100, 21);
            lblInfoSpaceSaved.TabIndex = 0;
            lblInfoSpaceSaved.Text = "{spaceSaved}";
            lblInfoSpaceSaved.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoSpaceSavedTitle
            // 
            lblInfoSpaceSavedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfoSpaceSavedTitle.BackColor = Color.MediumSeaGreen;
            lblInfoSpaceSavedTitle.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfoSpaceSavedTitle.ForeColor = Color.FromArgb(239, 247, 255);
            lblInfoSpaceSavedTitle.Location = new Point(3, 4);
            lblInfoSpaceSavedTitle.Margin = new Padding(3);
            lblInfoSpaceSavedTitle.Name = "lblInfoSpaceSavedTitle";
            lblInfoSpaceSavedTitle.Size = new Size(100, 23);
            lblInfoSpaceSavedTitle.TabIndex = 7;
            lblInfoSpaceSavedTitle.Text = "Saved Space";
            lblInfoSpaceSavedTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfoOptimized
            // 
            pnlInfoOptimized.BackColor = Color.FromArgb(47, 47, 71);
            pnlInfoOptimized.Controls.Add(lblInfoOptimized);
            pnlInfoOptimized.Controls.Add(lblInfoOptimizedTitle);
            pnlInfoOptimized.Location = new Point(166, 10);
            pnlInfoOptimized.Margin = new Padding(3, 10, 3, 10);
            pnlInfoOptimized.Name = "pnlInfoOptimized";
            pnlInfoOptimized.Size = new Size(159, 54);
            pnlInfoOptimized.TabIndex = 8;
            // 
            // lblInfoOptimized
            // 
            lblInfoOptimized.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfoOptimized.BackColor = Color.FromArgb(255, 192, 128);
            lblInfoOptimized.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoOptimized.Location = new Point(3, 30);
            lblInfoOptimized.Margin = new Padding(3);
            lblInfoOptimized.Name = "lblInfoOptimized";
            lblInfoOptimized.Size = new Size(153, 21);
            lblInfoOptimized.TabIndex = 0;
            lblInfoOptimized.Text = "{optimizedCount} [{optimizedSize}]";
            lblInfoOptimized.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoOptimizedTitle
            // 
            lblInfoOptimizedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfoOptimizedTitle.BackColor = Color.FromArgb(255, 128, 0);
            lblInfoOptimizedTitle.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfoOptimizedTitle.ForeColor = Color.FromArgb(239, 247, 255);
            lblInfoOptimizedTitle.Location = new Point(3, 4);
            lblInfoOptimizedTitle.Margin = new Padding(3);
            lblInfoOptimizedTitle.Name = "lblInfoOptimizedTitle";
            lblInfoOptimizedTitle.Size = new Size(153, 23);
            lblInfoOptimizedTitle.TabIndex = 7;
            lblInfoOptimizedTitle.Text = "Optimized";
            lblInfoOptimizedTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfoFiles
            // 
            pnlInfoFiles.BackColor = Color.FromArgb(47, 47, 71);
            pnlInfoFiles.Controls.Add(lblInfoFiles);
            pnlInfoFiles.Controls.Add(lblInfoFilesTitle);
            pnlInfoFiles.Location = new Point(10, 10);
            pnlInfoFiles.Margin = new Padding(10, 10, 3, 10);
            pnlInfoFiles.Name = "pnlInfoFiles";
            pnlInfoFiles.Size = new Size(153, 54);
            pnlInfoFiles.TabIndex = 8;
            // 
            // lblInfoFiles
            // 
            lblInfoFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfoFiles.BackColor = Color.FromArgb(255, 128, 128);
            lblInfoFiles.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoFiles.Location = new Point(3, 29);
            lblInfoFiles.Margin = new Padding(3);
            lblInfoFiles.Name = "lblInfoFiles";
            lblInfoFiles.Size = new Size(147, 21);
            lblInfoFiles.TabIndex = 0;
            lblInfoFiles.Text = "{filesCount} [{filesSize}]";
            lblInfoFiles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoFilesTitle
            // 
            lblInfoFilesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfoFilesTitle.BackColor = Color.Red;
            lblInfoFilesTitle.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfoFilesTitle.ForeColor = Color.FromArgb(239, 247, 255);
            lblInfoFilesTitle.Location = new Point(3, 4);
            lblInfoFilesTitle.Margin = new Padding(3);
            lblInfoFilesTitle.Name = "lblInfoFilesTitle";
            lblInfoFilesTitle.Size = new Size(147, 23);
            lblInfoFilesTitle.TabIndex = 7;
            lblInfoFilesTitle.Text = "Files";
            lblInfoFilesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kpFileDrop
            // 
            kpFileDrop.Controls.Add(ktbFileDropTitle);
            kpFileDrop.Controls.Add(klbFileDrop);
            kpFileDrop.Location = new Point(15, 15);
            kpFileDrop.Margin = new Padding(15, 15, 15, 0);
            kpFileDrop.Name = "kpFileDrop";
            kpFileDrop.Size = new Size(444, 403);
            kpFileDrop.StateCommon.Draw = Krypton.Toolkit.InheritBool.True;
            kpFileDrop.TabIndex = 12;
            // 
            // ktbFileDropTitle
            // 
            ktbFileDropTitle.Enabled = false;
            ktbFileDropTitle.Location = new Point(20, 3);
            ktbFileDropTitle.Margin = new Padding(3, 3, 3, 0);
            ktbFileDropTitle.Name = "ktbFileDropTitle";
            ktbFileDropTitle.ReadOnly = true;
            ktbFileDropTitle.Size = new Size(65, 28);
            ktbFileDropTitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktbFileDropTitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktbFileDropTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbFileDropTitle.StateCommon.Border.Rounding = 8F;
            ktbFileDropTitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbFileDropTitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktbFileDropTitle.TabIndex = 13;
            ktbFileDropTitle.Text = "Images";
            ktbFileDropTitle.TextAlign = HorizontalAlignment.Center;
            ktbFileDropTitle.WordWrap = false;
            // 
            // klbFileDrop
            // 
            klbFileDrop.AllowDrop = true;
            klbFileDrop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            klbFileDrop.Items.AddRange(new object[] { "test", "test", "test" });
            klbFileDrop.Location = new Point(3, 31);
            klbFileDrop.Margin = new Padding(3, 0, 3, 3);
            klbFileDrop.Name = "klbFileDrop";
            klbFileDrop.SelectionMode = SelectionMode.MultiExtended;
            klbFileDrop.Size = new Size(438, 369);
            klbFileDrop.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            klbFileDrop.StateCommon.Border.Color1 = Color.FromArgb(54, 54, 81);
            klbFileDrop.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            klbFileDrop.StateCommon.Border.Rounding = 8F;
            klbFileDrop.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(239, 247, 255);
            klbFileDrop.TabIndex = 0;
            // 
            // kpInfo
            // 
            kpInfo.Controls.Add(pnlInfoSpaceSaved);
            kpInfo.Controls.Add(pnlInfoFiles);
            kpInfo.Controls.Add(pnlInfoOptimized);
            kpInfo.Controls.Add(krtbInfo);
            kpInfo.Location = new Point(15, 423);
            kpInfo.Margin = new Padding(0, 5, 15, 5);
            kpInfo.Name = "kpInfo";
            kpInfo.Size = new Size(444, 74);
            kpInfo.TabIndex = 14;
            // 
            // krtbInfo
            // 
            krtbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            krtbInfo.Enabled = false;
            krtbInfo.Location = new Point(2, 3);
            krtbInfo.Name = "krtbInfo";
            krtbInfo.ReadOnly = true;
            krtbInfo.Size = new Size(441, 68);
            krtbInfo.StateCommon.Back.Color1 = Color.FromArgb(47, 47, 71);
            krtbInfo.StateCommon.Border.Color1 = Color.FromArgb(47, 47, 71);
            krtbInfo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            krtbInfo.StateCommon.Border.Rounding = 8F;
            krtbInfo.TabIndex = 14;
            krtbInfo.Text = "";
            // 
            // kpbCompressProgress
            // 
            kpbCompressProgress.BackColor = Color.IndianRed;
            kpbCompressProgress.Location = new Point(73, 64);
            kpbCompressProgress.MarqueeAnimationSpeed = 80;
            kpbCompressProgress.Name = "kpbCompressProgress";
            kpbCompressProgress.Size = new Size(139, 23);
            kpbCompressProgress.Step = 1;
            kpbCompressProgress.Style = ProgressBarStyle.Continuous;
            kpbCompressProgress.TabIndex = 15;
            kpbCompressProgress.UseKrypton = true;
            // 
            // kpCompress
            // 
            kpCompress.Controls.Add(lblCompressInfo);
            kpCompress.Controls.Add(kpbCompressProgress);
            kpCompress.Controls.Add(kbCompressRun);
            kpCompress.Controls.Add(ktnCompressTitle);
            kpCompress.Controls.Add(krtbCompress);
            kpCompress.Location = new Point(476, 348);
            kpCompress.Margin = new Padding(0, 15, 15, 50);
            kpCompress.Name = "kpCompress";
            kpCompress.Size = new Size(224, 104);
            kpCompress.TabIndex = 16;
            // 
            // lblCompressInfo
            // 
            lblCompressInfo.BackColor = Color.FromArgb(47, 47, 71);
            lblCompressInfo.FlatStyle = FlatStyle.Flat;
            lblCompressInfo.Font = new Font("Signika SemiBold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompressInfo.ForeColor = Color.FromArgb(239, 247, 255);
            lblCompressInfo.Location = new Point(12, 37);
            lblCompressInfo.Name = "lblCompressInfo";
            lblCompressInfo.Size = new Size(200, 23);
            lblCompressInfo.TabIndex = 17;
            lblCompressInfo.Text = "({percent}) {elapsed}/{eta}";
            lblCompressInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kbCompressRun
            // 
            kbCompressRun.CornerRoundingRadius = -1F;
            kbCompressRun.Location = new Point(12, 63);
            kbCompressRun.Name = "kbCompressRun";
            kbCompressRun.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbCompressRun.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbCompressRun.Size = new Size(55, 25);
            kbCompressRun.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            kbCompressRun.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbCompressRun.StateCommon.Content.ShortText.Color1 = Color.FromArgb(239, 247, 255);
            kbCompressRun.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbCompressRun.TabIndex = 14;
            kbCompressRun.Values.Text = "Run";
            // 
            // ktnCompressTitle
            // 
            ktnCompressTitle.Enabled = false;
            ktnCompressTitle.Location = new Point(18, 3);
            ktnCompressTitle.Margin = new Padding(3, 3, 3, 0);
            ktnCompressTitle.Name = "ktnCompressTitle";
            ktnCompressTitle.ReadOnly = true;
            ktnCompressTitle.Size = new Size(86, 28);
            ktnCompressTitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktnCompressTitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktnCompressTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktnCompressTitle.StateCommon.Border.Rounding = 8F;
            ktnCompressTitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktnCompressTitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktnCompressTitle.TabIndex = 13;
            ktnCompressTitle.Text = "Compress";
            ktnCompressTitle.TextAlign = HorizontalAlignment.Center;
            ktnCompressTitle.WordWrap = false;
            // 
            // krtbCompress
            // 
            krtbCompress.Enabled = false;
            krtbCompress.Location = new Point(3, 31);
            krtbCompress.Margin = new Padding(3, 0, 3, 3);
            krtbCompress.Name = "krtbCompress";
            krtbCompress.ReadOnly = true;
            krtbCompress.Size = new Size(218, 69);
            krtbCompress.StateCommon.Back.Color1 = Color.FromArgb(47, 47, 71);
            krtbCompress.StateCommon.Border.Color1 = Color.FromArgb(47, 47, 71);
            krtbCompress.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            krtbCompress.StateCommon.Border.Rounding = 8F;
            krtbCompress.TabIndex = 14;
            krtbCompress.Text = "";
            // 
            // kpBackground
            // 
            kpBackground.Dock = DockStyle.Fill;
            kpBackground.Location = new Point(0, 0);
            kpBackground.Margin = new Padding(0);
            kpBackground.Name = "kpBackground";
            kpBackground.Size = new Size(715, 502);
            kpBackground.StateCommon.Color1 = Color.FromArgb(76, 76, 114);
            kpBackground.StateCommon.Color2 = Color.FromArgb(90, 81, 121);
            kpBackground.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear33;
            kpBackground.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            kpBackground.TabIndex = 17;
            // 
            // ImagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kpCompress);
            Controls.Add(kpInfo);
            Controls.Add(kpFileDrop);
            Controls.Add(kpBackground);
            Name = "ImagesForm";
            Size = new Size(715, 502);
            Load += CompressForm_Load;
            pnlInfoSpaceSaved.ResumeLayout(false);
            pnlInfoOptimized.ResumeLayout(false);
            pnlInfoFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kpFileDrop).EndInit();
            kpFileDrop.ResumeLayout(false);
            kpFileDrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kpInfo).EndInit();
            kpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kpCompress).EndInit();
            kpCompress.ResumeLayout(false);
            kpCompress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kpBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInfoFiles;
        private Label lblInfoFiles;
        private Label lblInfoFilesTitle;
        private Panel pnlInfoSpaceSaved;
        private Label lblInfoSpaceSaved;
        private Label lblInfoSpaceSavedTitle;
        private Panel pnlInfoOptimized;
        private Label lblInfoOptimized;
        private Label lblInfoOptimizedTitle;
        private Krypton.Toolkit.KryptonPanel kpFileDrop;
        private Krypton.Toolkit.KryptonListBox klbFileDrop;
        private Krypton.Toolkit.KryptonTextBox ktbFileDropTitle;
        private Krypton.Toolkit.KryptonPanel kpInfo;
        private Krypton.Toolkit.KryptonRichTextBox krtbInfo;
        private Krypton.Toolkit.KryptonProgressBar kpbCompressProgress;
        private Krypton.Toolkit.KryptonPanel kpCompress;
        private Krypton.Toolkit.KryptonTextBox ktnCompressTitle;
        private Krypton.Toolkit.KryptonRichTextBox krtbCompress;
        private Krypton.Toolkit.KryptonButton kbCompressRun;
        private Label lblCompressInfo;
        private Krypton.Toolkit.KryptonPanel kpBackground;
    }
}
