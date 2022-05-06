namespace CryptoMJ
{
    public interface ICrypto
    {
        string Encrypt(string textToEncrypt, string key);
        string Decrypt(string textToDecrypt, string key);
    }
}
