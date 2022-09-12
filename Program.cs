using AbstrairCelular.Models;

namespace AbstrairCelular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia("11999999999", "Nokia 42","1455875", 32);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone("11888888888", "Iphone 12", "15893", 32);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
        }
    }
}