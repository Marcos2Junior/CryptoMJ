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
            throw new NotImplementedException();
        }

        public string Encrypt(string textToEncrypt, string key)
        {
            throw new NotImplementedException();
        }
    }
}
