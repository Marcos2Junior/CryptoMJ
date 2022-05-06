using System.Text;
using System.Collections.Generic;

namespace CryptoMJ
{
    public class CryptoBuilder
    {
        private Encoding _encoding;
        private List<string> _listBase64;
        public CryptoBuilder()
        {
            _encoding = Encoding.UTF8;
            _listBase64 = new ListBase64Factory(200, 1).Create();
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

        public ICrypto Build()
        {
            return new Crypto(_listBase64.ToArray(), _encoding);
        }
    }
}
