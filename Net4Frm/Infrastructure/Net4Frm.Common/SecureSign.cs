using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Net4Frm.Common
{
    public class SecureSign
    {
        /// <summary>
        /// 门店key
        /// </summary>
        private static readonly string BRANCH_KEY = EncryptHelper.MD5Encryption("branch10086");

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="sort">需要签名的参数</param>
        /// <returns></returns>
        public static string Sign(SortedDictionary<string, string> sort)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var s in sort)
            {
                sb.AppendFormat("{0}={1}&", s.Key, s.Value);
            }
            string md5Str = EncryptHelper.MD5Encryption(sb.Append(BRANCH_KEY).ToString());
            return md5Str;
        }

        /// <summary>
        /// 签名比对
        /// </summary>
        /// <param name="signSource">源签名</param>
        /// <param name="sign">签名</param>
        /// <returns></returns>
        public static bool ComparisonSign(string signSource, string sign)
        {
            if (string.IsNullOrEmpty(signSource) || string.IsNullOrEmpty(sign))
                return false;

            return signSource == sign;
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="txtEncrypt">加密字符串</param>
        /// <param name="number">固定入参16,密码截取前16位</param>
        /// <returns>密文</returns>
        public static string MD5Encrypt(string txtEncrypt, int number)
        {
            byte[] buffer1 = Encoding.Default.GetBytes(txtEncrypt);
            buffer1 = new MD5CryptoServiceProvider().ComputeHash(buffer1);
            string text1 = "";
            for (int num1 = 0; num1 < buffer1.Length; num1++)
            {
                text1 = text1 + buffer1[num1].ToString("x").PadLeft(2, '0');
            }
            if (number == 0x10)
            {
                return text1.Substring(8, 0x10);
            }
            return text1;
        }


    }
}
