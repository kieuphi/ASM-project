using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.View.RoomMapv2
{
    public static class SuspendUpdate
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendTN(this Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeTN(this Control parent, int duration = 0)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            if (duration > 0)
            {
                System.Threading.Thread.Sleep(duration);
            }
            parent.Refresh();
        }



        #region Suspend

        public static IDisposable BeginSuspendlock(this Control ctrl)
        {
            return new suspender(ctrl);
        }

        private class suspender : IDisposable
        {
            private Control _ctrl;
            public suspender(Control ctrl)
            {
                this._ctrl = ctrl;
                SendMessage(this._ctrl.Handle, WM_SETREDRAW, false, 0);
            }
            public void Dispose()
            {
                SendMessage(this._ctrl.Handle, WM_SETREDRAW, true, 0);
                this._ctrl.Refresh();
            }
        }
        #endregion


    }
}
