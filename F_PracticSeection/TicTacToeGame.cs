using System;
using System.Collections.Generic;
using System.Text;

namespace F_PracticSeection
{
    class TicTacToeGame
    {
        static char[] cells = new char[9] { '_', '_', '_', '_', '_', '_', ' ', ' ', ' ' };
        public static void TicTacToe()
        {
            Console.WriteLine("Welcome to \"Tic Tac Toe\". Input number from 1 to 9 to make a move to the corresponding cell.");
            GridBuilder();
            int cell = -1;
            int turns = 1;
            char XorO;
            do
            {
                if (turns % 2 == 0)
                {
                    Console.Write("Player 2 turn:");
                    XorO = 'O';
                }
                else
                {
                    Console.Write("Player 1 turn:");
                    XorO = 'X';
                }

                while ((!Int32.TryParse(Console.ReadLine(), out cell) && cell < 1 && cell > 9))
                {
                    Console.Write("Enter correct number: ");
                }
                cells[cell - 1] = XorO;

                Console.Clear();
                GridBuilder();

                if (BingoCheck() == true)
                {
                    if (turns % 2 == 0)
                    {
                        Console.Write("Player 2 win");
                        return;
                    }
                    else
                    {
                        Console.Write("Player 1 win");
                        return;
                    }
                }

                turns++;
            } while (turns < 9);


        }

        private static void GridBuilder()
        {
            Console.WriteLine($"{cells[0]}|{cells[1]}|{cells[2]}");
            Console.WriteLine($"{cells[3]}|{cells[4]}|{cells[5]}");
            Console.WriteLine($"{cells[6]}|{cells[7]}|{cells[8]}");
        }

        private static bool BingoCheck()
        {
            if ((cells[0] == cells[1] && cells[1] == cells[2]) && (cells[0] != ' ' && cells[0] != '_'))
            {
                return true;
            }
            else if ((cells[3] == cells[4] && cells[4] == cells[5]) && (cells[3] != ' ' && cells[3] != '_'))
            {
                return true;
            }
            else if ((cells[6] == cells[7] && cells[7] == cells[8]) && (cells[6] != ' ' && cells[6] != '_'))
            {
                return true;
            }
            else if ((cells[0] == cells[3] && cells[3] == cells[6]) && (cells[0] != ' ' && cells[0] != '_'))
            {
                return true;
            }
            else if ((cells[1] == cells[4] && cells[4] == cells[7]) && (cells[1] != ' ' && cells[1] != '_'))
            {
                return true;
            }
            else if ((cells[2] == cells[5] && cells[5] == cells[8]) && (cells[2] != ' ' && cells[2] != '_'))
            {
                return true;
            }
            else if ((cells[0] == cells[4] && cells[4] == cells[8]) && (cells[0] != ' ' && cells[0] != '_'))
            {
                return true;
            }
            else if ((cells[2] == cells[4] && cells[4] == cells[6]) && (cells[2] != ' ' && cells[2] != '_'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
