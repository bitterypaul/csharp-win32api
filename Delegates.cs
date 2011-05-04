using System;

namespace API.Win32
{
    public delegate bool EnumWindowsProc(
        IntPtr hwnd,
        IntPtr lParam
    );
}