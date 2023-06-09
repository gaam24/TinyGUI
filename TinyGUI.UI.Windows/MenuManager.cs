﻿using Krypton.Toolkit;
using System.Globalization;
using TinyGUI.UI.Windows.Data;
using TinyGUI.UI.Windows.Events;

namespace TinyGUI.UI.Windows
{
    internal sealed class MenuManager
    {
        private readonly List<MenuButton> menuButtons = new();
        private string? defaultMenuTitle;

        private readonly Label titleLabel;
        private readonly KryptonPanel formPanel;

        private KryptonButton? oldButton;

        public MenuManager(Label titleLabel, KryptonPanel formPanel)
        {
            this.titleLabel = titleLabel;
            this.formPanel = formPanel;

            this.formPanel.SizeChanged += FormPanel_SizeChanged;
        }

        public void AddButton(string title, KryptonButton button, UserControl control)
        {
            control.BackColor = Color.Transparent;

            menuButtons.Add(new MenuButton(title, button, control));
        }

        public void SetDefaultMenu(string title)
        {
            defaultMenuTitle = title;
        }

        public void Register()
        {
            if (menuButtons == null || menuButtons.Count == 0) return;

            MenuButton? defaultMenu = menuButtons.FirstOrDefault(mb => mb.Title.Equals(defaultMenuTitle, StringComparison.Ordinal));
            menuButtons.ForEach(menuButton =>
            {
                menuButton.Button.Text = menuButton.Title;
                menuButton.Button.Click += (sender, e) => ButtonClickEvent(new MenuButtonClickEventArgs(menuButton));

                // Force Load
                formPanel.Controls.Add(menuButton.UserControl);
            });
            formPanel.Controls.Clear();

            if (defaultMenu != null)
            {
                ButtonClickEvent(new MenuButtonClickEventArgs(defaultMenu));
            }
        }

        private void ButtonClickEvent(MenuButtonClickEventArgs e)
        {
            MenuButton menuButton = e.MenuButton;
            KryptonButton button = menuButton.Button;

            // Set title
            titleLabel.Text = menuButton.Title.ToUpper(CultureInfo.InvariantCulture);

            // Disable button and enable previous.
            button.Enabled = false;
            if (oldButton != null)
            {
                oldButton.Enabled = true;
            }
            oldButton = button;

            // Change size to from size
            menuButton.UserControl.Size = formPanel.Size;

            // Set UserControl
            formPanel.Controls.Clear();
            formPanel.Controls.Add(menuButton.UserControl);
        }

        private void FormPanel_SizeChanged(object? sender, EventArgs e)
        {
            if (formPanel.Controls.Count > 0)
            {
                formPanel.Controls[0].Size = formPanel.Size;
            }
        }
    }
}