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

        #region FindWindowEx
        [DllImport(
            "User32.dll",
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.Winapi
            )]
        public static extern
        IntPtr FindWindowEx(
            [In, Optional] IntPtr hwndParent,
            [In, Optional] IntPtr hwndChildAfter,
            [In, Optional] String lpszClass,
            [In, Optional] String lpszWindow
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
            [In]    IntPtr hwnd,
            [Out]   StringBuilder lpString,
            [In]    int nMaxCount
            );
        #endregion

        #region SetParent
        [DllImport(
            "User32.dll",
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.Winapi
            )]
        public static extern
        IntPtr SetParent(
            [In]            IntPtr hWndChild,
            [In, Optional]  IntPtr hWndNewParent
            );
        #endregion
    }
}
