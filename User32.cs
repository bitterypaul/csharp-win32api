using System;
using System.Runtime.InteropServices;

namespace API.Win32
{
    static class User32
    {
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
    }
}
