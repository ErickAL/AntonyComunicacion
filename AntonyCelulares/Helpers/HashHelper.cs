using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace AntonyCelulares.Helpers
{
    public class HashHelper
    {
        #region Public Methods
        public static string Encrypt(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string Decrypt(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        public static string GetSHA1(string input)
        {
            return GetHash(SHA1.Create(), input);
        }
        public static bool VerifySHA1(string input, string md5hash)
        {
            return VerifyHash(SHA1.Create(), input, md5hash);
        }
        public static string GetSHA512(string input)
        {
            return GetHash(SHA512.Create(), input);
        }
        public static bool VerifySHA512(string input, string md5hash)
        {
            return VerifyHash(SHA512.Create(), input, md5hash);
        }
        public static string GetMD5(string input)
        {
            return GetHash(MD5.Create(), input);
        }
        public static bool VerifyMD5(string input, string md5hash)
        {
            return VerifyHash(MD5.Create(), input, md5hash);
        }
        #endregion

        #region Private Methods
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
        #endregion

    }

}
