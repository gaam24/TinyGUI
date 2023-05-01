namespace TinyGUI.UI.Windows.Forms
{
    partial class SettingsForm
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
            kpAPI = new Krypton.Toolkit.KryptonPanel();
            ktbAPIKeysTitle = new Krypton.Toolkit.KryptonTextBox();
            ktbMaxRequestsPerAPI = new Krypton.Toolkit.KryptonTextBox();
            ktbAPIParserThreads = new Krypton.Toolkit.KryptonTextBox();
            ktbMaxRequestsPerAPITitle = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            ktbAPIKeys = new Krypton.Toolkit.KryptonRichTextBox();
            kpCompress = new Krypton.Toolkit.KryptonPanel();
            cbCompressPathDontSave = new CheckBox();
            ktbCompressingThreads = new Krypton.Toolkit.KryptonTextBox();
            kbCompressPathSearch = new Krypton.Toolkit.KryptonButton();
            ktbCompressNameTitle = new Krypton.Toolkit.KryptonTextBox();
            ktbCompressName = new Krypton.Toolkit.KryptonTextBox();
            ktbCompressingThreadsTitle = new Krypton.Toolkit.KryptonTextBox();
            ktbCompressPathTitle = new Krypton.Toolkit.KryptonTextBox();
            ktbCompressPath = new Krypton.Toolkit.KryptonTextBox();
            krtbCompressPath = new Krypton.Toolkit.KryptonRichTextBox();
            kbReset = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kpAPI).BeginInit();
            kpAPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kpCompress).BeginInit();
            kpCompress.SuspendLayout();
            SuspendLayout();
            // 
            // kpAPI
            // 
            kpAPI.Controls.Add(ktbAPIKeysTitle);
            kpAPI.Controls.Add(ktbMaxRequestsPerAPI);
            kpAPI.Controls.Add(ktbAPIParserThreads);
            kpAPI.Controls.Add(ktbMaxRequestsPerAPITitle);
            kpAPI.Controls.Add(kryptonTextBox1);
            kpAPI.Controls.Add(ktbAPIKeys);
            kpAPI.Location = new Point(15, 15);
            kpAPI.Margin = new Padding(15);
            kpAPI.Name = "kpAPI";
            kpAPI.Size = new Size(291, 472);
            kpAPI.StateCommon.Draw = Krypton.Toolkit.InheritBool.True;
            kpAPI.TabIndex = 5;
            // 
            // ktbAPIKeysTitle
            // 
            ktbAPIKeysTitle.Enabled = false;
            ktbAPIKeysTitle.Location = new Point(18, 3);
            ktbAPIKeysTitle.Margin = new Padding(3, 3, 3, 0);
            ktbAPIKeysTitle.Name = "ktbAPIKeysTitle";
            ktbAPIKeysTitle.ReadOnly = true;
            ktbAPIKeysTitle.Size = new Size(85, 28);
            ktbAPIKeysTitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktbAPIKeysTitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktbAPIKeysTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbAPIKeysTitle.StateCommon.Border.Rounding = 8F;
            ktbAPIKeysTitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbAPIKeysTitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktbAPIKeysTitle.TabIndex = 6;
            ktbAPIKeysTitle.Text = "API Keys";
            ktbAPIKeysTitle.TextAlign = HorizontalAlignment.Center;
            ktbAPIKeysTitle.WordWrap = false;
            // 
            // ktbMaxRequestsPerAPI
            // 
            ktbMaxRequestsPerAPI.Location = new Point(53, 399);
            ktbMaxRequestsPerAPI.Margin = new Padding(3, 0, 3, 3);
            ktbMaxRequestsPerAPI.Name = "ktbMaxRequestsPerAPI";
            ktbMaxRequestsPerAPI.Size = new Size(176, 28);
            ktbMaxRequestsPerAPI.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            ktbMaxRequestsPerAPI.StateCommon.Border.Color1 = Color.FromArgb(54, 54, 81);
            ktbMaxRequestsPerAPI.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbMaxRequestsPerAPI.StateCommon.Border.Rounding = 8F;
            ktbMaxRequestsPerAPI.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbMaxRequestsPerAPI.StateCommon.Content.Font = new Font("Signika SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            ktbMaxRequestsPerAPI.TabIndex = 9;
            ktbMaxRequestsPerAPI.Text = "10";
            ktbMaxRequestsPerAPI.TextAlign = HorizontalAlignment.Center;
            // 
            // ktbAPIParserThreads
            // 
            ktbAPIParserThreads.Location = new Point(53, 326);
            ktbAPIParserThreads.Margin = new Padding(3, 0, 3, 3);
            ktbAPIParserThreads.Name = "ktbAPIParserThreads";
            ktbAPIParserThreads.Size = new Size(176, 28);
            ktbAPIParserThreads.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            ktbAPIParserThreads.StateCommon.Border.Color1 = Color.FromArgb(54, 54, 81);
            ktbAPIParserThreads.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbAPIParserThreads.StateCommon.Border.Rounding = 8F;
            ktbAPIParserThreads.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbAPIParserThreads.StateCommon.Content.Font = new Font("Signika SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            ktbAPIParserThreads.TabIndex = 9;
            ktbAPIParserThreads.Text = "10";
            ktbAPIParserThreads.TextAlign = HorizontalAlignment.Center;
            // 
            // ktbMaxRequestsPerAPITitle
            // 
            ktbMaxRequestsPerAPITitle.Enabled = false;
            ktbMaxRequestsPerAPITitle.Location = new Point(63, 371);
            ktbMaxRequestsPerAPITitle.Margin = new Padding(3, 15, 3, 0);
            ktbMaxRequestsPerAPITitle.Name = "ktbMaxRequestsPerAPITitle";
            ktbMaxRequestsPerAPITitle.ReadOnly = true;
            ktbMaxRequestsPerAPITitle.Size = new Size(155, 28);
            ktbMaxRequestsPerAPITitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktbMaxRequestsPerAPITitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktbMaxRequestsPerAPITitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbMaxRequestsPerAPITitle.StateCommon.Border.Rounding = 8F;
            ktbMaxRequestsPerAPITitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbMaxRequestsPerAPITitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktbMaxRequestsPerAPITitle.TabIndex = 13;
            ktbMaxRequestsPerAPITitle.Text = "Max Requests Per API";
            ktbMaxRequestsPerAPITitle.TextAlign = HorizontalAlignment.Center;
            ktbMaxRequestsPerAPITitle.WordWrap = false;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Enabled = false;
            kryptonTextBox1.Location = new Point(68, 298);
            kryptonTextBox1.Margin = new Padding(3, 15, 3, 0);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.ReadOnly = true;
            kryptonTextBox1.Size = new Size(145, 28);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Rounding = 8F;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            kryptonTextBox1.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonTextBox1.TabIndex = 13;
            kryptonTextBox1.Text = "API Parser Threads";
            kryptonTextBox1.TextAlign = HorizontalAlignment.Center;
            kryptonTextBox1.WordWrap = false;
            // 
            // ktbAPIKeys
            // 
            ktbAPIKeys.AlwaysActive = false;
            ktbAPIKeys.DetectUrls = false;
            ktbAPIKeys.Location = new Point(3, 31);
            ktbAPIKeys.Margin = new Padding(3, 0, 3, 0);
            ktbAPIKeys.Name = "ktbAPIKeys";
            ktbAPIKeys.Size = new Size(285, 254);
            ktbAPIKeys.StateCommon.Back.Color1 = Color.FromArgb(42, 42, 63);
            ktbAPIKeys.StateCommon.Border.Color1 = Color.FromArgb(42, 42, 63);
            ktbAPIKeys.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbAPIKeys.StateCommon.Border.Rounding = 8F;
            ktbAPIKeys.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbAPIKeys.StateCommon.Content.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ktbAPIKeys.TabIndex = 6;
            ktbAPIKeys.Text = "kryptonRichTextBox1";
            ktbAPIKeys.WordWrap = false;
            // 
            // kpCompress
            // 
            kpCompress.Controls.Add(cbCompressPathDontSave);
            kpCompress.Controls.Add(ktbCompressingThreads);
            kpCompress.Controls.Add(kbCompressPathSearch);
            kpCompress.Controls.Add(ktbCompressNameTitle);
            kpCompress.Controls.Add(ktbCompressName);
            kpCompress.Controls.Add(ktbCompressingThreadsTitle);
            kpCompress.Controls.Add(ktbCompressPathTitle);
            kpCompress.Controls.Add(ktbCompressPath);
            kpCompress.Controls.Add(krtbCompressPath);
            kpCompress.Location = new Point(336, 15);
            kpCompress.Margin = new Padding(15, 15, 15, 0);
            kpCompress.Name = "kpCompress";
            kpCompress.Size = new Size(224, 256);
            kpCompress.TabIndex = 14;
            // 
            // cbCompressPathDontSave
            // 
            cbCompressPathDontSave.AutoSize = true;
            cbCompressPathDontSave.BackColor = Color.FromArgb(47, 47, 71);
            cbCompressPathDontSave.Enabled = false;
            cbCompressPathDontSave.ForeColor = Color.FromArgb(239, 247, 255);
            cbCompressPathDontSave.Location = new Point(114, 67);
            cbCompressPathDontSave.Name = "cbCompressPathDontSave";
            cbCompressPathDontSave.Size = new Size(82, 19);
            cbCompressPathDontSave.TabIndex = 14;
            cbCompressPathDontSave.Text = "Don't Save";
            cbCompressPathDontSave.UseVisualStyleBackColor = false;
            // 
            // ktbCompressingThreads
            // 
            ktbCompressingThreads.Location = new Point(24, 212);
            ktbCompressingThreads.Margin = new Padding(3, 0, 3, 3);
            ktbCompressingThreads.Name = "ktbCompressingThreads";
            ktbCompressingThreads.Size = new Size(176, 28);
            ktbCompressingThreads.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            ktbCompressingThreads.StateCommon.Border.Color1 = Color.FromArgb(54, 54, 81);
            ktbCompressingThreads.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCompressingThreads.StateCommon.Border.Rounding = 8F;
            ktbCompressingThreads.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbCompressingThreads.StateCommon.Content.Font = new Font("Signika SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            ktbCompressingThreads.TabIndex = 9;
            ktbCompressingThreads.Text = "10";
            ktbCompressingThreads.TextAlign = HorizontalAlignment.Center;
            // 
            // kbCompressPathSearch
            // 
            kbCompressPathSearch.CornerRoundingRadius = -1F;
            kbCompressPathSearch.Location = new Point(27, 63);
            kbCompressPathSearch.Name = "kbCompressPathSearch";
            kbCompressPathSearch.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbCompressPathSearch.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbCompressPathSearch.Size = new Size(77, 25);
            kbCompressPathSearch.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            kbCompressPathSearch.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbCompressPathSearch.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            kbCompressPathSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbCompressPathSearch.StateCommon.Content.ShortText.Color1 = Color.FromArgb(239, 247, 255);
            kbCompressPathSearch.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbCompressPathSearch.TabIndex = 14;
            kbCompressPathSearch.Values.Text = "Search";
            // 
            // ktbCompressNameTitle
            // 
            ktbCompressNameTitle.Enabled = false;
            ktbCompressNameTitle.Location = new Point(18, 112);
            ktbCompressNameTitle.Margin = new Padding(3, 15, 3, 0);
            ktbCompressNameTitle.Name = "ktbCompressNameTitle";
            ktbCompressNameTitle.ReadOnly = true;
            ktbCompressNameTitle.Size = new Size(141, 28);
            ktbCompressNameTitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktbCompressNameTitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktbCompressNameTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCompressNameTitle.StateCommon.Border.Rounding = 8F;
            ktbCompressNameTitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbCompressNameTitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktbCompressNameTitle.TabIndex = 13;
            ktbCompressNameTitle.Text = "Compressed Name";
            ktbCompressNameTitle.TextAlign = HorizontalAlignment.Center;
            ktbCompressNameTitle.WordWrap = false;
            // 
            // ktbCompressName
            // 
            ktbCompressName.Location = new Point(3, 140);
            ktbCompressName.Margin = new Padding(3, 0, 3, 0);
            ktbCompressName.Name = "ktbCompressName";
            ktbCompressName.Size = new Size(218, 29);
            ktbCompressName.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            ktbCompressName.StateCommon.Border.Color1 = Color.FromArgb(54, 54, 81);
            ktbCompressName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCompressName.StateCommon.Border.Rounding = 8F;
            ktbCompressName.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbCompressName.TabIndex = 0;
            ktbCompressName.Text = "kryptonTextBox1";
            // 
            // ktbCompressingThreadsTitle
            // 
            ktbCompressingThreadsTitle.Enabled = false;
            ktbCompressingThreadsTitle.Location = new Point(34, 184);
            ktbCompressingThreadsTitle.Margin = new Padding(3, 15, 3, 0);
            ktbCompressingThreadsTitle.Name = "ktbCompressingThreadsTitle";
            ktbCompressingThreadsTitle.ReadOnly = true;
            ktbCompressingThreadsTitle.Size = new Size(155, 28);
            ktbCompressingThreadsTitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktbCompressingThreadsTitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktbCompressingThreadsTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCompressingThreadsTitle.StateCommon.Border.Rounding = 8F;
            ktbCompressingThreadsTitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbCompressingThreadsTitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktbCompressingThreadsTitle.TabIndex = 13;
            ktbCompressingThreadsTitle.Text = "Compressing Threads";
            ktbCompressingThreadsTitle.TextAlign = HorizontalAlignment.Center;
            ktbCompressingThreadsTitle.WordWrap = false;
            // 
            // ktbCompressPathTitle
            // 
            ktbCompressPathTitle.Enabled = false;
            ktbCompressPathTitle.Location = new Point(18, 3);
            ktbCompressPathTitle.Margin = new Padding(3, 3, 3, 0);
            ktbCompressPathTitle.Name = "ktbCompressPathTitle";
            ktbCompressPathTitle.ReadOnly = true;
            ktbCompressPathTitle.Size = new Size(131, 28);
            ktbCompressPathTitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktbCompressPathTitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktbCompressPathTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCompressPathTitle.StateCommon.Border.Rounding = 8F;
            ktbCompressPathTitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbCompressPathTitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktbCompressPathTitle.TabIndex = 13;
            ktbCompressPathTitle.Text = "Compressed Path";
            ktbCompressPathTitle.TextAlign = HorizontalAlignment.Center;
            ktbCompressPathTitle.WordWrap = false;
            // 
            // ktbCompressPath
            // 
            ktbCompressPath.Location = new Point(3, 31);
            ktbCompressPath.Margin = new Padding(3, 0, 3, 0);
            ktbCompressPath.Name = "ktbCompressPath";
            ktbCompressPath.Size = new Size(218, 29);
            ktbCompressPath.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            ktbCompressPath.StateCommon.Border.Color1 = Color.FromArgb(54, 54, 81);
            ktbCompressPath.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCompressPath.StateCommon.Border.Rounding = 8F;
            ktbCompressPath.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbCompressPath.TabIndex = 0;
            ktbCompressPath.Text = "kryptonTextBox1";
            // 
            // krtbCompressPath
            // 
            krtbCompressPath.Enabled = false;
            krtbCompressPath.Location = new Point(18, 60);
            krtbCompressPath.Margin = new Padding(3, 0, 3, 3);
            krtbCompressPath.Name = "krtbCompressPath";
            krtbCompressPath.ReadOnly = true;
            krtbCompressPath.Size = new Size(188, 37);
            krtbCompressPath.StateCommon.Back.Color1 = Color.FromArgb(47, 47, 71);
            krtbCompressPath.StateCommon.Border.Color1 = Color.FromArgb(47, 47, 71);
            krtbCompressPath.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            krtbCompressPath.StateCommon.Border.Rounding = 8F;
            krtbCompressPath.TabIndex = 14;
            krtbCompressPath.Text = "";
            // 
            // kbReset
            // 
            kbReset.CornerRoundingRadius = 8F;
            kbReset.Location = new Point(550, 462);
            kbReset.Margin = new Padding(15);
            kbReset.Name = "kbReset";
            kbReset.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbReset.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbReset.Size = new Size(150, 25);
            kbReset.StateCommon.Back.Color1 = Color.FromArgb(54, 54, 81);
            kbReset.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kbReset.StateCommon.Border.Color1 = Color.FromArgb(54, 54, 81);
            kbReset.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbReset.StateCommon.Border.Rounding = 8F;
            kbReset.StateCommon.Content.ShortText.Color1 = Color.FromArgb(239, 247, 255);
            kbReset.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kbReset.TabIndex = 14;
            kbReset.Values.Text = "Reset (without API Keys)";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kpCompress);
            Controls.Add(kbReset);
            Controls.Add(kpAPI);
            Name = "SettingsForm";
            Size = new Size(715, 502);
            ((System.ComponentModel.ISupportInitialize)kpAPI).EndInit();
            kpAPI.ResumeLayout(false);
            kpAPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kpCompress).EndInit();
            kpCompress.ResumeLayout(false);
            kpCompress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kpAPI;
        private Krypton.Toolkit.KryptonRichTextBox ktbAPIKeys;
        private Krypton.Toolkit.KryptonTextBox ktbAPIParserThreads;
        private Krypton.Toolkit.KryptonTextBox ktbAPIKeysTitle;
        private Krypton.Toolkit.KryptonPanel kpCompress;
        private CheckBox cbCompressPathDontSave;
        private Krypton.Toolkit.KryptonButton kbCompressPathSearch;
        private Krypton.Toolkit.KryptonTextBox ktbCompressPathTitle;
        private Krypton.Toolkit.KryptonTextBox ktbCompressPath;
        private Krypton.Toolkit.KryptonRichTextBox krtbCompressPath;
        private Krypton.Toolkit.KryptonTextBox ktbCompressNameTitle;
        private Krypton.Toolkit.KryptonTextBox ktbCompressName;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox ktbMaxRequestsPerAPI;
        private Krypton.Toolkit.KryptonTextBox ktbMaxRequestsPerAPITitle;
        private Krypton.Toolkit.KryptonButton kbReset;
        private Krypton.Toolkit.KryptonTextBox ktbCompressingThreads;
        private Krypton.Toolkit.KryptonTextBox ktbCompressingThreadsTitle;
    }
}
