using System;
using System.Collections.Generic;
using System.Linq;

namespace C_ArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        
        static void CountTheNumberInArray()
        {
            //HomeTask 2
            Console.Write("Input the number of elements to store in the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] mainArray = new int[arrayLenght];

            Console.WriteLine($"Input {arrayLenght} number of elements in the array:");
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write($"element - {i}: ");
                mainArray[i] = int.Parse(Console.ReadLine());
            }

            int arrayNumber = 0;
            int counter = 0;
            int[] checkArray = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                arrayNumber = mainArray[i];
                counter = 0;
                for (int j = 0; j < arrayLenght; j++)
                {
                    if (mainArray[j] == arrayNumber)
                    {
                        counter++;
                    }
                }
                checkArray[i] = counter;
            }

            string[] stringArray = new string[arrayLenght];
            string str = string.Empty;
            counter = 0;
            bool isStr = false;

            Console.WriteLine("Frequency of all elements of array: ");
            for (int i = 0; i < arrayLenght; i++)
            {
                str = $"{mainArray[i]} occurs {checkArray[i]} times";
                for (int j = 0; j < arrayLenght; j++)
                {
                    if (stringArray[j] == str)
                    {
                        isStr = true;
                    }
                }
                if (isStr == false)
                {
                    stringArray[counter] = str;
                    counter++;
                }
                isStr = false;
            }

            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
        }
        static void ReverseArray()
        {
            //HomeTask 1
            Console.Write("Input the number of elements to store in the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] reverseArray = new int[arrayLenght];

            Console.WriteLine($"Input {arrayLenght} number of elements in the array:");
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write($"element - {i}: ");
                reverseArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are: ");
            foreach (var item in reverseArray)
            {
                Console.Write(item + "  ");
            }

            Console.WriteLine("The values store into the array in reverse are: ");
            int box = 0;
            for (int i = 0; i < arrayLenght / 2; i++)
            {
                box = reverseArray[i];
                reverseArray[i] = reverseArray[reverseArray.Length - i - 1];
                reverseArray[reverseArray.Length - i - 1] = box;
            }

            foreach (var item in reverseArray)
            {
                Console.Write(item + "  ");
            }
        }
        static void IndexFrom1()
        {
            //its VERY BAD do like this
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 }); //4 - lenght, 1 - first index
            myArray.SetValue(2019, 1);
            myArray.SetValue(2019, 2);
            myArray.SetValue(2019, 3);
            myArray.SetValue(2019, 4); //its good becouse 1 first index

            Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Endig index: {myArray.GetUpperBound(0)}");

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
            //its like
            //for (int i = 1; i < 5; i++)
            //{
            //  Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            //}
        }
        static void JaggedArray()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Enter the number for a jagged array.");

            for (int i = 0; i < jaggedArray.Length; i++) //count of rows
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);

                }
            }

            Console.WriteLine();
            Console.WriteLine("Printing the Elements");

            for (int i = 0; i < jaggedArray.Length; i++) //print out
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MultidimArray()
        {
            int[,] r1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; //rows, coloumn
            for (int i = 0; i < r1.GetLength(0); i++)
            {
                for (int j = 0; j < r1.GetLength(1); j++)
                {
                    Console.Write($"{r1[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void StackQueue()
        {
            //queue
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Should print out 1: {queue.Peek()}");

            queue.Dequeue(); //return deleted value

            Console.WriteLine($"Should print out 2: {queue.Peek()}");

            Console.WriteLine("Iterate over the queue.");
            foreach (var cur in queue)
            {
                Console.WriteLine(cur);
            }

            Console.ReadLine();
            //stack
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out 4: {stack.Peek()}");

            stack.Pop(); //return deleted value

            Console.WriteLine($"Should print out 3: {stack.Peek()}");

            Console.WriteLine("Iterate over the stack.");
            foreach (var cur in stack)
            {
                Console.WriteLine(cur);
            }
        }
        static void DictionaryDemo()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");
            //same like
            people = new Dictionary<int, string>()
            {
                {1,"John" },
                {2,"Bob" },
                {3,"Alice" },
            };
            //same values doesnt add

            //finding by key n
            string name = people[1];
            Console.WriteLine(name);

            Console.WriteLine("Iterating over keys");
            Dictionary<int, string>.KeyCollection keys = people.Keys; //type. "var" better 

            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over values");
            Dictionary<int, string>.ValueCollection values = people.Values;

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over key-value pairs");
            foreach (var pair in people)
            {
                Console.WriteLine($"Key: {pair.Key}. Value: {pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine($"Count = {people.Count}"); //count of pairs

            bool containsKey = people.ContainsKey(2);//finding VERY fast
            bool containsValue = people.ContainsValue("John"); //finding slow like in array

            Console.WriteLine($"Contains key: {containsKey}. Contains value: {containsValue}");

            people.Remove(1); //delete by key. return true/false

            if (people.TryAdd(2, "Bin"))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Failed to add");
            }

            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2, Val={val}");
            }
            else
            {
                Console.WriteLine("Failed to get");
            }

            people.Clear();
        }
        static void ListDemo()
        {
            //Add
            var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 };//anu type in <>
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            //Remove
            if (intList.Remove(1)) //this method return bool //first occurense
            {
                //do
            }

            intList.RemoveAt(0); //remove by index

            intList.Reverse();

            bool contains = intList.Contains(3); // Is there 3?

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min = {min}, Max = {max}");

            int indexOf = intList.IndexOf(2);
            int lastindexOf = intList.LastIndexOf(2); //find by index

            Console.WriteLine($"IndexOf2 = {indexOf}. LastIndexOf = {lastindexOf}");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine($"{intList[i]}");
            }
            Console.WriteLine();

            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static void ArrayType()
        {
            //finding
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            //copy
            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anothercopy = new int[10];
            copy.CopyTo(anothercopy, 0);

            //reverse
            Array.Reverse(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            //sort
            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            //Set to default
            Array.Clear(copy, 0, copy.Length);

            //Types of writing arrays
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, -2, 5, 10 };

            Array myArray = new int[5];
            //its like
            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(12, 0);

            Console.WriteLine(myArray2.GetValue(0));
        }
    }
}
