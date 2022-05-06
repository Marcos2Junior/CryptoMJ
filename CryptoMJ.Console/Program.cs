using CryptoMJ;

var list = new ListBase64Factory(10, 1).Create();
foreach (var item in list)
{
    Console.WriteLine(item);
}