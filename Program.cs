using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken=null;
            Console.WriteLine(degisken);


            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba "+name  +" " +surname);
            Console.Read();
        }
    }
}
