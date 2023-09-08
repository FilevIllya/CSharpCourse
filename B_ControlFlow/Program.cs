using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            double age = Double.Parse(Console.ReadLine());
            Console.Write("Enter your weight in kg: ");
            double weight = Double.Parse(Console.ReadLine());
            Console.Write("Enter your height in meters: ");
            double height = Double.Parse(Console.ReadLine());

            double BMI = weight / (height * height);

            bool isTooLow = BMI <= 18.5;
            bool isNormal = BMI > 18.5 && BMI < 25;
            bool isAboveNormal = BMI >= 25 && BMI <= 30;
            bool isTooFat = BMI > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat) //or isFat == true 
                Console.WriteLine("You'd better lose some weight");
            else
                Console.WriteLine("Oh, you're in a good shape");

            if (!isFat) // isFat == False
            {
                Console.WriteLine("You're defenitely not fat!");
            }


            //Many checks
            if (isTooLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if(isNormal)
            {
                Console.WriteLine("You're OK");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else //if upper will at least one == true, then other code will not to be executed
            {
                Console.WriteLine("You need to lose some weight");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Anyway it's time to get on diet");
            }

            //ternary operation
            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";
            Console.WriteLine(description);
            //it's like if-else construct
            //if (age>18)
            //{
            //    description = "You can drink alcohol";
            //}
            //else
            //{
            //    description = "You should get a bit older";
            //}
            //Console.WriteLine(description);
        }
    }
}
