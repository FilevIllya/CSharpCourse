using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace F_PracticSeection
{
    class Guess_the_word
    {
        string[] dictionary;
        string hiddenWord;
        int hiddenWordLength;
        string yourString;

        int remainingAttempts = 6;

        public Guess_the_word()
        {
            if (File.Exists("WordsStock.txt"))
            {
                dictionary = File.ReadAllLines("WordsStock.txt");
            }
            else
            {
                throw new IOException();
            }
        }

        public void BeginGame()
        {
            Random random = new Random();
            hiddenWord = dictionary[random.Next(0, dictionary.Length)];
            hiddenWordLength = hiddenWord.Length;
            TryingToGuess();
        }

        private void TryingToGuess()
        {
            StringBuilder sb = new StringBuilder(hiddenWordLength);

            for (int i = 0; i < hiddenWordLength; i++)
            {
                sb.Append('_'); 
            }
            yourString = sb.ToString();

            bool isLetter = false;
            do
            {
                Console.Clear();
                Console.WriteLine($"A {hiddenWordLength}-letter word has been guessed. There are {remainingAttempts} attempts left");
                Console.WriteLine($"Current progress: {yourString}");

                isLetter = Comparing();
                if (isLetter == false)
                {
                    remainingAttempts--;
                }
            } while (remainingAttempts > 0 && CheckWin() != true);

            if (isLetter == true)
            {
                Console.WriteLine($"Current progress: {yourString}");
                Console.WriteLine($"You win. You spent {6-remainingAttempts} attempts");
            }
            else
            {
                Console.WriteLine("You lose. You spent all your attempts.");
                Console.WriteLine($"Hidden word was {hiddenWord}");
            }
        }

        private bool Comparing()
        {
            Console.WriteLine("Input a letter:");
            Char.TryParse(Console.ReadLine(), out char letter);
            bool goodLetter = false;

            for (int i = 0; i < hiddenWordLength; i++)
            {
                if (letter == hiddenWord[i])
                {
                    goodLetter = true;
                    char[] charArray = yourString.ToCharArray();
                    charArray[i] = letter;
                    yourString = new string(charArray);
                }
            }
            return goodLetter;
        }

        private bool CheckWin()
        {
            for (int i = 0; i < hiddenWordLength; i++)
            {
                if (yourString[i] == '_')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
