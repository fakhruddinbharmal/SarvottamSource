using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace SarvottamHospital
{
    public static class FileIcons
    {
        private static object _lock = new object();
        private static Dictionary<string, Bitmap> iconListSmall = new Dictionary<string, Bitmap>();
        private static Dictionary<string, Bitmap> iconListLarge = new Dictionary<string, Bitmap>();

        private const int SHGFI_ICON = 0x100;
        private const int SHGFI_SMALLICON = 0x1;
        private const int SHGFI_LARGEICON = 0x0;

        // This structure will contain information about the file
        private struct SHFILEINFO
        {
            public IntPtr hIcon;        // Handle to the icon representing the file
            public int iIcon;           // Index of the icon within the image list
            public uint dwAttributes;   // Various attributes of the file

            [MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szDisplayName; // Path to the file

            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;   // File type

        }

        // The signature of SHGetFileInfo (located in Shell32.dll)
        [DllImport("Shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, uint uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "DestroyIcon", SetLastError = true)]
        extern static bool DestroyIcon(IntPtr hIcon);


        private static Bitmap GetSmallIcon(string szFilename)
        {
            Bitmap r = null;
            try
            {
                SHFILEINFO aSHFileInfo = new SHFILEINFO();
                // Get a handle to the small icon
                IntPtr hImgSmall = SHGetFileInfo(szFilename, 0, ref aSHFileInfo, Marshal.SizeOf(aSHFileInfo), SHGFI_ICON | SHGFI_SMALLICON);
                // Get the small icon from the handle
                Icon ico = Icon.FromHandle(aSHFileInfo.hIcon);

                if (ico != null)
                    r = ico.ToBitmap();

                DestroyIcon(aSHFileInfo.hIcon);
            }
            catch { r = null; }
            return r;
        }

        private static Bitmap GetLargeIcon(string szFilename)
        {
            Bitmap r = null;
            try
            {
                SHFILEINFO aSHFileInfo = new SHFILEINFO();
                // Get a handle to the large icon
                IntPtr hImgLarge = SHGetFileInfo(szFilename, 0, ref aSHFileInfo, Marshal.SizeOf(aSHFileInfo), SHGFI_ICON | SHGFI_LARGEICON);
                // Get the large icon from the handle
                Icon ico = Icon.FromHandle(aSHFileInfo.hIcon);

                if (ico != null)
                    r = ico.ToBitmap();

                DestroyIcon(aSHFileInfo.hIcon);
            }
            catch { r = null; }
            return r;
        }

        public static Bitmap GetSmallIconByExtension(string extension)
        {
            Bitmap r = null;

            if (!string.IsNullOrEmpty(extension))
            {
                lock (_lock)
                {
                    extension = extension.ToLower();
                    if (iconListSmall.ContainsKey(extension))
                    {
                        r = iconListSmall[extension];
                    }
                    else
                    {
                        string tmpFileName = System.IO.Path.GetTempFileName();
                        string tmpFileExt = System.IO.Path.GetExtension(tmpFileName);
                        string fullFileName = tmpFileName.Replace(tmpFileExt, extension);

                        try
                        {
                            using (System.IO.FileStream fs = new System.IO.FileStream(fullFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
                                fs.Close();

                            //r = Icon.ExtractAssociatedIcon(fullFileName).ToBitmap();
                            r = GetSmallIcon(fullFileName);

                            if (r != null)
                            {
                                iconListSmall.Add(extension, r);

                                if (!iconListLarge.ContainsKey(extension))
                                {
                                    Bitmap bmpLarge = GetLargeIcon(fullFileName);
                                    if (bmpLarge != null)
                                        iconListLarge.Add(extension, bmpLarge);
                                }
                            }

                            System.IO.File.Delete(fullFileName);
                        }
                        catch { }
                    }
                }
            }
            return r;
        }

        public static Bitmap GetLargeIconByExtension(string extension)
        {
            Bitmap r = null;

            if (!string.IsNullOrEmpty(extension))
            {
                lock (_lock)
                {
                    extension = extension.ToLower();
                    if (iconListLarge.ContainsKey(extension))
                    {
                        r = iconListLarge[extension];
                    }
                    else
                    {
                        string tmpFileName = System.IO.Path.GetTempFileName();
                        string tmpFileExt = System.IO.Path.GetExtension(tmpFileName);
                        string fullFileName = tmpFileName.Replace(tmpFileExt, extension);

                        try
                        {
                            using (System.IO.FileStream fs = new System.IO.FileStream(fullFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
                                fs.Close();

                            //r = Icon.ExtractAssociatedIcon(fullFileName).ToBitmap();
                            r = GetLargeIcon(fullFileName);

                            if (r != null)
                            {
                                iconListLarge.Add(extension, r);

                                if (!iconListSmall.ContainsKey(extension))
                                {
                                    Bitmap bmpSmall = GetSmallIcon(fullFileName);
                                    if (bmpSmall != null)
                                        iconListSmall.Add(extension, bmpSmall);
                                }
                            }

                            System.IO.File.Delete(fullFileName);
                        }
                        catch { }
                    }
                }
            }
            return r;
        }

    }
}
