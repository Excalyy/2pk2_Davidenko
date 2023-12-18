
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Formats.Asn1.AsnWriter;

namespace SnakeGame
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class Program
    {
        static void Main(string[] args)
        {
            int screenwidth = Console.WindowWidth;
            int screenheight = Console.WindowHeight;


            Console.SetCursorPosition(screenwidth / 2 - 10, screenheight / 2);
            Console.WriteLine("----Добро пожаловать в игру----");
            Console.SetCursorPosition(screenwidth / 2 - 10, screenheight / 2 + 4);
            Console.WriteLine("Нажмите клавишу 'F' чтобы начать...");

            ConsoleKey key = Console.ReadKey(true).Key;

            if (key.ToString().ToUpper() == "F" || key.ToString().ToUpper() == "Ф")
            {
                Console.WindowHeight = 22;
                Console.WindowWidth = 42;
                Console.SetWindowSize(screenwidth, screenheight);
                Random randomnummer = new Random();



                pixel hoofd = new pixel();
                hoofd.xpos = screenwidth / 2;
                hoofd.ypos = screenheight / 2;

                string movement = "";
                List<int> xposlijf = new List<int>();
                List<int> yposlijf = new List<int>();

                List<pixel> apples = new List<pixel>();
                for (int i = 0; i < 3; i++)
                {
                    pixel apple = new pixel();
                    apple.xpos = randomnummer.Next(1, screenwidth - 2);
                    apple.ypos = randomnummer.Next(1, screenheight - 2);
                    apples.Add(apple);
                }

                TimeSpan tijd = TimeSpan.FromSeconds(0.1);

                int score = 1;
                int gameover = 0;
                while (gameover != 5 && gameover != 5) // Добавлено условие для победы
                {
                    Console.Clear();

                    if (hoofd.xpos <= 0 || hoofd.xpos >= screenwidth - 1 || hoofd.ypos <= 0 || hoofd.ypos >= screenheight - 1) // Изменено условие на выход головы за пределы игрового поля                    {
                        gameover = 1;
                }

                for (int i = 0; i < screenwidth; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("■");
                }

                for (int i = 0; i < screenwidth; i++)
                {
                    Console.SetCursorPosition(i, screenheight - 1);
                    Console.Write("■");
                }

                for (int i = 0; i < screenheight; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("■");
                }

                for (int i = 0; i < screenheight; i++)
                {
                    Console.SetCursorPosition(screenwidth - 1, i);
                    Console.Write("■");
                }

                foreach (pixel apple in apples)
                {
                    Console.SetCursorPosition(apple.xpos, apple.ypos);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("■");
                }

                if (apples.Any(a => a.xpos == hoofd.xpos && a.ypos == hoofd.ypos))
                {
                    score++;
                    pixel eatenApple = apples.FirstOrDefault(a => a.xpos == hoofd.xpos && a.ypos == hoofd.ypos);
                    apples.Remove(eatenApple);

                    pixel newApple = new pixel();
                    newApple.xpos = randomnummer.Next(1, screenwidth - 2);
                    newApple.ypos = randomnummer.Next(1, screenheight - 2);
                    apples.Add(newApple);

                    xposlijf.Add(0);
                    yposlijf.Add(0);
                }

                if (xposlijf.Contains(hoofd.xpos) && yposlijf.Contains(hoofd.ypos)) // Изменено условие на столкновение головы с хвостом
                {
                    gameover = 1;
                }

                for (int i = 0; i < xposlijf.Count(); i++)
                {
                    Console.SetCursorPosition(xposlijf[i], yposlijf[i]);
                    Console.Write("■");

                    if (xposlijf[i] == hoofd.xpos && yposlijf[i] == hoofd.ypos)
                    {
                        gameover = 1;
                    }
                }

                Console.SetCursorPosition(hoofd.xpos, hoofd.ypos);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("■");

                Console.CursorVisible = false;
                Console.SetCursorPosition(5, screenheight);
                Console.Write("Счёт: " + score);
                Console.SetCursorPosition(20, screenheight);
                Console.Write("Змейка");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo toets = Console.ReadKey(true);

                    if (toets.Key.Equals(ConsoleKey.LeftArrow) && movement != "RIGHT")
                    {
                        movement = "LEFT";
                    }

                    if (toets.Key.Equals(ConsoleKey.RightArrow) && movement != "LEFT")
                    {
                        movement = "RIGHT";
                    }

                    if (toets.Key.Equals(ConsoleKey.UpArrow) && movement != "DOWN")
                    {
                        movement = "UP";
                    }

                    if (toets.Key.Equals(ConsoleKey.DownArrow) && movement != "UP")
                    {
                        movement = "DOWN";
                    }

                    if (toets.Key.Equals(ConsoleKey.Escape))
                    {
                        Environment.Exit(0);
                    }
                }

                switch (movement)
                {
                    case "LEFT":
                        hoofd.xpos--;
                        break;
                    case "RIGHT":
                        hoofd.xpos++;
                        break;
                    case "UP":
                        hoofd.ypos--;
                        break;
                    case "DOWN":
                        hoofd.ypos++;
                        break;
                }

                if (hoofd.xpos <= 0 || hoofd.xpos >= screenwidth || hoofd.ypos <= 0 || hoofd.ypos >= screenheight) // Изменено условие на выход головы за пределы игрового поля
                {
                    gameover = 1;
                }

                xposlijf.Add(hoofd.xpos);
                yposlijf.Add(hoofd.ypos);

                while (xposlijf.Count > score)
                {
                    xposlijf.RemoveAt(0);
                    yposlijf.RemoveAt(0);
                }

                Thread.Sleep(tijd);
            }

            Console.Clear();

            if (gameover == 1)
            {
                Console.SetCursorPosition(screenwidth / 2 - 10, screenheight / 2);
                Console.WriteLine("Игра завершена, Ваш результат: " + score);
            }
            else if (gameover == 2)
            {
                Console.SetCursorPosition(screenwidth / 2 - 10, screenheight / 2);
                Console.WriteLine("Вы победили, Ваш результат: " + score);
            }

            Console.SetCursorPosition(screenwidth / 2 - 10, screenheight / 2 + 4);
            Console.WriteLine("Нажмите Enter чтобы играть снова...");

            while (Console.ReadKey().Key != ConsoleKey.Enter) { } // Ожидаем нажатия клавиши Enter

            Console.Clear(); // Очищаем консоль

            Main(args); // Начинаем новую игру
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
    class pixel
    {
        public int xpos { get; set; }
        public int ypos { get; set; }
    }
}