using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ConsoleDraw
    {
        public void drawTesting()
        {
            Console.Clear();
            while (true)
            {
                var w = Console.WindowWidth;
                var h = Console.WindowHeight;

                Console.WriteLine("Current window with: " + w);
                Console.WriteLine("Current window height " + h);
                Console.WriteLine("Current Buffer width: " + Console.BufferWidth);
                Console.WriteLine("Current Buffer height: " + Console.BufferHeight);

                Console.Write("Enter Choice: ");
                string choice = Console.ReadLine();

                if (choice == "reset")
                {
                    Console.Clear();
                    Console.SetWindowSize(120, 30);
                }
                else if (choice == "open")
                {
                    Console.Clear();
                    for (int x = 0; x <= Console.WindowWidth-20; x++)
                    {
                        for (int y = 0; y<=Console.WindowHeight-20; y++)
                        {
                            Console.SetCursorPosition(10 + x, 1 + y);
                            Console.Write("0");
                        }
                        
                    }
                    Console.WriteLine("\n");
                } else if (choice == "exit")
                {
                    break;
                }
            }
            

        }
    }
}
