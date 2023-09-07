using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your surname:");
            string surname = Console.ReadLine();
            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            Console.Write("Enter your weight in kg:");
            double weight = Double.Parse(Console.ReadLine());
            Console.Write("Enter your height in meters:");
            double height = Double.Parse(Console.ReadLine());

            double BMI = weight / (height * height);

            string weightStr = weight.ToString();
            string heightStr = height.ToString();
            string BMIStr = BMI.ToString();
            Console.Clear();

            string yourProfile = $"Your profile:\nFull Name: {surname},{name}\nAge: {age}\nWeight: {weightStr}\nHeight: {heightStr}\nBody Mass Index: {BMIStr}";
            Console.WriteLine(yourProfile);
        }
        
        static void HeronsFormula()
        {
            Console.WriteLine("Enter 3 sides of triangle.");
            Console.Write("Side 1 is:");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Side 2 is:");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Side 3 is:");
            double side3 = double.Parse(Console.ReadLine());
            double p = (side1 + side2 + side3) / 2;
            double S = Math.Sqrt(p * ((p - side1) * (p - side2) * (p - side3)));
            Console.WriteLine($"Area of the triangle: {S}");
        }
        static void HomeTask1()
        {
            //Task1
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            Console.WriteLine("Tap Enter for continue");
            Console.ReadLine();
            Console.Clear();
            //Task2
            Console.Write("Enter two numbers.\nNumber one: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Number two: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"First number is {n1}, second number is {n2}");
            int box = n1;
            n1 = n2;
            n2 = box;
            Console.WriteLine($"After swap first number is {n1}, second number is {n2}");
            Console.WriteLine("Tap Enter for continue");
            Console.ReadLine();
            Console.Clear();
            //Task3
            Console.Write("Enter integer:");
            string integer = Console.ReadLine();
            int numberOf = integer.Length;
            Console.WriteLine($"Number of digits is: {numberOf}");
        }
        static void DateTimeDemo()
        {
            //current time
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);
            //Add and other ONLY with methods
            DateTime newDt = dt.AddDays(1);
            Console.WriteLine(newDt);

            TimeSpan ts = now - dt;
            //same
            //ts = now.Subtract(dt);
            Console.WriteLine(ts.Days);
        }
        static void IntroToArray()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 5, 10, 5, 4, 510, 5 };

            Console.WriteLine(a4[4]);

            int number = a4[0];
            Console.WriteLine(number);

            a4[2] = 6;
            Console.WriteLine(a4[2]);

            Console.WriteLine(a4.Length);
            Console.WriteLine(a4[a4.Length - 1]);

            //string == array
            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];

            Console.WriteLine($"first is {first}, and last is {last}");

            //s1[0] = 'z'; not work

        }
        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.5));

            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); //basic
        }
        static void Comments()
        {
            //a single-line comment

            /*
             * 
             * 
             * multy-line comment
             * I can write
             * anywhere
             * but 
             * describe hows and whys! not whats! 
             */
        }
        static void CastingAndParsing()
        {
            byte b = 3; //0000 0011
            int i = b; //0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; //0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            //b = i; not work
            b = (byte)i;
            //Console.WriteLine(b);

            float f = i;
            i = (int)f;
            //Console.WriteLine(i);

            f = 3.1f;
            i = (int)f;
            // Console.WriteLine(i);

            string str = "1";
            //i = (int)str; not work with string 
            i = int.Parse(str);
            //Console.WriteLine(i);

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            //this is cast
            double result2 = (double)x / 2;
            Console.WriteLine(result2);
        }
        static void ConsoleBasic()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Hi, please tell me your name");
            string name = Console.ReadLine();
            string sentense = $"Ok. Your name is {name}";
            Console.WriteLine(sentense);

            Console.WriteLine("Good name. Now tell me your age.");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            sentense = $"Your age is {age}.";
            Console.WriteLine(sentense);


            Console.Write("I will be your friend");
            Console.Write(":)");
        }
        static void ComparingStrings()
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            //Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            //Console.WriteLine(areEqual);

            string s1 = "Strasse";
            string s2 = "Straße";
            areEqual = string.Equals(s1, s2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);

        }
        static void StringFormat()
        {
            string name = "John ";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            //string str2 = "My name is " + name + "and I'm " + age;
            string str2 = $"My name is {name} and I'm {age}";

            string str3 = "My name is \nJohn";
            string str4 = "I'm \t30";

            str3 = $"My name is {Environment.NewLine}John";

            string str5 = "I'm John and I'm a \"good\" programmer";

            //string str6 = "C:\\tmp\\test_file.txt";
            string str6 = @"C:\tmp\test_file.txt";
            Console.WriteLine(str6);

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer); //after d number of symbols
            Console.WriteLine(result);
            Console.WriteLine(result2);

            double answer2 = 42.08;
            result = string.Format("{0:f}", answer2);
            result2 = string.Format("{0:f1}", answer2); //after d number of symbols (its like rounding)
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C2}", money);

            //result = $"{money:C2}";

            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(result2);


        }
        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder(); //Good when we are working with 7+ strings in one time;
            sb.Append("My "); //using right here, in this string
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello");

            string str = sb.ToString();
            Console.WriteLine(str);
        }
        static void StringModification()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            nameConcat = "My " + "name " + "is " + "John";

            string newName = nameConcat.Insert(0, "By the way, ");
            //nameConcat = nameConcat.Insert(0, "By the way, "); //same
            Console.WriteLine(newName);

            nameConcat = nameConcat.Remove(0, 1); //begin, number of
            Console.WriteLine(nameConcat);

            string replased = nameConcat.Replace('n', 'z');
            Console.WriteLine(replased);

            string data = "12;28;34;25;64";
            string[] spliData = data.Split(';');
            string first = spliData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());
        }
        static void StringEmptiness()
        {
            string str = string.Empty; // do -> string empty

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null; //nothing

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpaced");

            bool IsNullOrWhiteSpaced = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(IsNullOrWhiteSpaced);

            IsNullOrWhiteSpaced = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(IsNullOrWhiteSpaced);

            IsNullOrWhiteSpaced = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(IsNullOrWhiteSpaced);

            IsNullOrWhiteSpaced = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(IsNullOrWhiteSpaced);
        }

        static void QueryingStrings()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);
            //All upper methods begin from 0;
            Console.WriteLine(name.Length); //but this give to me human number (from 1)

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 3); //from 0 element program take 3 chars

            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFromTo);
        }

        static void StaticAndInstanceMembers()
        {
            //There is NON STATIC becouse instance 
            string name = "abracadabra";

            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            //There is STATIC becouse i didn't create this Console.Writeline or sting.Concat
            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;

            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);
        }

        static void ComparisonOperators()
        {
            int x = 1;
            int y = 2;

            bool result = x == y;
            Console.WriteLine(result);

            result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);
        }

        static void MathOperations()
        {
            int x = 1;
            int y = 2;
            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = 2 + 2 * 2;
            int bf = (2 + 2) * 2;
            int c = 2 + 2 / 2;
            int d = k / 2;
            Console.WriteLine(b);
            Console.WriteLine(bf);
            Console.WriteLine(c);
            Console.WriteLine(d);

            a = 4 % 2;
            b = 5 % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a;
            //a = a * a * a;
            Console.WriteLine(a);

            a *= 2;

            Console.WriteLine(a);

            a /= 2;

            Console.WriteLine(a);
        }

        static void IncremetDicrementDemo()
        {
            int x = 1;
            x = x + 1;

            x++;
            Console.WriteLine(x);

            ++x;
            Console.WriteLine(x);

            x--;
            Console.WriteLine(x);

            --x;
            Console.WriteLine(x);

            Console.WriteLine("Learn about increments. x++ after = but ++x before");
            Console.WriteLine($"Last x state is {x}");

            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2;
            // x = x + 2;
            Console.WriteLine(x);
            j -= 2;
            // j = j - 2;
        }

        static void Owerflow()
        {
            //checked
            {
                uint x = uint.MaxValue;

                Console.WriteLine(x);

                x = x + 1;

                Console.WriteLine(x);

                x = x - 1;

                Console.WriteLine(x);
            }
        }
        static void VariablesScope()
        {
            int a = 1;
            {
                int b = 2;
                {
                    int c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c);
            }
            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
        }

        static void Variables()
        {
            int x = -1;

            int y;
            y = 2;

            //Int32 x1 = -1;

            float f = 1.1f;

            double d = 2.3;

            int x2 = 0;
            int x3 = new int();

            var a = 1;
            var b = 1.2;

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //var dict = new Dictionary<int, string>();

            decimal money = 3.0m;

            char character = 'A';
            string name = "Illiya";

            bool canDrive = true;
            bool canDraw = false;

            object obj1 = 1;
            object obj2 = "obj2";

            Console.WriteLine(a);
            Console.WriteLine(name);
        }

        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b1000_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            x = 0x1F;
            y = 0xFF0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;

            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine(4.5e2);
            Console.WriteLine(3.1E-1);

            Console.WriteLine();

            Console.WriteLine('\x78');
            Console.WriteLine('\x5A');

            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');
        }
    }
}
