using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Net4Frm.Common
{
    public class EncryptHelper
    {
        /// <summary>
        /// MD5 加密方法 
        /// </summary>
        /// <param name="word">待加密字符串</param>
        /// <returns>MD5加密密文 返回小写串</returns>
        public static string MD5Encryption(string word)
        {
            string result = string.Empty;
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(word));
            foreach (byte item in s)
            {
                result += item.ToString("X2");
            }
            return result.ToLower();
        }
    }
}
