using System.Windows;
using System.Windows.Media;

namespace CoreApplication.Shell.Helpers
{
    public static class FrameworkElementHelper
    {
        public static Window GetWindow(FrameworkElement element)
        {
            while (element.Parent != null)
            {
                if (element.Parent is Window)
                    return (Window)element.Parent;

                element = element.Parent as FrameworkElement;
            }

            return null;
        }

        public static T FindVisualParent<T>(DependencyObject node) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(node);

            if (parent == null || parent is T)
                return (T)parent;

            return FindVisualParent<T>(parent);
        }
    }
}
