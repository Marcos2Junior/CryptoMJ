using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptoMJ
{
    public class Crypto
    {
        public static Encoding Encoding = Encoding.UTF8;
       
        public static IEnumerable<int> Indexes(string chave)
        {
            return from index in chave select Convert.ToInt32(index);
        }

        public static string Encrypt(string text, string chave)
        {
            return string.Empty;
        }

        public static string Decrypt(string textEncrypt, string chave)
        {
            return String.Empty;
        }

        static List<string> Lists()
        {
            string caracteresbase64 = "E2oy5sxb1agn+TMqi4Lplc8tB76YmGRWFwDzjZrXK9AhQd=UJ/CI3VNOuHfP0evSk";
            List<string> list = new List<string>();
            for (int i = 0; i < 500; i++)
            {

            }

            return list;
        }
    }
}
