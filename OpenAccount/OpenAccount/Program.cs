using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace OpenAccount
{
    class Program
    {
        private const int SW_SHOWNORMAL = 1;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWNOACTIVATE = 4;
        //SendMessage参数
        private const int WM_KEYDOWN = 0X100;
        private const int WM_KEYUP = 0X101;
        private const int WM_SYSCHAR = 0X106;
        private const int WM_SYSKEYUP = 0X105;
        private const int WM_SYSKEYDOWN = 0X104;
        private const int WM_CHAR = 0X102;


        [DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string classname, string captionName);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindowEx(IntPtr parent, IntPtr child, string classname, string captionName);

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, Point Point);

        static IntPtr InputMessage(IntPtr hWnd, string msg)
        {
            foreach(var c in msg)
            {
                SendMessage(hWnd, WM_CHAR, c, null);
            }
            return hWnd;
        }

        static void Main(string[] args)
        {
            var main_window = FindWindow(null, "HSClient - [现金存取]");
            var mdi_window = FindWindowEx(main_window, IntPtr.Zero, "MDIClient", null);
            var tmp_window = FindWindowEx(mdi_window, IntPtr.Zero, null, null);
            tmp_window = FindWindowEx(tmp_window, IntPtr.Zero, null, null);
            var panel = FindWindowEx(tmp_window, IntPtr.Zero, null, null);
            var account_edit = FindWindowEx(panel, IntPtr.Zero, "THSIDEdit", null);
            account_edit = FindWindowEx(account_edit, IntPtr.Zero, null, null);
            InputMessage(account_edit, "18901685");
            var value_edit = ChildWindowFromPoint(panel, new Point(555, 188));
            InputMessage(value_edit, "2000000");
            var ok_btn = ChildWindowFromPoint(panel, new Point(533, 331));
            SendMessage(ok_btn, WM_KEYDOWN, 32, null);
            var msg_window = FindWindow(null, "Information");
            var info_msgbox = ChildWindowFromPoint(panel, new Point(828, 403));
            var btn = FindWindowEx(msg_window, IntPtr.Zero, null, null);
        }
    }
}
