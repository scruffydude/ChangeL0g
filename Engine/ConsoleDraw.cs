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
            string logo = @"
                                                                                                                                                                                 
                                                                                                                                                                                 
        CCCCCCCCCCCCChhhhhhh                                                                                      LLLLLLLLLLL                  000000000                         
     CCC::::::::::::Ch:::::h                                                                                      L:::::::::L                00:::::::::00                       
   CC:::::::::::::::Ch:::::h                                                                                      L:::::::::L              00:::::::::::::00                     
  C:::::CCCCCCCC::::Ch:::::h                                                                                      LL:::::::LL             0:::::::000:::::::0                    
 C:::::C       CCCCCC h::::h hhhhh         aaaaaaaaaaaaa  nnnn  nnnnnnnn       ggggggggg   ggggg    eeeeeeeeeeee    L:::::L               0::::::0   0::::::0   ggggggggg   ggggg
C:::::C               h::::hh:::::hhh      a::::::::::::a n:::nn::::::::nn    g:::::::::ggg::::g  ee::::::::::::ee  L:::::L               0:::::0     0:::::0  g:::::::::ggg::::g
C:::::C               h::::::::::::::hh    aaaaaaaaa:::::an::::::::::::::nn  g:::::::::::::::::g e::::::eeeee:::::eeL:::::L               0:::::0     0:::::0 g:::::::::::::::::g
C:::::C               h:::::::hhh::::::h            a::::ann:::::::::::::::ng::::::ggggg::::::gge::::::e     e:::::eL:::::L               0:::::0 000 0:::::0g::::::ggggg::::::gg
C:::::C               h::::::h   h::::::h    aaaaaaa:::::a  n:::::nnnn:::::ng:::::g     g:::::g e:::::::eeeee::::::eL:::::L               0:::::0 000 0:::::0g:::::g     g:::::g 
C:::::C               h:::::h     h:::::h  aa::::::::::::a  n::::n    n::::ng:::::g     g:::::g e:::::::::::::::::e L:::::L               0:::::0     0:::::0g:::::g     g:::::g 
C:::::C               h:::::h     h:::::h a::::aaaa::::::a  n::::n    n::::ng:::::g     g:::::g e::::::eeeeeeeeeee  L:::::L               0:::::0     0:::::0g:::::g     g:::::g 
 C:::::C       CCCCCC h:::::h     h:::::ha::::a    a:::::a  n::::n    n::::ng::::::g    g:::::g e:::::::e           L:::::L         LLLLLL0::::::0   0::::::0g::::::g    g:::::g 
  C:::::CCCCCCCC::::C h:::::h     h:::::ha::::a    a:::::a  n::::n    n::::ng:::::::ggggg:::::g e::::::::e        LL:::::::LLLLLLLLL:::::L0:::::::000:::::::0g:::::::ggggg:::::g 
   CC:::::::::::::::C h:::::h     h:::::ha:::::aaaa::::::a  n::::n    n::::n g::::::::::::::::g  e::::::::eeeeeeeeL::::::::::::::::::::::L 00:::::::::::::00  g::::::::::::::::g 
     CCC::::::::::::C h:::::h     h:::::h a::::::::::aa:::a n::::n    n::::n  gg::::::::::::::g   ee:::::::::::::eL::::::::::::::::::::::L   00:::::::::00     gg::::::::::::::g 
        CCCCCCCCCCCCC hhhhhhh     hhhhhhh  aaaaaaaaaa  aaaa nnnnnn    nnnnnn    gggggggg::::::g     eeeeeeeeeeeeeeLLLLLLLLLLLLLLLLLLLLLLLL     000000000         gggggggg::::::g 
                                                                                        g:::::g                                                                          g:::::g 
                                                                            gggggg      g:::::g                                                              gggggg      g:::::g 
                                                                            g:::::gg   gg:::::g                                                              g:::::gg   gg:::::g 
                                                                             g::::::ggg:::::::g                                                               g::::::ggg:::::::g 
                                                                              gg:::::::::::::g                                                                 gg:::::::::::::g  
                                                                                ggg::::::ggg                                                                     ggg::::::ggg    
                                                                                   gggggg                                                                           gggggg       
";

            string logo2 = @"
                                                                                           
     _/_/_/  _/                                                _/          _/              
  _/        _/_/_/      _/_/_/  _/_/_/      _/_/_/    _/_/    _/        _/  _/    _/_/_/   
 _/        _/    _/  _/    _/  _/    _/  _/    _/  _/_/_/_/  _/        _/  _/  _/    _/    
_/        _/    _/  _/    _/  _/    _/  _/    _/  _/        _/        _/  _/  _/    _/     
 _/_/_/  _/    _/    _/_/_/  _/    _/    _/_/_/    _/_/_/  _/_/_/_/    _/      _/_/_/      
                                            _/                                    _/       
                                       _/_/                                  _/_/          
";

            string logo3 = @"
   ____ _                            _     ___        
  / ___| |__   __ _ _ __   __ _  ___| |   / _ \  __ _ 
 | |   | '_ \ / _` | '_ \ / _` |/ _ \ |  | | | |/ _` |
 | |___| | | | (_| | | | | (_| |  __/ |__| |_| | (_| |
  \____|_| |_|\__,_|_| |_|\__, |\___|_____\___/ \__, |
                          |___/                 |___/ 
";

            Console.Clear();
            while (true)
            {
                var w = Console.WindowWidth-20;
                var h = Console.WindowHeight-10;
                var center = w / 2;

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
                    Console.SetBufferSize(120, 9001);
                }
                else if (choice == "open")
                {
                    Console.Clear();
                    for (int y = 1; y <= h - 1; y++)
                    {
                        for (int x = 1; x <= w - 1; x++)
                        {
                            if (x == center)
                            {
                                Console.SetCursorPosition(10 + x, y);
                                Console.Write("1");
                            }
                            else
                            {
                                Console.SetCursorPosition(10 + x, y);
                                Console.Write("0");
                            }

                        }

                    }
                    Console.WriteLine("\n");
                }
                else if (choice == "logo1")
                {
                    Console.Clear();
                    Console.SetWindowSize(180, 30);
                    Console.Write(logo);

                }else if(choice == "logo2")
                {
                    Console.Clear();
                    Console.SetWindowSize(120, 30);
                    Console.SetBufferSize(120, 9001);
                    Console.WriteLine(logo2);
                }
                else if (choice == "logo3")
                {
                    Console.Clear();
                    Console.SetWindowSize(120, 30);
                    Console.SetBufferSize(120, 9001);
                    Console.WriteLine(logo3);
                }
                else if (choice == "exit")
                {
                    break;
                }
            }
            

        }
    }
}
