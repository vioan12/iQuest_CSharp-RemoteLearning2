using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Problem04
{
    public static class EncryptionDecryption
    {
        public static string EncriptPassword(string password)
        {
            byte[] data;
            try
            {
                data = Encoding.UTF8.GetBytes(password);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(Constants.Key));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                        {
                            Key = key,
                            Mode = CipherMode.ECB,
                            Padding = PaddingMode.PKCS7
                        })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        return Convert.ToBase64String(result, 0, result.Length);
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        public static string DecryptPassword(string password)
        {
            byte[] data;
            try
            {
                data = Convert.FromBase64String(password);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(Constants.Key));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                        {
                            Key = key,
                            Mode = CipherMode.ECB,
                            Padding = PaddingMode.PKCS7
                        })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        return Encoding.UTF8.GetString(result);
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
