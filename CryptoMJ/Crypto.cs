using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptoMJ
{
    public class Crypto : ICrypto
    {
        private readonly Encoding _encoding;

        private readonly string[] _listBase64;
        public Crypto(string[] listBase64, Encoding encoding)
        {
            _encoding = encoding;
            _listBase64 = listBase64;
        }

        public string Decrypt(string textToDecrypt, string key)
        {
            var listKey = ListKey(key).ToList();
            string decryptedText = string.Empty;
            foreach (char c in textToDecrypt)
            {
                char lastc = c;
                for (int i = listKey.Count - 1; i > 0; i--)
                {
                    lastc = listKey[i][listKey[i - 1].IndexOf(lastc)];
                }
                decryptedText += lastc;
            }
            return _encoding.GetString(Convert.FromBase64String(decryptedText));
        }

        public string Encrypt(string textToEncrypt, string key)
        {
            string base64 = Convert.ToBase64String(_encoding.GetBytes(textToEncrypt));
            var listKey = ListKey(key).ToList();
            string encryptedText = string.Empty;
            foreach (char c in base64)
            {
                char lastc = c;
                for (int i = 1; i < listKey.Count; i++)
                {
                    lastc = listKey[i - 1][listKey[i].IndexOf(lastc)];
                }

                encryptedText += lastc;
            }
            return encryptedText;
        }

        private IEnumerable<string> ListKey(string key) => from k in key select _listBase64[_listBase64.Length < Convert.ToInt32(k) ? 0 : Convert.ToInt32(k)];
    }
}
