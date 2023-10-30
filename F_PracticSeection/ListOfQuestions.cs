using System;
using System.Collections.Generic;
using System.Text;

namespace F_PracticSeection
{
    class ListOfQuestions
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Explanation { get; set; }

        public override string ToString()
        {
            return $" Question: {Question}\n Answer: {Answer}\n Explanation: {Explanation}";
        }

        public static ListOfQuestions ParseFileCsv(string line)
        {
            string[] parts = line.Split(';');
            return new ListOfQuestions()
            {
                Question = parts[0],
                Answer = parts[1],
                Explanation = parts[2]
            };
        }
    }
}
