using System;
using System.Collections.Generic;
using System.Text;

namespace SarvottamHospital.Object
{
    internal enum ObjectStatus
    {
        /// <summary>No status, object value can't be used.</summary>
        None = 0,
        /// <summary>Newly Created, object can be save database.</summary>
        NewOne = 1,
        /// <summary>Opened, object can be save & delete.</summary>
        Opened = 2
    }

    internal enum ObjectAction
    {
        /// <summary>No Action, object has no action pending.</summary>
        None = 0,
        /// <summary>Save, object has save action pending.</summary>
        Save = 1,
        /// <summary>Delete, object had delete operation pending.</summary>
        Delete = 2
    }

    public static class ContentType
    {
        public const string HTML = "text/html";
        public const string TXT = "text/plain";

        public const string JPEG = "image/jpeg";
        public const string GIF = "image/gif";
        public const string PNG = "image/png";
        public const string BMP = "image/bmp";
        public const string TIFF = "image/tiff";

        public const string WORDDOC = "application/msword";
        public const string EXCEL = "application/vnd.ms-excel";
        public const string POWERPOINT = "application/vnd.ms-powerpoint";
        public const string PDF = "application/pdf";
        public const string RTF = "application/rtf";
        public const string ZIP = "application/zip";
        public const string OTHER = "application/octet-stream";
    }

    public enum FolderIcons
    {
        Folder1 = 1,
        Folder2 = 2,
        Folder3 = 3,
        Folder4 = 4
    }

    public enum ReoccurrenceTypes
    {
        None = 0,
        Daily = 1,
        Weekly = 2,
        Fortnight = 3,
        Monthly = 4,
        Quarterly = 5,
        Halfyearly = 6,
        Yearly = 7,
        TwoYearly = 8,
        FiveYearly = 9,
        TenYearly = 10
    }

    public enum WorkItemType
    {
        Invalid = 0,
        Mail = 1,
        Task = 2,
        Reminder = 3
    }

    public enum Gender
    {
        Male = 1,
        Female = 2,
        Other = 3
    }

    public enum PatientStatus
    {
        NotDischarge = 0,
        Discharge = 1
    }

    public enum CreditDebit
    {
        Credit = 0,
        Debit = 1
    }
}
