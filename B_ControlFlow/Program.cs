using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void AvarageBy3()
        {
            //HomeTask 2
            int number = 0;
            int[] numbers = new int[10];
            int i = 0;
            Console.WriteLine("Enter one by one positive numbers. Enter 0 to finish. Max 10 numbers");
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                    break;
                numbers[i] = number;
                i++;
            } while (number > 0 && i < 10);

            int sum = 0;
            int k = 0;
            double avarage;

            for (int j = 0; j < i; j++)
            {
                if (numbers[j] % 3 == 0)
                {
                    sum += numbers[j];
                    k++;
                }
            }

            if (k == 0)
                k = 1;

            avarage = (double)sum / k;
            Console.Write("Avarage value numbers that divisible by 3: ");
            Console.WriteLine(avarage);
        }
        static void Fibonachi()
        {
            //HomeTask 1
            Console.WriteLine("Enter the number of Fibonacci numbers");
            int lenght = int.Parse(Console.ReadLine());
            int[] fibonachi = new int[lenght];
            if (lenght < 2)
            {
                Console.WriteLine("You wrote too low number");
            }
            else
            {
                fibonachi[0] = 1;
                fibonachi[1] = 1;
                for (int i = 2; i < lenght; i++)
                {
                    fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
                }

                Console.Write($"{lenght} fibonachi's numbers: ");
                for (int i = 0; i < fibonachi.Length; i++)
                {
                    Console.Write(fibonachi[i] + " ");
                }
            }
        }
        static void Debaging()
        {
            Console.WriteLine("Enter 3 sides of triangle.");

            Console.Write("Side 1 is:");
            double side1 = GetDouble();
            Console.Write("Side 2 is:");
            double side2 = GetDouble();
            Console.Write("Side 3 is:");
            double side3 = GetDouble();

            double p = side1 + side2 + side3 / 2;

            double S = Math.Sqrt(p * ((p - side1) * (p - side2) * (p - side3)));

            Console.WriteLine($"Area of the triangle: {S}");
        }
        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }
        static void SwitchDemo()
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }

            Console.WriteLine(season);

            Console.ReadLine();

            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловяная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебряная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "Не знаєм такого юбилея";
                    break;
            }

            Console.WriteLine(name);
        }
        static void BreakContinue()
        {
            int[] numberis = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };

            foreach (int n in numberis)
            {
                //if (n%2==0)
                //    Console.WriteLine(n);
                //OR

                if (n % 2 != 0)
                    continue; //next iteration

                Console.WriteLine(n);
            }

            Console.ReadLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numberis.Length; i++)
            {
                Console.WriteLine($"Number={numberis[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numberis[i] == j)
                        break;
                    Console.Write($" {letters[j]}");
                }
                Console.WriteLine();
            }


            Console.ReadLine();

            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                    break;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }
            }
        }
        static void WhileDoWhile()
        {
            int age = 30;

            //there first condition
            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age");
                age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Good)");

            //there first cycle
            do
            {
                Console.WriteLine("Do/While");
                Console.WriteLine("What is your age");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);

            //while like for:
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
        }
        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }

                }
            }
        }
        static void Forforeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //              ->>>>>>
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            //             <<<<<<<-
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Foreach");

            //only for each variable in array
            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }
        }
        static void IfMaxNumber()
        {
            Console.WriteLine("Enter two numbers");
            Console.Write("Number 1: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            double num2 = Double.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"Number {num1} is bigger then {num2}");
            }
            else
            {
                Console.WriteLine($"Number {num2} is bigger then {num1}");
            }
        }
        static void IfElse()
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
            else if (isNormal)
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
