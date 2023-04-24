﻿using System.Globalization;
using TinyGUI.UI.Windows.Data;
using TinyGUI.UI.Windows.Events;

namespace TinyGUI.UI.Windows
{
    internal sealed class MenuManager
    {
        private readonly List<MenuButton> menuButtons = new();
        private readonly List<string> forceLoadList = new();

        private string? defaultMenuTitle;

        private readonly Label titleLabel;
        private readonly Panel titlePanel;

        private readonly Panel formPanel;
        private readonly Panel navigationPanel;

        public MenuManager(Label titleLabel, Panel titlePanel, Panel formPanel, Panel navigationPanel)
        {
            this.titleLabel = titleLabel;
            this.titlePanel = titlePanel;

            this.formPanel = formPanel;
            this.navigationPanel = navigationPanel;
        }

        public void AddButton(string title, Button button, UserControl control)
        {
            control.BackColor = Color.Transparent;

            menuButtons.Add(new MenuButton(title, button, control));
        }

        public void AddForceLoad(string title)
        {
            forceLoadList.Add(title);
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
                menuButton.Button.Click += (sender, e) => ButtonClickEvent(new MenuButtonClickEventArgs(menuButton));

                if (forceLoadList.Contains(menuButton.Title))
                {
                    formPanel.Controls.Add(menuButton.UserControl);
                }
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
            Button button = menuButton.Button;

            // Set title
            titleLabel.Text = menuButton.Title.ToUpper(CultureInfo.InvariantCulture);
            titleLabel.Location = new Point(titlePanel.Width / 2 - titleLabel.Width / 2, titlePanel.Height / 2 - titleLabel.Height / 2);

            // Set button navigation.
            navigationPanel.Height = button.Height - 20;
            navigationPanel.Top = button.Top + 10;
            navigationPanel.Left = button.Left;

            // Set UserControl
            formPanel.Controls.Clear();
            formPanel.Controls.Add(menuButton.UserControl);
        }
    }
}