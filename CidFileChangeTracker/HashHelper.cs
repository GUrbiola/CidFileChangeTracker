using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CidFileChangeTracker
{
    public static class HashHelper
    {
        public static string CalculateHash(FileInfo FileInfo, int byteCount = 0)
        {
            int bytesToRead;
            string back;

            if (byteCount <= 0)
                return CalculateFullHash(FileInfo);

            try
            {
                if (FileInfo.Length < byteCount)
                    bytesToRead = (int)FileInfo.Length;
                else
                    bytesToRead = byteCount;

                byte[] buffer = new byte[bytesToRead];
                using (FileStream fs = new FileStream(FileInfo.FullName, FileMode.Open, FileAccess.Read))
                {
                    fs.Read(buffer, 0, bytesToRead);
                    fs.Close();
                }

                byte[] hash;
                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    md5.TransformFinalBlock(buffer, 0, buffer.Length);
                    hash = md5.Hash;
                }

                back = ToHex(hash, true);

            }
            catch (Exception ex)
            {
                return "Exception for File: " + FileInfo.Name + Environment.NewLine + "Exception Message: " + ex.Message;
            }

            return back;
        }

        public static string CalculateFullHash(FileInfo FileInfo)
        {
            string back;
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(FileInfo.FullName))
                    {
                        byte[] hash = md5.ComputeHash(stream);

                        back = ToHex(hash, true);
                    }
                }
            }
            catch (Exception ex)
            {
                return "Exception for File: " + FileInfo.Name + Environment.NewLine + "Exception Message: " + ex.Message;
            }

            return back;
        }

        private static string ToHex(byte[] bytes, bool upperCase)
        {
            StringBuilder result = new StringBuilder(bytes.Length * 2);

            for (int i = 0; i < bytes.Length; i++)
                result.Append(bytes[i].ToString(upperCase ? "X2" : "x2"));

            return result.ToString();
        }


    }
}
