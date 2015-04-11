using CoreApplication.Common.Security;
using System;
using System.Timers;
using System.Windows.Interop;

namespace CoreApplication.Shell.Helpers
{
    public class AutoLogoffHelper
    {
        private Timer timer;

        public delegate void LogoffDelegate();
        public event LogoffDelegate LogoffEvent;

        public AutoLogoffHelper(LogoffDelegate logoffDelegate)
        {
            this.LogoffEvent += logoffDelegate;
        }

        public void Start()
        {
            ComponentDispatcher.ThreadIdle += new EventHandler(DispatcherQueueEmptyHandler);
        }

        public void Reset()
        {
            if (this.timer != null)
            {
                this.timer.Enabled = false;
                this.timer.Enabled = true;
            }
        }

        private void DispatcherQueueEmptyHandler(object sender, EventArgs e)
        {
            if (this.timer == null)
            {
                this.timer = new Timer();
                this.timer.Interval = 100 * 1000;// SecurityManager.CurrentUser.SessionTimeoutSeconds;
                this.timer.Elapsed += timer_Elapsed;
                this.timer.Enabled = true;
            }
            else if (!timer.Enabled)
                this.timer.Enabled = true;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.timer != null)
            {
                ComponentDispatcher.ThreadIdle -= new EventHandler(DispatcherQueueEmptyHandler);
                this.timer.Stop();
                this.timer = null;

                if (LogoffEvent != null)
                    LogoffEvent();
            }
        }
    }
}
