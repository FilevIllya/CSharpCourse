using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    class RomanToArabian
    {
        private Dictionary<char, int> RomanArabianPairs = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        }; 

        public int Convert(string romanNumber)
        {
            int length = romanNumber.Length;
            char[] symbols = new char[length];
            for (int i = 0; i < length; i++)
            {
                symbols[i] = romanNumber[i];
            }

            int[] arabianNumbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                arabianNumbers[i] = RomanArabianPairs[symbols[i]];
            }

            int arabianNumber = arabianNumbers[length-1];
            for (int i = length-1; i > 0; i--)
            {
                if (arabianNumbers[i] > arabianNumbers[i-1])
                {
                    arabianNumber -= arabianNumbers[i - 1];
                }
                else
                {
                    arabianNumber += arabianNumbers[i - 1];
                }
            }

            return arabianNumber;
        }
    }
}
