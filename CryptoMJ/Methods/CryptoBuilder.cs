using System.Text;
using System.Collections.Generic;

namespace CryptoMJ.Methods
{
    public class CryptoBuilder
    {
        private Encoding _encoding;
        private List<string> _listBase64;
        private string _key;
        public CryptoBuilder()
        {
            _encoding = Encoding.UTF8;
            _listBase64 = new ListBase64Factory(200, 1).Create();
            _key = string.Empty;
        }

        public CryptoBuilder Add(ListBase64Factory listBase64Factory)
        {
            _listBase64 = listBase64Factory.Create();
            return this;
        }

        public CryptoBuilder Add(Encoding encoding)
        {
            _encoding = encoding;
            return this;
        }

        /// <summary>
        /// Adiciona chave de criptografia padrao
        /// </summary>
        public CryptoBuilder UseKeyDefault(string keyDefault)
        {
            _key = keyDefault;
            return this;
        }

        public ICrypto Build()
        {
            return new Crypto(_listBase64.ToArray(), _encoding, _key);
        }
    }
}
