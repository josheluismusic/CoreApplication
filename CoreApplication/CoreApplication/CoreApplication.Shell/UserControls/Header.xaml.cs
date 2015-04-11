using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CoreApplication.Shell.Helpers;
using CoreApplication.Shell.ViewModels;
using Microsoft.Practices.Prism.Commands;

namespace CoreApplication.Shell.UserControls
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();

            this.Loaded += Header_Loaded;

            this.SearchMenu.SubmenuOpened += SearchMenu_SubmenuOpened;
            this.SearchMenu.SubmenuClosed += SearchMenu_SubmenuClosed;

            this.Query.PreviewKeyDown += Query_PreviewKeyDown;
            this.Query.KeyUp += Query_KeyUp;
            this.Results.SubmenuClosed += Results_SubmenuClosed;
        }

        public static DependencyProperty MainMenuProperty =
            DependencyProperty.Register("MainMenu", typeof(IList<MenuItemViewModel>), typeof(Header));

        public static DependencyProperty StatsMenuProperty =
            DependencyProperty.Register("StatsMenu", typeof(IList<MenuItemViewModel>), typeof(Header));

        public static DependencyProperty ConfigMenuProperty =
            DependencyProperty.Register("ConfigMenu", typeof(IList<MenuItemViewModel>), typeof(Header));

        public static DependencyProperty HelpMenuProperty =
            DependencyProperty.Register("HelpMenu", typeof(IList<MenuItemViewModel>), typeof(Header));

        public IList<MenuItemViewModel> MainMenu
        {
            get { return (IList<MenuItemViewModel>)GetValue(MainMenuProperty); }
            set { SetValue(MainMenuProperty, value); }
        }

        public IList<MenuItemViewModel> StatsMenu
        {
            get { return (IList<MenuItemViewModel>)GetValue(StatsMenuProperty); }
            set { SetValue(StatsMenuProperty, value); }
        }

        public IList<MenuItemViewModel> ConfigMenu
        {
            get { return (IList<MenuItemViewModel>)GetValue(ConfigMenuProperty); }
            set { SetValue(ConfigMenuProperty, value); }
        }

        public IList<MenuItemViewModel> HelpMenu
        {
            get { return (IList<MenuItemViewModel>)GetValue(HelpMenuProperty); }
            set { SetValue(HelpMenuProperty, value); }
        }

        public void ShowSearch()
        {
            this.SearchMenu.IsSubmenuOpen = true;
            this.Query.Focus();
        }

        private void Search()
        {
            var query = this.Query.Text.ToLowerInvariant();

            if (string.IsNullOrWhiteSpace(query))
            {
                this.Results.ItemsSource = null;
                return;
            }

            var source = new List<MenuItemViewModel>();

            source.AddRange(this.MainMenu.Enum().Transverse(mi => mi.SubMenuItems));
            source.AddRange(this.StatsMenu.Enum().Transverse(mi => mi.SubMenuItems));
            source.AddRange(this.ConfigMenu.Enum().Transverse(mi => mi.SubMenuItems));
            source.AddRange(this.HelpMenu.Enum().Transverse(mi => mi.SubMenuItems));

            var results = source.Where(m => 
                m.SubMenuItems.Enum().Count() == 0 && 
                m.Title.ToLowerInvariant().Contains(query));

            this.Results.ItemsSource = results.OrderBy(r => r.Title);
            this.Results.IsSubmenuOpen = true;
        }

        private void Reset()
        {
            this.Query.Text = null;
            this.Results.ItemsSource = null;
        }

        private void Header_Loaded(object sender, RoutedEventArgs e)
        {
            var window = FrameworkElementHelper.GetWindow((FrameworkElement)this);

            if (window != null)
            {
                var command = new DelegateCommand(new Action(() => { this.ShowSearch(); }));
                var keyGesture =new KeyGesture(Key.Space, ModifierKeys.Control);

                window.InputBindings.Add(new InputBinding(command, keyGesture));
            }
        }

        private void SearchMenu_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            // TODO: no funciona
            this.Query.Focus();
        }

        private void SearchMenu_SubmenuClosed(object sender, RoutedEventArgs e)
        {
            if (!this.SearchMenu.IsSubmenuOpen)
                Reset();
        }

        private void Query_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
                this.Results.Focus();
        }

        private void Query_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Escape)
                Search();

            base.OnKeyUp(e);
        }

        private void Results_SubmenuClosed(object sender, RoutedEventArgs e)
        {
            this.Query.Focus();
        }
    }
}
