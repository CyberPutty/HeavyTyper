using System;
using HeavyTyper.MenuSystem;
using System.Collections;
using System.Collections.Generic;

namespace HeavyTyper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<IRoute> programs = new List<IRoute>();
            programs.Add(new Profile());
        
            Menu menu = new Menu("welcome to the menu",programs,"Copyright some guy");
            menu.Run();
            Console.ReadKey();
        }
    }
}
