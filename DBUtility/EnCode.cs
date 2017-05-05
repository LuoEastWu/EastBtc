using System;
using System.Collections.Generic;
using System.Text;

namespace Maticsoft.DBUtility
{
    public class EnCode
    {
        public string M_StrHexFormat;

        /// <summary>
        /// 加密类
        /// </summary>
        public EnCode()
        {
            this.M_StrHexFormat = "x2";
        }

        /// <summary>
        /// 加密类
        /// </summary>
        /// <param name="HexFormat">格式化md5 hash 字节数组所用的格式（两位小写16进制数字）</param>
        public EnCode(string HexFormat)
        {
            this.M_StrHexFormat = HexFormat;
        }

        public string m_strHexFormat
        {
            get { return this.M_StrHexFormat; }
        }

        /// <summary>   
        /// 使用当前缺省的字符编码对字符串进行加密   
        /// </summary>   
        /// <param name="str">需要进行md5演算的字符串</param>   
        /// <returns>用小写字母表示的32位16进制数字字符串</returns>   
        public string md5(string str)
        {
            return (string)this.md5(str, false, System.Text.Encoding.Default);
        }
        /// <summary>   
        /// 对字符串进行md5 hash计算   
        /// </summary>   
        /// <param name="str">需要进行md5演算的字符串</param>   
        /// <param name="raw_output">   
        /// false则返回经过格式化的加密字符串(等同于 string md5(string) )   
        /// true则返回原始的md5 hash 长度16 的 byte[] 数组   
        /// </param>   
        /// <returns>   
        /// byte[] 数组或者经过格式化的 string 字符串   
        /// </returns>   
        public object md5(string str, bool raw_output)
        {
            return this.md5(str, raw_output, System.Text.Encoding.Default);
        }
        /// <summary>   
        /// 对字符串进行md5 hash计算   
        /// </summary>   
        /// <param name="str">需要进行md5演算的字符串</param>   
        /// <param name="raw_output">   
        /// false则返回经过格式化的加密字符串(等同于 string md5(string) )   
        /// true则返回原始的md5 hash 长度16 的 byte[] 数组   
        /// </param>   
        /// <param name="charEncoder">   
        /// 用来指定对输入字符串进行编解码的 Encoding 类型，   
        /// 当输入字符串中包含多字节文字（比如中文）的时候   
        /// 必须保证进行匹配的 md5 hash 所使用的字符编码相同，   
        /// 否则计算出来的 md5 将不匹配。   
        /// </param>   
        /// <returns>   
        /// byte[] 数组或者经过格式化的 string 字符串   
        /// </returns>   
        public object md5(string str, bool raw_output, System.Text.Encoding charEncoder)
        {
            if (!raw_output)
                return this.md5str(str, charEncoder);
            else
                return this.md5raw(str, charEncoder);
        }

        /// <summary>   
        /// 使用当前缺省的字符编码对字符串进行加密   
        /// </summary>   
        /// <param name="str">需要进行md5演算的字符串</param>   
        /// <returns>用小写字母表示的32位16进制数字字符串</returns>   
        public string md5str(string str)
        {
            return this.md5str(str, System.Text.Encoding.Default);
        }
        /// <summary>   
        /// 对字符串进行md5加密   
        /// </summary>   
        /// <param name="str">需要进行md5演算的字符串</param>   
        /// <param name="charEncoder">   
        /// 指定对输入字符串进行编解码的 Encoding 类型   
        /// </param>   
        /// <returns>用小写字母表示的32位16进制数字字符串</returns>   
        public string md5str(string str, System.Text.Encoding charEncoder)
        {
            byte[] bytesOfStr = this.md5raw(str, charEncoder);
            int bLen = bytesOfStr.Length;
            System.Text.StringBuilder pwdBuilder = new System.Text.StringBuilder(32);
            for (int i = 0; i < bLen; i++)
            {
                pwdBuilder.Append(bytesOfStr[i].ToString(this.m_strHexFormat));
            }
            return pwdBuilder.ToString();
        }
        /// <summary>   
        /// 使用当前缺省的字符编码对字符串进行加密   
        /// </summary>   
        /// <param name="str">需要进行md5演算的字符串</param>   
        /// <returns>长度16 的 byte[] 数组</returns>   
        public byte[] md5raw(string str)
        {
            return this.md5raw(str, System.Text.Encoding.Default);
        }
        /// <summary>   
        /// 对字符串进行md5加密   
        /// </summary>   
        /// <param name="str">需要进行md5演算的字符串</param>   
        /// <param name="charEncoder">   
        /// 指定对输入字符串进行编解码的 Encoding 类型   
        /// </param>   
        /// <returns>长度16 的 byte[] 数组</returns>   
        public byte[] md5raw(string str, System.Text.Encoding charEncoder)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            return md5.ComputeHash(charEncoder.GetBytes(str));
        }

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="encryptString">要加密的字串</param>
        /// <param name="encryptKey">Key</param>
        /// <returns>加密后字串</returns>
        public string DESEncode(string encryptString, string encryptKey)
        {
            byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            encryptKey = encryptKey.Length > 8 ? encryptKey.Substring(0, 8) : encryptKey;
            encryptKey = encryptKey.PadRight(8, ' ');
            byte[] rgbKey = System.Text.Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
            byte[] rgbIV = Keys;
            byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(encryptString);
            System.Security.Cryptography.DESCryptoServiceProvider dCSP = new System.Security.Cryptography.DESCryptoServiceProvider();
            System.IO.MemoryStream mStream = new System.IO.MemoryStream();
            System.Security.Cryptography.CryptoStream cStream = new System.Security.Cryptography.CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), System.Security.Cryptography.CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());
        }
    }
}
