using System;
using System.Windows;
using System.Windows.Controls;

namespace CoreApplication.Shell.UserControls
{
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();

            this.Loaded += Info_Loaded;

            this.ToggleRegion.Checked += ToggleRegion_Checked;
            this.ToggleRegion.Unchecked += ToggleRegion_Unchecked;

            Panel.SetZIndex(this, int.MaxValue);
        }

        public static readonly DependencyProperty RegionNameProperty =
            DependencyProperty.Register("RegionName", typeof(string), typeof(Info));

        public static readonly DependencyProperty CollapsableProperty =
            DependencyProperty.Register("Collapsable", typeof(bool), typeof(Info));

        public string RegionName
        {
            get { return (string)GetValue(RegionNameProperty); }
            set { SetValue(RegionNameProperty, value); }
        }

        public bool Collapsable
        {
            get { return (bool)GetValue(CollapsableProperty); }
            set { SetValue(CollapsableProperty, value); }
        }

        private void Info_Loaded(object sender, RoutedEventArgs e)
        {
            this.ToggleRegion.Visibility = this.Collapsable ?
                Visibility.Visible :
                Visibility.Collapsed;

            if (!double.IsNaN(this.Height))
                return;

            var parent = (Grid)this.Parent;

            if (parent != null)
            {
                try
                {
                    var row = parent.RowDefinitions[Grid.GetRow(this)];
                    var height = row.ActualHeight;

                    if (height > 0)
                        this.Height = height;
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }
        }

        private void ToggleRegion_Unchecked(object sender, RoutedEventArgs e)
        {
            this.InfoBorder.Height = this.Height;
        }

        private void ToggleRegion_Checked(object sender, RoutedEventArgs e)
        {
            this.InfoBorder.Height = double.NaN;
        }
    }
}
