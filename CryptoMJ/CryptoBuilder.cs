using System.Collections.Generic;
using System.Text;

namespace CryptoMJ
{
    public class CryptoBuilder
    {
        private Encoding encoding;
        private List<string> listBase64;
        public CryptoBuilder()
        {
        }

        public ICrypto Build()
        {
            return new Crypto(listBase64.ToArray(), encoding);
        }
    }
}
