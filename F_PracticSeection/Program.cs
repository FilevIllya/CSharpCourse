using System;

namespace F_PracticSeection
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessTheNumber();
        }

        static public void GuessTheNumber()
        {
            //Gamemode
            Console.Write("Select the game mode:\n1 - Single Player\n2 - Two players\n Enter the number: ");
            int gameMode = -1;
            bool correctChoose = false;
            do
            {
                Int32.TryParse(Console.ReadLine(), out gameMode);
                if (gameMode == 1 || gameMode == 2)
                {
                    correctChoose = true;
                }
                else
                {
                    Console.Write("Enter correct number: ");
                }
            } while (correctChoose == false);

            //Game
            Console.Clear();
            if (gameMode == 1)
            {
                SinglePlayer();
            }
            else if (gameMode == 2)
            {
                Multiplayer();
            }



            Console.ReadLine();
        }

        static public void SinglePlayer()
        {
            Console.Write("Select the game mode in single game:\n1 - The system searches for a number\n2 - System hides the number\n Enter the number: ");

            int gameMode = -1;
            bool correctChoose = false;
            do
            {
                Int32.TryParse(Console.ReadLine(), out gameMode);
                if (gameMode == 1 || gameMode == 2)
                {
                    correctChoose = true;
                }
                else
                {
                    Console.Write("Enter correct number: ");
                }
            } while (correctChoose == false);

            Console.Clear();
            if (gameMode == 1)
            {
                SinglePlayerSystemSearch();
            }
            else
            {
                SinglePlayerPlayerSearch();
            }
        }

        static public void SinglePlayerSystemSearch()
        {
            int length = 100;
            int[] numberArray = new int[length + 1];
            for (int i = 0; i < length + 1; i++)
            {
                numberArray[i] = i;
            }

            Console.Write("Enter the number you want the System to find: ");
            int hideNumber;
            bool check = false;
            do
            {
                check = Int32.TryParse(Console.ReadLine(), out hideNumber);
                Console.Write("Enter the correct number: ");
            } while (check == false);
            Console.Clear();
            int findNumber = BinarySearch(numberArray, hideNumber, 0, length+1, out int iterations);

            if (iterations > 5)
            {
                Console.WriteLine($"System lose. System find number {findNumber} but did {iterations} iterations");
            }
            else
            {
                Console.WriteLine($"System win. The system found a number and did less then 5 iterations. It is: {findNumber}. System did {iterations} iterations");
            }
        }

        static public void SinglePlayerPlayerSearch()
        {
            int length = 100;
            int[] numberArray = new int[length + 1];
            for (int i = 0; i < length + 1; i++)
            {
                numberArray[i] = i;
            }

            Random rd = new Random();
            int hideNumber = rd.Next(0, 100);

            Console.WriteLine("Choose the difficulty: 1 - Easy (8 attempts)\n2 - Normal (6 attempts)\n 3 - Hard (5 attempts)\n Enter:");
            int menuNumber = -1;
            int attemptCount = -1;
            
            do
            {
                Int32.TryParse(Console.ReadLine(), out menuNumber);
                switch (menuNumber)
                {
                    case 1: attemptCount = 8; break;
                    case 2: attemptCount = 6; break;
                    case 3: attemptCount = 5; break;
                    default: Console.WriteLine("Enter correct number: "); break;
                }
            } while (menuNumber < 0 || menuNumber > 3);

            //Guessing
            bool correctChoose = false;
            int findNumber;
            do
            {
                Console.WriteLine($"\nThere are {attemptCount} attempts left. Enter the number guessed by player 1: ");
                Int32.TryParse(Console.ReadLine(), out findNumber);
                if (findNumber == hideNumber)
                {
                    correctChoose = true;
                    break;
                }
                else if (hideNumber > findNumber)
                {
                    Console.WriteLine("Your number is less than the guessed number");
                    attemptCount--;
                }
                else
                {
                    Console.WriteLine("Your number is greater than the guessed number");
                    attemptCount--;
                }
            } while (attemptCount > 0 && correctChoose == false);

            if (correctChoose == false)
            {
                Console.WriteLine("You lose. You have run out of attempts");
            }
            else
            {
                Console.WriteLine($"You win. The requested number was: {hideNumber}");
            }
        }

        static public int BinarySearch(int[] numberArray, int hideNumber, int firstNumber, int lastNumber, out int iterations)
        {
            iterations = 0;
            int attemps = 5;
            while (firstNumber <= lastNumber)
            {
                //индекс среднего элемента
                var middle = (firstNumber + lastNumber) / 2;
                iterations++;
                if (hideNumber == numberArray[middle])
                {
                    return middle;
                }
                else if (hideNumber < numberArray[middle])
                {
                    //сужаем рабочую зону массива с правой стороны
                    lastNumber = middle - 1;
                    attemps--;
                }
                else
                {
                    //сужаем рабочую зону массива с левой стороны
                    firstNumber = middle + 1;
                    attemps--;
                }
            }
            return -1;
        }
        static public void Multiplayer()
        {
            //Array length
            Console.Write("Player 1\nEnter the number of numbers among which the number will be guessed (standart = 100): ");
            int length = 0;
            while (!Int32.TryParse(Console.ReadLine(), out length))
            {
                Console.Write("Enter correct number: ");
            }

            //Generate array
            int[] numberArray = new int[length + 1];
            for (int i = 0; i < length + 1; i++)
            {
                numberArray[i] = i;
            }

            //hide number
            int hideNumber = -1;
            Console.WriteLine("Enter the number you want to guess to Player 2: ");

            bool correctChoose = false;
            do
            {
                Int32.TryParse(Console.ReadLine(), out hideNumber);
                if (hideNumber > 0 || hideNumber < length+1)
                {
                    correctChoose = true;
                }
                else
                {
                    Console.Write("Enter correct number: ");
                }
            } while (correctChoose == false);

            Console.WriteLine("Give contol to other player after pressing \"Enter\"");
            Console.Clear();

            //Player 2 plays
            //Dificulty
            Console.WriteLine("Choose the difficulty: 1 - Easy (8 attempts)\n2 - Normal (6 attempts)\n 3 - Hard (5 attempts)\n Enter:");
            int menuNumber = -1;
            int attemptCount = -1;
            do
            {
                Int32.TryParse(Console.ReadLine(), out menuNumber);
                switch (menuNumber)
                {
                    case 1: attemptCount = 8; break;
                    case 2: attemptCount = 6; break;
                    case 3: attemptCount = 5; break;
                    default: Console.WriteLine("Enter correct number: "); break;
                }
            } while (menuNumber< 0 || menuNumber > 3);

            //Guessing
            correctChoose = false;
            int findNumber;
            do
            {
                Console.WriteLine($"\nThere are {attemptCount} attempts left. Enter the number guessed by player 1: ");
                Int32.TryParse(Console.ReadLine(), out findNumber);
                if (findNumber == hideNumber)
                {
                    correctChoose = true;
                    break;
                }
                else if (hideNumber > findNumber)
                {
                    Console.WriteLine("Your number is less than the guessed number");
                    attemptCount--;
                }
                else
                {
                    Console.WriteLine("Your number is greater than the guessed number");
                    attemptCount--;
                }
            } while (attemptCount > 0 && correctChoose==false);


            //End game
            if (correctChoose == false)
            {
                Console.WriteLine("Player 1 wins. Player 2 has run out of attempts");
            }
            else
            {
                Console.WriteLine($"Player 2 wins. The requested number was: {hideNumber}");
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////

        static void ComplexNumberDemo()
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(3, 1);

            Complex result = c1.ComplexSubtraction(c2);
            Console.WriteLine($"Your complex number is {result.RealPart}+{result.ImaginaryPart}i");
        }
    }
}
