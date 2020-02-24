using System;
using HeavyTyper.MenuSystem;
namespace HeavyTyper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu menu = new Menu();
            menu.Print();
            Console.ReadKey();
        }
    }
}
