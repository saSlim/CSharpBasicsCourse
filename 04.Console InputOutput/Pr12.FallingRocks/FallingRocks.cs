using System;
using System.Collections.Generic;
using System.Threading;

namespace Pr12.FallingRocks
{
    class FallingRocks
    {
        //        Problem 12. ** Falling Rocks
        //Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
        //Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
        //Implement collision detection and scoring system.

        #region Music
        static void rerere(int d)
        {

            for (int x = 0; x < 3; x++)
            {
                Console.Beep(523, d); //re
            }
        }


        static void dosila(int d)
        {
            Console.Beep(1046, d); //do
            Console.Beep(987, d); //si
            Console.Beep(880, d);//la
        }


        static void dosido(int d)
        {
            Console.Beep(1046, d);
            Console.Beep(987, d);
            Console.Beep(1046, d);
        }
        static void partI_starwars()
        {
            rerere(200);
            Console.Beep(783, 1200); //sol
            Console.Beep(1174, 1200);//re2
            dosila(200); //funcion dosila()
            Console.Beep(1567, 1200); //sol2
            Console.Beep(1174, 600); //re2
            dosila(200);
            Console.Beep(1567, 1200); //sol2
            Console.Beep(1174, 600); //re2
            dosido(200);
            Console.Beep(880, 1200); //la
        }
        static void reremimi()
        {
            Console.Beep(523, 400); //re
            Console.Beep(523, 200); //re
            Console.Beep(659, 900); //mi
            Console.Beep(659, 300); //mi
        }

        static void frase000()
        {
            Console.Beep(1046, 300);//do
            Console.Beep(987, 300);//si
            Console.Beep(880, 300);//la
            Console.Beep(783, 300);//sol

            Console.Beep(783, 300);//sol
            Console.Beep(880, 150);//la
            Console.Beep(987, 150);//si
            Console.Beep(880, 300);//la
            Console.Beep(659, 300); //mi
            Console.Beep(733, 600); //fa#
        }

        static void frase001()
        {
            Console.Beep(1046, 300);//do
            Console.Beep(987, 300);//si
            Console.Beep(880, 300);//la
            Console.Beep(783, 300);//sol

            Console.Beep(1174, 900);//re2
            Console.Beep(880, 300);//la
            Console.Beep(880, 600);//la
        }

        static void frase002()
        {
            Console.Beep(1174, 400); //re2
            Console.Beep(1174, 200); //re2
            Console.Beep(1567, 400); //sol2
            Console.Beep(1396, 200); //sol2
            Console.Beep(1244, 400); //mib
            Console.Beep(1174, 200); //re
            Console.Beep(1046, 400); //do
            Console.Beep(923, 200);  //sib
            Console.Beep(880, 400);  //la
            Console.Beep(783, 200);  //sol
            Console.Beep(1174, 600);//re2
            for (int x = 0; x < 3; x++)
            {
                Console.Beep(880, 200);  //la
            }
            Console.Beep(880, 600);  //la
        }
        static void partII_starwars()
        {
            reremimi(); frase000();
            reremimi(); frase001();
            reremimi(); frase000();
            frase002();
        }
        static void final()
        {
            for (int x = 0; x < 3; x++)
            {
                Console.Beep(1174, 200); //re2
            }
            Console.Beep(1567, 1800); //sol2

            for (int x = 0; x < 3; x++)
            {
                Console.Beep(783, 200); //re2
            }
            Console.Beep(783, 1800);  //sol
        }

        static void GotLifeSound()
        {
            Console.Beep(1440, 30);
            Console.Beep(1494, 40);
            Console.Beep(1523, 50);
        }

        static void LooseLifeSound()
        {
            Console.Beep(523, 50);
            Console.Beep(494, 40);
            Console.Beep(440, 30);
        }

        #endregion

        static void PlayMusic()
        {
            while (true)
            {
                for (int x = 0; x < 2; x++) { partI_starwars(); }

                partII_starwars();

                for (int x = 0; x < 2; x++) { partI_starwars(); }

                final();
            }
        }

        struct GameObj
        {
            public int x;
            public int y;
            public char symbol;
            public ConsoleColor color;
        }

        struct Player
        {
            public int x;
            public int y;
            public string symbol;
            public ConsoleColor color;
        }
        
        static void PrintOnPosition(int x, int y, char symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        static void PrintPlayerOnPosition(int x, int y, string symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        static void PrintInfo(int x, int y, string str, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            if ((ConsoleColor)consoleColors.GetValue(new Random().Next(consoleColors.Length)) != ConsoleColor.Black)
            {
                return (ConsoleColor)consoleColors.GetValue(new Random().Next(consoleColors.Length));
            }
            else
            {
                return ConsoleColor.Blue;
            }
        }

        private static char GetRandomChar(char[] c)
        {
            return c[new Random().Next(0, c.Length)];
        }

        static void Main(string[] args)
        {
            Console.Title = "Falling Rocks";
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 55;

            int playfield = 35;
            int livesCount = 3;
            int addLife;
            int score = 0;
            int speed = 150;
            bool isHit = false;
            bool newLife = false;

            Thread music = new Thread(PlayMusic);
            music.Start();

            Random randomGenerator = new Random();

            char[] rocksArray = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
            
            Player Dwarf = new Player();
            Dwarf.x = (playfield / 2) - 1;
            Dwarf.y = Console.WindowHeight - 1;
            Dwarf.symbol = "(0)";
            Dwarf.color = ConsoleColor.White;

            List<GameObj> rocks = new List<GameObj>();

            while (true)
            {
                isHit = false;
                newLife = false;
                {
                    addLife = randomGenerator.Next(0, 100);
                    GameObj newObj = new GameObj();

                    if (addLife < 1)
                    {
                        newObj.color = ConsoleColor.Green;
                        newObj.x = randomGenerator.Next(0, playfield);
                        newObj.y = 0;
                        newObj.symbol = 'L';
                        rocks.Add(newObj);
                    }
                    else
                    {
                        newObj.color = GetRandomConsoleColor();
                        newObj.x = randomGenerator.Next(0, playfield);
                        newObj.y = 0;
                        newObj.symbol = GetRandomChar(rocksArray);
                        rocks.Add(newObj);
                    }
                }

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (Dwarf.x - 1 >= 0)
                        {
                            Dwarf.x--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (Dwarf.x + Dwarf.symbol.Length < playfield)
                        {
                            Dwarf.x++;
                        }
                    }
                }

                List<GameObj> newRocks = new List<GameObj>();

                for (int i = 0; i < rocks.Count; i++)
                {
                    GameObj newRock = new GameObj();
                    newRock.x = rocks[i].x;
                    newRock.y = rocks[i].y + 1;
                    newRock.symbol = rocks[i].symbol;
                    newRock.color = rocks[i].color;

                    if (newRock.symbol == 'L' && newRock.y == Dwarf.y && (newRock.x >= Dwarf.x && newRock.x < Dwarf.x + Dwarf.symbol.Length))
                    {
                        livesCount++;
                        score += 100;
                        newLife = true;

                        GotLifeSound();
                    }

                    if (newRock.symbol != 'L' && newRock.y == Dwarf.y && (newRock.x >= Dwarf.x && newRock.x < Dwarf.x + Dwarf.symbol.Length))
                    {
                        livesCount--;
                        isHit = true;
                        LooseLifeSound();

                        if (livesCount < 0)
                        {
                            PrintInfo((playfield / 2) - 4, Console.WindowHeight / 2, "GAME OVER", ConsoleColor.Red);
                            PrintInfo(playfield / 2 - 10, Console.WindowHeight / 2 + 2, "Press [esc] to exit", ConsoleColor.Red);
                            PrintInfo(playfield / 2 - 12, Console.WindowHeight / 2 + 4, "Press any key to try again", ConsoleColor.Red);

                            var info = Console.ReadKey();
                            if (info.Key == ConsoleKey.Escape)
                            {
                                Console.WriteLine();
                                Environment.Exit(0);

                            }
                            else
                            {
                                livesCount = 3;
                                score = 0;
                            }
                        }
                    }

                    if (newRock.y == Dwarf.y)
                    {
                        score++;
                    }

                    if (newRock.y < Console.WindowHeight)
                    {
                        newRocks.Add(newRock);
                    }
                }

                rocks = newRocks;

                Console.Clear();

                foreach (GameObj rock in rocks)
                {
                    PrintOnPosition(rock.x, rock.y, rock.symbol, rock.color);
                }

                if (isHit)
                {
                    PrintPlayerOnPosition(Dwarf.x, Dwarf.y, Dwarf.symbol, ConsoleColor.Red);
                    rocks.Clear();
                }
                else if (newLife)
                {
                    PrintPlayerOnPosition(Dwarf.x, Dwarf.y, Dwarf.symbol, ConsoleColor.Green);
                }
                else
                {
                    PrintPlayerOnPosition(Dwarf.x, Dwarf.y, Dwarf.symbol, Dwarf.color);
                }
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    PrintInfo((playfield), i, "|", ConsoleColor.Yellow);
                }

                PrintInfo(playfield + 3, 2, "Lives: " + livesCount, ConsoleColor.White);
                PrintInfo(playfield + 3, 4, string.Format("Score: {0:0000000}", score), ConsoleColor.White);
                PrintInfo(playfield + 3, 6, "'L'= new life :)", ConsoleColor.Green);
                PrintInfo(playfield + 3, 7, " and 100 points", ConsoleColor.Green);

                Thread.Sleep(speed);
            }

        }
    }
}
