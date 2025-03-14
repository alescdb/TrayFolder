/*
Licensed to the Apache Software Foundation (ASF) under one
or more contributor license agreements.  See the NOTICE file
distributed with this work for additional information
regarding copyright ownership.  The ASF licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License.  You may obtain a copy of the License at

  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied.  See the License for the
specific language governing permissions and limitations
under the License.    
*/
using System;
using System.Drawing;
using System.Runtime.InteropServices;


namespace TrayFolder
{
  public static class Win32
  {
    public const uint SHGFI_ICON = 0x100;
    public const uint SHGFI_LARGEICON = 0x0;
    public const uint SHGFI_SMALLICON = 0x1;
    public const uint SHSIID_FOLDER = 0x3;
    public const uint SHGSI_ICON = 0x100;
    public const uint SHGSI_LARGEICON = 0x0;
    public const uint SHGSI_SMALLICON = 0x1;
    public const uint SHGFI_LINKOVERLAY = 0x000008000;
    public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;
    public const uint FILE_ATTRIBUTE_NORMAL = 0x80;

    [DllImport("user32.dll")]
    public static extern bool DestroyIcon( IntPtr handle );

    [DllImport("Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    private static extern int ExtractIconEx( string sFile, int iIndex, out IntPtr piLargeVersion, out IntPtr piSmallVersion, int amountIcons );

    [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    public static extern bool SetForegroundWindow( HandleRef hWnd );

    [DllImport("shell32.dll")]
    public static extern int SHGetStockIconInfo( uint siid, uint uFlags, ref SHSTOCKICONINFO psii );

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHSTOCKICONINFO
    {
      public uint cbSize;
      public IntPtr hIcon;
      public int iSysIconIndex;
      public int iIcon;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
      public string szPath;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
      public IntPtr hIcon;
      public IntPtr iIcon;
      public uint dwAttributes;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
      public string szDisplayName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
      public string szTypeName;
    };

    [DllImport("shell32.dll")]
    public static extern IntPtr SHGetFileInfo( string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags );

    private static Icon CloneAndDestroy( IntPtr iconPtr )
    {
      var icon = (Icon)Icon.FromHandle(iconPtr).Clone();
      DestroyIcon(iconPtr);
      return icon;
    }

    public static Icon GetStockIcon( uint type, uint size )
    {
      var info = new SHSTOCKICONINFO();
      info.cbSize = (uint)Marshal.SizeOf(info);
      SHGetStockIconInfo(type, SHGFI_ICON | size, ref info);
      return CloneAndDestroy(info.hIcon);
    }


    public static Icon Extract( string file, int number, bool largeIcon )
    {
      IntPtr large;
      IntPtr small;

      ExtractIconEx(file, number, out large, out small, 1);
      try
      {
        var icon = (Icon)Icon.FromHandle(largeIcon ? large : small).Clone();
        DestroyIcon(large);
        DestroyIcon(small);
        return icon;
      }
      catch
      {
        return null;
      }
    }
  }
}
