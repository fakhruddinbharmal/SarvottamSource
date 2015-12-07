using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace SarvottamHospital
{
    public static class Utility
    {
        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        private static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        private static string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        public static bool IsEligibleToRun()
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.AppKey) && int.TryParse(Decrypt(Properties.Settings.Default.AppKey), out count))
            {
                if (count < 50)
                {
                    var r = (count + 1).ToString();
                    Properties.Settings.Default["AppKey"] = Encrypt(r);
                    Properties.Settings.Default.Save();
                    return true;
                }
            }
            return false;
            //if (!string.IsNullOrEmpty(Properties.Settings.Default.RunCount) && string.Compare(Decrypt(Properties.Settings.Default.RunCount), "Ankit", StringComparison.InvariantCultureIgnoreCase) == 0)
            //{
            //    using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\HospitalManagement"))
            //    {
            //        var encryptedString = Encrypt("AppRunCount");
            //        object r = key.GetValue(encryptedString);

            //        var value = r != null && !string.IsNullOrEmpty(r.ToString()) ? Decrypt(r.ToString()) : "0";
            //        count = int.Parse(value);

            //        if (r != null)
            //        {
            //            //count = (int)r;
            //            if (count < 3)
            //            {
            //                key.SetValue(encryptedString, Encrypt((count + 1).ToString()));
            //                return true;
            //            }
            //            else
            //            {
            //                Properties.Settings.Default["RunCount"] = Encrypt("Sanghvi");
            //                Properties.Settings.Default.Save();
            //                return false;
            //            }

            //        }
            //        else
            //        {
            //            key.SetValue(encryptedString, Encrypt("1"));
            //            return true;
            //        }
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
