using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace F_PracticSeection
{
    class TrueOrNotGame
    {
        public string FilePath { get; set; }

        public TrueOrNotGame(string listOfQuestions)
        {
            this.FilePath = listOfQuestions;
        }

        public void BeginGame()
        {
            List<ListOfQuestions> list = File.ReadAllLines(FilePath)
             .Select(x => ListOfQuestions.ParseFileCsv(x))
             .ToList();

            int mistakes = 0;

            for (int i = 0; i < list.Capacity; i++)
            {
                Console.WriteLine($"Question: {list[i].Question}");
                Console.Write("Your answer (write \"Yes\" or \"No\"): ");
                string answer = Console.ReadLine();
                if (answer != list[i].Answer)
                {
                    Console.Write("You made mistake. Correct answer is: ");
                    Console.WriteLine(list[i].Explanation + "\n\n");
                    mistakes++;
                }
                else
                {
                    Console.Write("Correct. ");
                    Console.WriteLine(list[i].Explanation + "\n\n");
                }


                if (mistakes >= 2)
                {
                    Console.WriteLine("You Lose. Game Over!");
                    return;
                }
            }

            if (mistakes < 2)
            {
                Console.WriteLine("You win! You are very smart)");
            }
        }
        
    }
}
