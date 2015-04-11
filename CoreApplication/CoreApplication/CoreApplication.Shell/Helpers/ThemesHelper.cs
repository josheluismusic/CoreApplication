using System;
using System.Linq;
using System.Windows;

namespace CoreApplication.Shell.Helpers
{
    public static class ThemesHelper
    {
        public static void SetTheme(Theme theme)
        {
            var themes = Application.Current.Resources.MergedDictionaries
                .Where(d => d.Source.OriginalString.StartsWith("/Themes/"));

            foreach (var t in themes)
                Application.Current.Resources.MergedDictionaries.Remove(t);

            Application.Current.Resources.MergedDictionaries.Add(GetTheme(theme));
        }

        private static ResourceDictionary GetTheme(Theme theme)
        {
            var output = new ResourceDictionary();

            switch (theme)
            {
                case Theme.Ambulatorio:
                    output.Source = new Uri("/Themes/AmbulatorioTheme.xaml", UriKind.Relative);
                    break;
                case Theme.Corporativo:
                    output.Source = new Uri("/Themes/CorporativoTheme.xaml", UriKind.Relative);
                    break;
                case Theme.Hospitalizado:
                    output.Source = new Uri("/Themes/HospitalarioTheme.xaml", UriKind.Relative);
                    break;
                case Theme.Urgencia:
                    output.Source = new Uri("/Themes/UrgenciaTheme.xaml", UriKind.Relative);
                    break;
            }

            return output;
        }
    }

    public enum Theme
    {
        Ambulatorio,
        Corporativo,
        Hospitalizado,
        Urgencia
    }
}
