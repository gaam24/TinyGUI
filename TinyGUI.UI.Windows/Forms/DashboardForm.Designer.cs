namespace TinyGUI.UI.Windows.Forms
{
    partial class DashboardForm
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
            klbCompressedCount = new Krypton.Toolkit.KryptonListBox();
            ktbAPICompressedCountTitle = new Krypton.Toolkit.KryptonTextBox();
            kpCompressedCount = new Krypton.Toolkit.KryptonPanel();
            kpCompressedImages = new Krypton.Toolkit.KryptonPanel();
            ktbCompressedImagesTitle = new Krypton.Toolkit.KryptonTextBox();
            klbCompressedImages = new Krypton.Toolkit.KryptonListBox();
            kpBackground = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kpCompressedCount).BeginInit();
            kpCompressedCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kpCompressedImages).BeginInit();
            kpCompressedImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kpBackground).BeginInit();
            SuspendLayout();
            // 
            // klbCompressedCount
            // 
            klbCompressedCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            klbCompressedCount.Items.AddRange(new object[] { "asdasdasdasd", "asdasdasdasdads" });
            klbCompressedCount.Location = new Point(3, 29);
            klbCompressedCount.Margin = new Padding(3, 0, 3, 3);
            klbCompressedCount.Name = "klbCompressedCount";
            klbCompressedCount.SelectionMode = SelectionMode.MultiExtended;
            klbCompressedCount.Size = new Size(246, 440);
            klbCompressedCount.StateCheckedNormal.Item.Back.Draw = Krypton.Toolkit.InheritBool.False;
            klbCompressedCount.StateCheckedTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.False;
            klbCompressedCount.StateCommon.Back.Color1 = Color.FromArgb(42, 42, 63);
            klbCompressedCount.StateCommon.Border.Color1 = Color.FromArgb(42, 42, 63);
            klbCompressedCount.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            klbCompressedCount.StateCommon.Border.Rounding = 15F;
            klbCompressedCount.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(239, 247, 255);
            klbCompressedCount.StateCommon.Item.Content.ShortText.Font = new Font("Signika SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            klbCompressedCount.StateTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.False;
            klbCompressedCount.TabIndex = 1;
            // 
            // ktbAPICompressedCountTitle
            // 
            ktbAPICompressedCountTitle.Enabled = false;
            ktbAPICompressedCountTitle.Location = new Point(18, 3);
            ktbAPICompressedCountTitle.Margin = new Padding(3, 3, 3, 0);
            ktbAPICompressedCountTitle.Name = "ktbAPICompressedCountTitle";
            ktbAPICompressedCountTitle.ReadOnly = true;
            ktbAPICompressedCountTitle.Size = new Size(169, 28);
            ktbAPICompressedCountTitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktbAPICompressedCountTitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktbAPICompressedCountTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbAPICompressedCountTitle.StateCommon.Border.Rounding = 8F;
            ktbAPICompressedCountTitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbAPICompressedCountTitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktbAPICompressedCountTitle.TabIndex = 7;
            ktbAPICompressedCountTitle.Text = "API Compressed Count";
            ktbAPICompressedCountTitle.TextAlign = HorizontalAlignment.Center;
            ktbAPICompressedCountTitle.WordWrap = false;
            // 
            // kpCompressedCount
            // 
            kpCompressedCount.Controls.Add(ktbAPICompressedCountTitle);
            kpCompressedCount.Controls.Add(klbCompressedCount);
            kpCompressedCount.Location = new Point(15, 15);
            kpCompressedCount.Margin = new Padding(15);
            kpCompressedCount.Name = "kpCompressedCount";
            kpCompressedCount.Size = new Size(252, 472);
            kpCompressedCount.TabIndex = 8;
            // 
            // kpCompressedImages
            // 
            kpCompressedImages.Controls.Add(ktbCompressedImagesTitle);
            kpCompressedImages.Controls.Add(klbCompressedImages);
            kpCompressedImages.Location = new Point(297, 15);
            kpCompressedImages.Margin = new Padding(15);
            kpCompressedImages.Name = "kpCompressedImages";
            kpCompressedImages.Size = new Size(252, 67);
            kpCompressedImages.TabIndex = 8;
            // 
            // ktbCompressedImagesTitle
            // 
            ktbCompressedImagesTitle.Enabled = false;
            ktbCompressedImagesTitle.Location = new Point(18, 3);
            ktbCompressedImagesTitle.Margin = new Padding(3, 3, 3, 0);
            ktbCompressedImagesTitle.Name = "ktbCompressedImagesTitle";
            ktbCompressedImagesTitle.ReadOnly = true;
            ktbCompressedImagesTitle.Size = new Size(134, 28);
            ktbCompressedImagesTitle.StateCommon.Back.Color1 = Color.FromArgb(38, 38, 57);
            ktbCompressedImagesTitle.StateCommon.Border.Color1 = Color.FromArgb(38, 38, 57);
            ktbCompressedImagesTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCompressedImagesTitle.StateCommon.Border.Rounding = 8F;
            ktbCompressedImagesTitle.StateCommon.Content.Color1 = Color.FromArgb(239, 247, 255);
            ktbCompressedImagesTitle.StateCommon.Content.Font = new Font("Roboto Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ktbCompressedImagesTitle.TabIndex = 7;
            ktbCompressedImagesTitle.Text = "Compress Images";
            ktbCompressedImagesTitle.TextAlign = HorizontalAlignment.Center;
            ktbCompressedImagesTitle.WordWrap = false;
            // 
            // klbCompressedImages
            // 
            klbCompressedImages.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            klbCompressedImages.Items.AddRange(new object[] { "asdasdasdasd" });
            klbCompressedImages.Location = new Point(0, 31);
            klbCompressedImages.Margin = new Padding(3, 0, 3, 3);
            klbCompressedImages.Name = "klbCompressedImages";
            klbCompressedImages.Size = new Size(246, 32);
            klbCompressedImages.StateCheckedNormal.Item.Back.Draw = Krypton.Toolkit.InheritBool.False;
            klbCompressedImages.StateCheckedTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.False;
            klbCompressedImages.StateCommon.Back.Color1 = Color.FromArgb(42, 42, 63);
            klbCompressedImages.StateCommon.Border.Color1 = Color.FromArgb(42, 42, 63);
            klbCompressedImages.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            klbCompressedImages.StateCommon.Border.Rounding = 15F;
            klbCompressedImages.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(239, 247, 255);
            klbCompressedImages.StateCommon.Item.Content.ShortText.Font = new Font("Signika SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            klbCompressedImages.StateTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.False;
            klbCompressedImages.TabIndex = 1;
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
            kpBackground.TabIndex = 9;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kpCompressedImages);
            Controls.Add(kpCompressedCount);
            Controls.Add(kpBackground);
            Name = "DashboardForm";
            Size = new Size(715, 502);
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)kpCompressedCount).EndInit();
            kpCompressedCount.ResumeLayout(false);
            kpCompressedCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kpCompressedImages).EndInit();
            kpCompressedImages.ResumeLayout(false);
            kpCompressedImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kpBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonListBox klbCompressedCount;
        private Krypton.Toolkit.KryptonTextBox ktbAPICompressedCountTitle;
        private Krypton.Toolkit.KryptonPanel kpCompressedCount;
        private Krypton.Toolkit.KryptonPanel kpCompressedImages;
        private Krypton.Toolkit.KryptonTextBox ktbCompressedImagesTitle;
        private Krypton.Toolkit.KryptonListBox klbCompressedImages;
        private Krypton.Toolkit.KryptonPanel kpBackground;
    }
}
