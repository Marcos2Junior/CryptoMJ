using CryptoMJ;

string key = "key";
string textToEncrypt = "Marcos Antonio dos Santos Junior";

ICrypto crypto = new CryptoBuilder().Build();
string encryptedText = crypto.Encrypt(textToEncrypt, key);
string decryptedText = crypto.Decrypt(encryptedText, key);

Console.WriteLine($"chave: {key}");
Console.WriteLine($"texto: {textToEncrypt}");
Console.WriteLine($"texto criptografado: {encryptedText}");
Console.WriteLine($"texto descriptografado: {decryptedText}");
