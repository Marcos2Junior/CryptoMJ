namespace CryptoMJ
{
    public interface ICrypto
    {
        /// <summary>
        /// Criptografa a mensagem
        /// </summary>
        /// <param name="textToEncrypt">mensagem a ser criptografada</param>
        /// <param name="key">chave de criptografia</param>
        /// <returns>mensagem criptografada em base64</returns>
        string Encrypt(string textToEncrypt, string key);
        /// <summary>
        /// Criptografa a mensagem usando a chave padrao que foi fornecida no construtor
        /// </summary>
        /// <param name="textToEncrypt">mensagem a ser criptografada</param>
        /// <returns>mensagem criptografada em base64</returns>
        string Encrypt(string textToEncrypt);
        /// <summary>
        /// Descriptografa a mensagem
        /// </summary>
        /// <param name="textToDecrypt">mensagem a ser descriptografada</param>
        /// <param name="key">chave de criptografia</param>
        /// <returns>mensagem descriptografada</returns>
        string Decrypt(string textToDecrypt, string key);
        /// <summary>
        /// Descriptografa a mensagem usando a chave padrao que foi fornecida no construtor
        /// </summary>
        /// <param name="textToDecrypt">mensagem a ser descriptografada</param>
        /// <returns>mensagem descriptografada</returns>
        string Decrypt(string textToDecrypt);
    }
}
