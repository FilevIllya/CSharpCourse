using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface INumberFormat
    {
        string ToSSNFormat();
    }
    class SSN : INumberFormat
    {
        public string Number { get; set; }

        public string ToSSNFormat()
        {
            string numberToString = Number.ToString();
            char[] tmpArray = new char[numberToString.Length];

            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = numberToString[i];
            }

            string formatedNumber = "";
            for (int i = 0, j=0; j < tmpArray.Length; i++,j++)
            {
                if (i == 3 || i == 6)
                {
                    formatedNumber += '-';
                    i++;
                }
                formatedNumber += tmpArray[j];
            }

            return formatedNumber;
        }
    }
}
