using System;

namespace Session02Excersise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dot you want to enter yoyr name? (y/n) ");
            var key = Console.ReadKey();
            if (key.KeyChar == 'n')
                return;
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("hello, " + name );
            Console.ReadKey();


        }
    }
}
