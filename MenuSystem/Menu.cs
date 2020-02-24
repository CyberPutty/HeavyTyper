using System;
using System.Collections.Generic;
using System.Text;

namespace HeavyTyper.MenuSystem
{
    class Menu
    {
        public string header;
        public List<IRoute> options;
        int selectedIndex = 0;
        public string footer;
        public ConsoleColor selectedColor = ConsoleColor.Green;
        public ConsoleColor unselectedColor= ConsoleColor.Cyan;
        public bool active = true;
        public Menu(string header,List<IRoute> options,string footer)
        {
            this.header = header;
            this.footer = footer;
            this.options = options;
            this.options[0].Color = selectedColor;
        }
       public void Run() 
        {
            do {
             Console.Clear();
            Console.CursorVisible = false;
            if (header.Length > 0) 
            {
                Console.WriteLine(header);
            }
            
            foreach (IRoute option in options) 
            {
                Console.ForegroundColor = option.Color;
                Console.WriteLine(option.Text);
                
            }
            Console.ResetColor();
            if (footer.Length>0) 
            {
                Console.WriteLine(footer);
            }
            
            GetInput(Console.ReadKey());
            } while (active);
           
        }
        public void GetInput(ConsoleKeyInfo key) 
        {
            switch (key.Key) 
            {
                case ConsoleKey.UpArrow:
                    if (selectedIndex > 0)
                    {
                        MoveUp();
                    }
                    else 
                    {
                        Console.WriteLine("Out of bounds sound");
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedIndex < options.Count-1)
                    {
                        MoveDown();
                    }
                    else 
                    {
                        Console.WriteLine("Out of bounds sound");
                    }
                    break;
                case ConsoleKey.Enter:
                    Select();
                    break;
                case ConsoleKey.Q:
                    active = false;
                    return;
                default:
                    break;
                  
            }
        }
        public void Select()
        {
            options[selectedIndex].Run();
        }

        public void MoveUp() 
        {
            options[selectedIndex].Color = unselectedColor;
            this.selectedIndex = selectedIndex - 1;
            options[selectedIndex].Color = selectedColor;
        }
        public void MoveDown() 
        {
            options[selectedIndex].Color = unselectedColor;
            this.selectedIndex = selectedIndex + 1;
            options[selectedIndex].Color = selectedColor;
        }
    }
}
