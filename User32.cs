using System;
using System.Text;
using System.Runtime.InteropServices;

namespace API.Win32
{
    static class User32
    {
        #region EnumWindows
        [DllImport(
            "User32.dll",
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.Winapi
            )]
        public static extern
        bool EnumWindows(
            [In] EnumWindowsProc lpEnumFunc,
            [In] IntPtr lParam
            );
        #endregion

        #region GetWindowText
        [DllImport(
            "User32.dll",
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.Winapi
            )]
        public static extern
        bool GetWindowText(
            [In] IntPtr hwnd,
            [Out] StringBuilder lpString,
            [In] int nMaxCount
            );
        #endregion
    }
}
