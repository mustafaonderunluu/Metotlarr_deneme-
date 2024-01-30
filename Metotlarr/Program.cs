using System;

namespace Metotlarr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temizle();
        }
        
        public static void Temizle()
        {
            while (true)
            {
                Console.WriteLine("Bir değer girin veya 'exit' yazarak ayrılın ");

                string değer =Console.ReadLine();

                if (değer == "exit")
                {
                    Console.WriteLine("ayrıldınız");
                    break;
                }

                else if(değer=="onder" )
                {
                    Console.WriteLine("Doğru");


                }
                else {
                    Console.WriteLine("Geçersiz işlem");
                }


                Console.ReadLine();
            }
        }
    }
}
