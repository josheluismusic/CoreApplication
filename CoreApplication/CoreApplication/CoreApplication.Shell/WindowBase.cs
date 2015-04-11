using System;
using System.Windows;
using System.Windows.Interop;

namespace CoreApplication.Shell
{
    public class WindowBase : Window
    {
        public WindowBase()
        {
            this.Loaded += WindowBase_Loaded;
        }

        private void WindowBase_Loaded(object sender, RoutedEventArgs e)
        {
            var window = HwndSource.FromHwnd(new WindowInteropHelper(this).Handle);
            window.AddHook(new HwndSourceHook(HandleWin32Messages));
        }

        private IntPtr HandleWin32Messages(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            // Listado de códigos:
            // http://www.pinvoke.net/default.aspx/Constants/WM.html
            // http://www.autoitscript.com/autoit3/docs/appendix/WinMsgCodes.htm

            if (this.IsActive && ((msg >= 0x0200 && msg <= 0x020A) || (msg >= 0x00A0 && msg <= 0x0106) || msg == 0x0021))
                ((App)Application.Current).ResetSessionTimeOut();

            return IntPtr.Zero;
        }
    }
}
