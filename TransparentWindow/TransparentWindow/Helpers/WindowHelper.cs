using System.Runtime.InteropServices;

namespace TransparentWindow.Helpers
{
    public abstract class WinApiMethod
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes(int hwnd, int crKey, byte bAlpha, int dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(int hwnd, int nlndex);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetWindowLong(int hwnd, int nlndex, int dwNewLong);

        public const int LWA_ALPHA = 2;
        public const int LWA_COLORKEY = 1;
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_TRANSPARENT = 32;
        public const int WS_EX_LAYERED = 524288;
    }

    public class WindowHelper
    {
        //https://blog.csdn.net/u012395622/article/details/48242683 
        public static bool SetWindowOpacity(int hWnd, byte bAlpha)
        {
            int dwExStyle = WinApiMethod.GetWindowLong(hWnd, WinApiMethod.GWL_EXSTYLE);
            dwExStyle |= WinApiMethod.WS_EX_LAYERED;
            WinApiMethod.SetWindowLong(hWnd, WinApiMethod.GWL_EXSTYLE, dwExStyle);
            return WinApiMethod.SetLayeredWindowAttributes(hWnd, 0, bAlpha, WinApiMethod.LWA_ALPHA);
        }
    }

}
