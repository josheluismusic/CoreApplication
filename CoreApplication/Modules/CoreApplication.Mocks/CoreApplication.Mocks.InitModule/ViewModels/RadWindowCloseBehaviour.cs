using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace CoreApplication.Mocks.InitModule.ViewModels
{
    public static class RadWindowCloseBehaviour
    {
        public static void SetDialogResult(RadWindow radWindow, bool? value)
        {
            if (radWindow != null)
            {
                radWindow.SetValue(RadWindow.DialogResultProperty, value);
                if (value != null) radWindow.Close();
            }
        }

        public static bool? GetDialogResult(RadWindow radWindow)
        {
            if (radWindow != null)
            {
                return radWindow.GetValue(BindableDialogResultProperty) as bool?;
            }
            return null;
        }

        public static readonly DependencyProperty BindableDialogResultProperty = DependencyProperty.RegisterAttached("DialogResult", typeof(bool?), typeof(RadWindowCloseBehaviour), new PropertyMetadata(BindableDialogResultPropertyChanged));

        private static void BindableDialogResultPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SetDialogResult(d as RadWindow, e.NewValue as bool?);
        }
    }
}
