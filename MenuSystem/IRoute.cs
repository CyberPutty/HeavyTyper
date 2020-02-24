using System;
using System.Collections.Generic;
using System.Text;

namespace HeavyTyper.MenuSystem
{
    interface IRoute
    { 
        public string Text { get; set; }
        public ConsoleColor Color { get; set; }
        public void Run();
    }
}
