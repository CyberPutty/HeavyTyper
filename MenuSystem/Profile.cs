using System;
using System.Collections.Generic;
using System.Text;

namespace HeavyTyper.MenuSystem
{
    public class Profile: IRoute
    {
        private string text = "Profile";
        private ConsoleColor color = ConsoleColor.Cyan;
        public string Text { get => text; set => text = value; }
        public ConsoleColor Color { get => color; set => color = value; }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("myProfile");
            Console.ReadKey();
            return;
        }
    }
}
