CryptoMJ
============

CryptoMJ é uma biblioteca desenvolvida em [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/) para criptografia e descriptografia.

## Porquê usar CryptoMJ?

Com a necessidade de criptografia para aplicativos desenvolvido em [Blazor Web Assembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor), AINDA [não existe suporte](https://docs.microsoft.com/pt-br/dotnet/core/compatibility/cryptography/5.0/cryptography-apis-not-supported-on-blazor-webassembly) para a biblioteca [System.Security.Cryptography](https://docs.microsoft.com/pt-br/dotnet/api/system.security.cryptography?view=net-6.0).
A intenção não é e nem deve ser utilizar a criptografia do lado do cliente de forma 100% segura, apenas dificultar o acesso a informação.

## Instalação

     Install-Package CryptoMJ
Para saber sobre a versão mais recente: https://www.nuget.org/packages/CryptoMJ

## Como usar

### Instanciando as classes e métodos
`````csharp
using CryptoMJ;

string key = "chave aleatoria para criptografia";
string textToEncrypt = "texto que sera criptografado";
ICrypto crypto = new CryptoBuilder().Build();
string encryptedText = crypto.Encrypt(textToEncrypt, key);
string decryptedText = crypto.Decrypt(encryptedText, key);

Console.WriteLine($"chave: {key}");
Console.WriteLine($"texto: {textToEncrypt}");
Console.WriteLine($"texto criptografado: {encryptedText}");
Console.WriteLine($"texto descriptografado: {decryptedText}");
`````
    
Veja o [exemplo](https://github.com/Marcos2Junior/CryptoMJ/blob/master/CryptoMJ.Console/Program.cs) utilizando um aplicativo de console
    
### Usando injeção de dependência

Em sua classe `Program` faça a chamado ao método `AddCryptoMJ()` 
`````csharp
using CryptoMJ;
    
Services.AddCryptoMJ();
 `````
    
Utilizando em um aplicativo de console
``` csharp
using CryptoMJ;
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
          string key = "chave aleatoria para criptografia";
          string textToEncrypt = "texto que sera criptografado";
          string encryptedText = crypto.Encrypt(textToEncrypt, key);
          string decryptedText = crypto.Decrypt(encryptedText, key);

          Console.WriteLine($"chave: {key}");
          Console.WriteLine($"texto: {textToEncrypt}");
          Console.WriteLine($"texto criptografado: {encryptedText}");
          Console.WriteLine($"texto descriptografado: {decryptedText}");
     }
}
````
    
Veja o [exemplo](https://github.com/Marcos2Junior/CryptoMJ/blob/master/CryptoMJ.ConsoleDI/Program.cs)

    


    
    
