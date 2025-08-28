using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("99999-1111", "Nokia Tijolão", "123456789", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        Smartphone iphone = new Iphone("99999-2222", "iPhone 14", "987654321", 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
