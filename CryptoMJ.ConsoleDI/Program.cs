using CryptoMJ;
using CryptoMJ.Extensions;
using Microsoft.Extensions.DependencyInjection;

new ServiceCollection()
    .AddCryptoMJ()
    .AddScoped<Startup>()
    .BuildServiceProvider()
    .GetService<Startup>();

public class Startup
{
    public Startup(ICrypto crypto)
    {
        string key = "key";
        string textToEncrypt = "Marcos Antonio dos Santos Junior";
        string encryptedText = crypto.Encrypt(textToEncrypt, key);
        string decryptedText = crypto.Decrypt(encryptedText, key);

        Console.WriteLine($"chave: {key}");
        Console.WriteLine($"texto: {textToEncrypt}");
        Console.WriteLine($"texto criptografado: {encryptedText}");
        Console.WriteLine($"texto descriptografado: {decryptedText}");
    }
}