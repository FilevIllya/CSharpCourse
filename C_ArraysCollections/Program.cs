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
