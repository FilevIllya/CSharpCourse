using System;
using System.Collections.Generic;
using System.Text;

namespace F_PracticSeection
{
    class Sticks
    {
        char[] sticks;

        public void BeginGameMultiplayer()
        {
            Console.Write("Welcome to \"Sticks\". Input number of sticks: ");
            int countOfSticks = Int32.Parse(Console.ReadLine());

            sticks = new char[countOfSticks];

            for (int i = 0; i < countOfSticks; i++)
            {
                sticks[i] = '|';
            }

            int turns = 1;
            int dropSticks = 0;
            int boxSticks = 0;

            BuildSticks(countOfSticks);
            do
            {
                int choose = -1;
                if (turns % 2 == 0)
                {
                    Console.Write("Player 2 turn:");
                    do
                    {
                        choose = Int32.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 1: boxSticks = countOfSticks; countOfSticks -= 1; dropSticks = 1; break;
                            case 2: boxSticks = countOfSticks; countOfSticks -= 2; dropSticks = 2; break;
                            case 3: boxSticks = countOfSticks; countOfSticks -= 3; dropSticks = 3; break;
                        }

                    } while (choose < 1 || choose > 3);
                    choose = -1;
                }
                else
                {
                    Console.Write("Player 1 turn:");
                    do
                    {
                        choose = Int32.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 1: boxSticks = countOfSticks; countOfSticks -= 1; dropSticks = 1; break;
                            case 2: boxSticks = countOfSticks; countOfSticks -= 2; dropSticks = 2; break;
                            case 3: boxSticks = countOfSticks; countOfSticks -= 3; dropSticks = 3; break;
                        }

                    } while (choose < 1 || choose > 3);
                    choose = -1;
                }

                if (dropSticks>boxSticks)
                {
                    if (turns % 2 == 0)
                    {
                        Console.Write("Player 2 lose");
                        break;
                    }
                    else
                    {
                        Console.Write("Player 1 lose");
                        break;
                    }
                }

                turns++;
                if (countOfSticks <= 1)
                {
                    if (turns % 2 == 0)
                    {
                        Console.Write("Player 2 lose");
                        break;
                    }
                    else
                    {
                        Console.Write("Player 1 lose");
                        break;
                    }
                }

                BuildSticks(countOfSticks);

            } while (countOfSticks > 0);
        }

        public void BeginGameSingleplayer()
        {
            Console.Write("Welcome to \"Sticks\". Input number of sticks: ");
            int countOfSticks = Int32.Parse(Console.ReadLine());

            sticks = new char[countOfSticks];

            for (int i = 0; i < countOfSticks; i++)
            {
                sticks[i] = '|';
            }

            int turns = 1;
            int dropSticks = 0;
            int boxSticks = 0;
            Random random = new Random();

            BuildSticks(countOfSticks);
            do
            {
                int choose = -1;
                if (turns % 2 == 0)
                {
                    Console.Write("Your turn:");
                    do
                    {
                        choose = Int32.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 1: boxSticks = countOfSticks; countOfSticks -= 1; dropSticks = 1; break;
                            case 2: boxSticks = countOfSticks; countOfSticks -= 2; dropSticks = 2; break;
                            case 3: boxSticks = countOfSticks; countOfSticks -= 3; dropSticks = 3; break;
                        }

                    } while (choose < 1 || choose > 3);
                    choose = -1;
                }
                else
                {
                    Console.Write("System made turn:");
                        switch (countOfSticks)
                        {
                            case 6: boxSticks = countOfSticks; countOfSticks -= 1; dropSticks = 1; break;
                            case 4: boxSticks = countOfSticks; countOfSticks -= 3; dropSticks = 3; break;
                            case 3: boxSticks = countOfSticks; countOfSticks -= 2; dropSticks = 2; break;
                            case 2: boxSticks = countOfSticks; countOfSticks -= 1; dropSticks = 1; break;
                            default: int rnd = random.Next(1, 3); boxSticks = countOfSticks; countOfSticks -= rnd; dropSticks = rnd; break;
                        }
                    Console.WriteLine($"System got {dropSticks} sticks"); 
                    choose = -1;
                }

                if (dropSticks > boxSticks)
                {
                    if (turns % 2 == 0)
                    {
                        Console.Write("You lose");
                        break;
                    }
                    else
                    {
                        Console.Write("System lose");
                        break;
                    }
                }

                turns++;
                if (countOfSticks <= 1)
                {
                    if (turns % 2 == 0)
                    {
                        Console.Write("You lose");
                        break;
                    }
                    else
                    {
                        Console.Write("System lose");
                        break;
                    }
                }

                BuildSticks(countOfSticks);

            } while (countOfSticks > 0);
        }

        private void BuildSticks(int countOfSticks)
        {
            for (int i = 0; i < countOfSticks; i++)
            {
                Console.Write($" {sticks[i]} ");
            }
            Console.WriteLine();
        }
    }
}
