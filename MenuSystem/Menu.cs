using System;
using System.Collections.Generic;
using System.Text;

namespace HeavyTyper.MenuSystem
{
    abstract class Menu
    {
        public string header;
        public List<Option> options;
        int selectedIndex = 0;
        public string footer;
        public ConsoleColor selectedColor = ConsoleColor.Green;
        public ConsoleColor unselectedColor= ConsoleColor.Cyan;
        public Menu(string header,List<Option> options,string footer)
        {
            this.header = header;
            this.footer = footer;
            this.options = options;
            this.options[0].color = selectedColor;
        }
       public void Print() 
        {          
            Console.Clear();
            Console.CursorVisible = false;
            if (header.Length > 0) 
            {
                Console.WriteLine(header);
            }
            
            foreach (Option option in options) 
            {
                Console.ForegroundColor = option.color;
                Console.WriteLine(option.text);
                
            }
            Console.ResetColor();
            if (footer.Length>0) 
            {
                Console.WriteLine(footer);
            }
            
            GetInput(Console.ReadKey());
        }
        public void GetInput(ConsoleKeyInfo key) 
        {
            switch (key.Key) 
            {
                case ConsoleKey.UpArrow:
                    if (selectedIndex > 0)
                    {
                        MoveUp();
                        Print();
                    }
                    else 
                    {
                        Console.WriteLine("Out of bounds sound");
                        Print();
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedIndex < options.Count-1)
                    {
                        MoveDown();
                        Print();
                    }
                    else 
                    {
                        Console.WriteLine("Out of bounds sound");
                        Print();
                    }
                    break;
                case ConsoleKey.Enter:
                    Run();
                    break;
                case ConsoleKey.Q:
                    return;
                default:
                    Print();
                    break;
                  
            }
        }
        public string Run()
        {
            return options[selectedIndex].text;
        }

        public void MoveUp() 
        {
            options[selectedIndex].color = unselectedColor;
            this.selectedIndex = selectedIndex - 1;
            options[selectedIndex].color = selectedColor;
        }
        public void MoveDown() 
        {
            options[selectedIndex].color = unselectedColor;
            this.selectedIndex = selectedIndex + 1;
            options[selectedIndex].color = selectedColor;
        }
    }
}
