using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;


namespace SarvottamHospital
{
    public static class Common
    {
        private static object _lock = new object();
        public const string DATETIME_FORMAT = "dd/MM/yyyy HH:mm";
        public const string DATE_FORMAT = "dd/MM/yyyy";
        public const string AMOUNT_FORMAT = "#0.00";
        private const string REGEX_URL = @"^([w-]{3})\.([a-z0-9-]+)\.([a-z]{2})?([a-z|.]{1})([a-z]{2})$";
        private const string REGEX_EMAIL = @"^([0-9a-zA-Z]+[-._+&])*[0-9a-zA-Z]+@([-0-9a-zA-Z]+[.])+[a-zA-Z]{2,6}$";
        private const string FONT_NAME = "Arial";
        private const float FONT_SIZE = 9F;

        private const DataGridViewContentAlignment GRID_AMOUNT_ALGIN = DataGridViewContentAlignment.MiddleRight;

        private static Icon mAppIcon;
        public static Icon ApplicationIcon
        {
            get
            {
                if (null == mAppIcon)
                {
                    lock (_lock)
                    {
                        if (null == mAppIcon)
                        {
                            mAppIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                        }

                    }
                }
                return mAppIcon;
            }
        }

        private static Font mAppFont;
        public static Font ApplicationFont
        {
            get
            {
                //if (null == mAppFont || string.Compare(mAppFont.FontFamily.Name, AppDAL.Company.FontFamily) != 0 || (new decimal(mAppFont.SizeInPoints)) != (AppDAL.Company.FontSize < 8.25M ? 8.25M : AppDAL.Company.FontSize))
                //{
                //    if (string.IsNullOrEmpty(AppDAL.Company.FontFamily))
                //    {
                //        mAppFont = SystemFonts.DialogFont;
                //    }
                //    else
                //    {
                //        float size = (AppDAL.Company.FontSize < 8.25M ? 8.25F : (float)AppDAL.Company.FontSize);
                //        mAppFont = GetFontByName(AppDAL.Company.FontFamily, size, FontStyle.Regular, GraphicsUnit.Point);
                //    }
                //}
                if (null == mAppFont)
                {
                    mAppFont = GetFontByName(FONT_NAME, FONT_SIZE, FontStyle.Regular, GraphicsUnit.Point);
                }
                return mAppFont;
            }
        }

        private static Font mAppTitleFont;
        public static Font ApplicationTitleFont
        {
            get
            {
                //if (null == mAppTitleFont || string.Compare(mAppTitleFont.FontFamily.Name, AppDAL.Company.FontFamily) != 0 || (new decimal(mAppTitleFont.SizeInPoints)) != (AppDAL.Company.FontSize < 8.25M ? 8.25M : AppDAL.Company.FontSize))
                //{
                //    string fontFamily = (string.IsNullOrEmpty(AppDAL.Company.FontFamily) ? SystemFonts.DialogFont.FontFamily.Name : AppDAL.Company.FontFamily);
                //    float size = (AppDAL.Company.FontSize < 8.25M ? 10F : (float)(AppDAL.Company.FontSize + (AppDAL.Company.FontSize * 0.1M)));
                //    mAppTitleFont = GetFontByName(fontFamily, size, FontStyle.Bold, GraphicsUnit.Point);
                //}
                if (null == mAppTitleFont)
                {
                    mAppTitleFont = GetFontByName(FONT_NAME, FONT_SIZE + (FONT_SIZE * 0.1F), FontStyle.Bold, GraphicsUnit.Point);
                }
                return mAppTitleFont;
            }
        }

        private static byte[] mBlankImageData;
        public static byte[] BlankImageData
        {
            get
            {
                if (null == mBlankImageData)
                    mBlankImageData = Convert.FromBase64String(@"R0lGODlhAQABAPAAAP///////yH5BAEAAAEALAAAAAABAAEAAAICTAEAOw==");
                return mBlankImageData;
            }
        }

        private static Image mBlankImage;
        public static Image BlankImage
        {
            get
            {
                if (null == mBlankImage)
                    mBlankImage = ImageFromBytes(BlankImageData);
                return mBlankImage;
            }
        }

        public static string IntToString(int value)
        {
            return (value != null && value > 0 ? value.ToString() : string.Empty);
        }

        public static string DateToString(DateTime date)
        {
            return (date == DateTime.MinValue ? string.Empty : date.ToString(DATE_FORMAT));
        }

        public static string DateToString(DateTime date, string emptyValue)
        {
            return (date == DateTime.MinValue ? emptyValue : date.ToString(DATE_FORMAT));
        }

        public static Color LightTextColor
        {
            get { return Color.FromArgb(64, 64, 64); }
        }

        public static Color LightLightTextColor
        {
            get { return Color.FromArgb(90, 90, 90); }
        }

        private static Font GetFontByName(string name, float size, FontStyle style, GraphicsUnit unit)
        {
            Font r = null;
            try { r = new Font(name, size, style, unit, (byte)0); }
            catch (Exception) { r = null; }
            return r;
        }

        private static Font GetFontByName(string name)
        {
            return GetFontByName(name, 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static void SetDateFormat(DataGridViewColumn clm)
        {
            clm.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        public static void SetAmountFormat(DataGridViewColumn clm)
        {
            clm.DefaultCellStyle.Format = AMOUNT_FORMAT;
            clm.DefaultCellStyle.Alignment = GRID_AMOUNT_ALGIN;
            clm.HeaderCell.Style.Alignment = GRID_AMOUNT_ALGIN;
        }

        public static void SetNumberFormat(DataGridViewColumn clm)
        {
            clm.DefaultCellStyle.Alignment = GRID_AMOUNT_ALGIN;
            clm.HeaderCell.Style.Alignment = GRID_AMOUNT_ALGIN;
        }

        public static string ToHumanCase(string text)
        {
            text = (text == null ? string.Empty : text);
            string r = Regex.Replace(text, "[A-Z]",
                            delegate(Match match)
                            {
                                return string.Format(" {0}", match.Value);
                            });
            r = r.TrimStart();
            return r;
        }

        public static bool IsURL(string url)
        {
            return Regex.IsMatch(url, REGEX_URL);
        }

        public static bool IsEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }

        public static string ReadableDiff(DateTime startTime, DateTime endTime)
        {
            string result = string.Empty;

            int seconds = endTime.Second - startTime.Second;
            int minutes = endTime.Minute - startTime.Minute;
            int hours = endTime.Hour - startTime.Hour;
            int days = endTime.Day - startTime.Day;
            int months = endTime.Month - startTime.Month;
            int years = endTime.Year - startTime.Year;

            if (seconds < 0)
            {
                minutes--;
                seconds += 60;
            }
            if (minutes < 0)
            {
                hours--;
                minutes += 60;
            }
            if (hours < 0)
            {
                days--;
                hours += 24;
            }

            if (days < 0)
            {
                months--;
                int previousMonth = (endTime.Month == 1) ? 12 : endTime.Month - 1;
                int year = (previousMonth == 12) ? endTime.Year - 1 : endTime.Year;
                days += DateTime.DaysInMonth(year, previousMonth);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }

            //put this in a readable format
            if (years > 0)
            {
                result = string.Format("{0} {1}", years, (years > 1 ? "years" : "year"));
                if (months > 0)
                    result += string.Format(", {0} {1}", months, (months > 1 ? "months" : "month"));
                result += " ago";
            }
            else if (months > 0)
            {
                result = string.Format("{0} {1}", months, (months > 1 ? "months" : "month"));
                if (days > 0)
                    result += string.Format(", {0} {1}", days, (days > 1 ? "days" : "day"));
                result += " ago";
            }
            else if (days > 0)
            {
                result = string.Format("{0} {1}", days, (days > 1 ? "days" : "day"));
                if (hours > 0)
                    result += string.Format(", {0} {1}", hours, (hours > 1 ? "hours" : "hour"));
                result += " ago";
            }
            else if (hours > 0)
            {
                result = string.Format("{0} {1}", hours, (hours > 1 ? "hours" : "hour"));
                if (minutes != 0)
                    result += ", " + string.Format("{0} {1}", minutes, (minutes > 1 ? "minutes" : "minute"));
                result += " ago";
            }
            else if (minutes > 0)
            {
                result = string.Format("{0} {1}", minutes, (minutes > 1 ? "minutes" : "minute"));
                if (seconds > 0)
                    result += string.Format(", {0} {1}", seconds, (seconds > 1 ? "seconds" : "second"));
                result += " ago";
            }
            else if (seconds > 0)
                result = string.Format("{0} {1} ago", seconds, (seconds > 1 ? "seconds" : "second"));
            return result;
        }

        public static string ReadableDiff(DateTime date)
        {
            return ReadableDiff(date, DateTime.Now);
        }

        public static Bitmap ResizeBitmap(Image src, int newWidth, int newHeight)
        {
            Bitmap r = null;
            if (null == src)
                return r;
            else if (src.Width == newWidth && src.Height == newHeight)
                return new Bitmap(src);

            float srcFactor = (float)src.Width / (float)src.Height;

            int calWidth = newWidth;
            int calHeight = (int)(calWidth / srcFactor);

            if (calHeight > newHeight)
            {
                calHeight = newHeight;
                calWidth = (int)(calHeight * srcFactor);
            }

            int calX = (newWidth - calWidth) / 2;
            int calY = (newHeight - calHeight) / 2;

            // Create new Bitmap at new dimensions
            r = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(r as System.Drawing.Image))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.FillRectangle(System.Drawing.Brushes.White, 0, 0, newWidth, newHeight);
                g.DrawImage(src, calX, calY, calWidth, calHeight);
                g.Flush();
            }
            return r;
        }

        public static Bitmap LoadFromFile(string imageFile, int width, int height)
        {
            Bitmap r = null;
            Bitmap bmp = null;
            try
            {
                bmp = new Bitmap(imageFile);
                r = ResizeBitmap(bmp, width, height);
            }
            catch { }
            finally
            {
                if (bmp != null)
                    bmp.Dispose();
            }
            return r;
        }

        public static Image ImageFromBytes(byte[] data)
        {
            Image r = null;
            if (null != data && data.Length > 0)
            {
                System.IO.MemoryStream ms = null;
                try
                {
                    ms = new System.IO.MemoryStream(data);
                    r = Image.FromStream(ms);
                }
                catch { }
                finally
                {
                    if (ms != null)
                        ms.Dispose();
                }
            }
            return r;
        }

        public static byte[] BytesToImage(Image img)
        {
            byte[] r = null;
            if (null != img)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    r = ms.ToArray();
                }
            }
            return r;
        }

    }
}
