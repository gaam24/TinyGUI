namespace TinyGUI.UI.Windows.Forms
{
    partial class ConsoleForm
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
            consoleBox = new Krypton.Toolkit.KryptonListBox();
            kpBackground = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kpBackground).BeginInit();
            SuspendLayout();
            // 
            // consoleBox
            // 
            consoleBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            consoleBox.Items.AddRange(new object[] { "asddasddadasdads" });
            consoleBox.Location = new Point(15, 15);
            consoleBox.Margin = new Padding(15);
            consoleBox.Name = "consoleBox";
            consoleBox.SelectionMode = SelectionMode.MultiExtended;
            consoleBox.Size = new Size(685, 472);
            consoleBox.StateCheckedNormal.Item.Back.Color1 = Color.FromArgb(128, 64, 0);
            consoleBox.StateCheckedNormal.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            consoleBox.StateCheckedNormal.Item.Border.Draw = Krypton.Toolkit.InheritBool.False;
            consoleBox.StateCheckedNormal.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            consoleBox.StateCheckedPressed.Item.Back.Color1 = Color.FromArgb(128, 64, 0);
            consoleBox.StateCheckedPressed.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            consoleBox.StateCheckedPressed.Item.Border.Draw = Krypton.Toolkit.InheritBool.False;
            consoleBox.StateCheckedPressed.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            consoleBox.StateCheckedTracking.Item.Back.Color1 = Color.FromArgb(64, 64, 64);
            consoleBox.StateCheckedTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            consoleBox.StateCheckedTracking.Item.Border.Draw = Krypton.Toolkit.InheritBool.False;
            consoleBox.StateCheckedTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            consoleBox.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            consoleBox.StateCommon.Back.Color2 = Color.Black;
            consoleBox.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear25;
            consoleBox.StateCommon.Border.Color1 = Color.FromArgb(36, 36, 36);
            consoleBox.StateCommon.Border.Color2 = Color.Black;
            consoleBox.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear25;
            consoleBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            consoleBox.StateCommon.Border.Rounding = 5F;
            consoleBox.StateCommon.Border.Width = 5;
            consoleBox.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(239, 247, 255);
            consoleBox.StateCommon.Item.Content.ShortText.Font = new Font("Fontin Sans Rg-PL", 11F, FontStyle.Bold, GraphicsUnit.Point);
            consoleBox.StateTracking.Item.Back.Color1 = Color.FromArgb(64, 64, 64);
            consoleBox.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            consoleBox.StateTracking.Item.Border.Draw = Krypton.Toolkit.InheritBool.False;
            consoleBox.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            consoleBox.TabIndex = 2;
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
            kpBackground.TabIndex = 3;
            // 
            // ConsoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(consoleBox);
            Controls.Add(kpBackground);
            Margin = new Padding(0);
            Name = "ConsoleForm";
            Size = new Size(715, 502);
            Load += ConsoleForm_Load;
            ((System.ComponentModel.ISupportInitialize)kpBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonListBox consoleBox;
        private Krypton.Toolkit.KryptonPanel kpBackground;
    }
}
