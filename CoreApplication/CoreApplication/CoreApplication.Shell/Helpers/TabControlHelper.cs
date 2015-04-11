using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using CoreApplication.Infrastructure.Interfaces;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Shell.Helpers
{
    public class CloseTabAction : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            var args = parameter as RoutedEventArgs;

            if (args == null)
                return;

            var tabItem = FrameworkElementHelper.FindVisualParent<TabItem>(args.OriginalSource as DependencyObject);
            var tabControl = FrameworkElementHelper.FindVisualParent<TabControl>(tabItem);

            if (tabItem == null || tabControl == null)
                return;

            var region = RegionManager.GetObservableRegion(tabControl).Value;

            if (region == null)
                return;

            var view = tabItem.Content;

            if (!NotifyIfImplements<ITabInfoProvider>(view,
                i => i.ConfirmCloseTabRequest(x => { if (x) region.Remove(view); })))
                region.Remove(view);
        }

        private T Implementor<T>(object content) where T : class
        {
            T output = content as T;

            if (output != null)
                return output;

            var element = content as FrameworkElement;

            return element != null ? element.DataContext as T : null;
        }

        private bool NotifyIfImplements<T>(object content, Action<T> action) where T : class
        {
            T target = Implementor<T>(content);

            if (target == null)
                return false;

            action(target);
            return true;
        }
    }
}
