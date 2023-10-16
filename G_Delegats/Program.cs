using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;

namespace G_Delegation
{
    public class CarArgs : EventArgs
    {
        public CarArgs(int currentspeed)
        {
            CurrentSpeed = currentspeed;
        }

        public int CurrentSpeed { get;  }
    }

    public class Car
    {
        int speed = 0;

        public event EventHandler<CarArgs> TooFastDriving; //like Action<object, int>

        //public event Func<int, string> TooFastDrivingM; //like method

        //public delegate void TooFast(int currentSpeed); //no need for event Action

        //The delegate describes a signature
        //and this signature must be followed by the handler
        //private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                if (TooFastDriving != null)
                {
                    TooFastDriving(this, new CarArgs(speed)); //handler "HandleOnTooFast"
                }
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        //public void RegisterOnTooFast(TooFast tooFast) //Linc on method
        //{
        //    this.tooFast += tooFast; //add one more link to delegate
        //}

        //public void UnregisterOnTooFast(TooFast tooFast)
        //{
        //    this.tooFast -= tooFast; //delete metod from delegate
        //}
    }

    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
                throw new ArgumentException();

            foreach (var item in source)
            {
                action(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DisplayLargestFilesWithLinq(@"C:\Users\Acer\Desktop\поточна сборка");
            //DisplayLargestFilesWithoutLinq(@"C:\Users\Acer\Desktop\поточна сборка");
            Console.ReadLine(); 
        }

        private static void DisplayLargestFilesWithLinq(string pathToDir)
        {
            new DirectoryInfo(pathToDir)
                .GetFiles()
                .OrderByDescending(file => file.Length) //or {return file.length} for more than 1 line code
                .Take(5)
                .ForEach(file => Console.WriteLine($"{file.Name} weights {file.Length}"));

            //or

            //IEnumerable<FileInfo> orderedFiles = new DirectoryInfo(pathToDir)
            //    .GetFiles()
            //    .OrderBy(file => file.Length) //or {return file.length} for more than 1 line code
            //    .Take(5);

            //foreach (var file in orderedFiles)
            //{
            //    Console.WriteLine($"{file.Name} weights {file.Length}");
            //}
        }

        //static long KeySelector(FileInfo file)
        //{
        //    return file.Length;
        //}

        //Solution without LINQ
        private static void DisplayLargestFilesWithoutLinq(string pathToDir)
        {
            var dirInfo = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInfo.GetFiles();

            Array.Sort(files, FilesComparison);

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} weights {file.Length}");
            }
        }

        static int FilesComparison(FileInfo x, FileInfo y)  //sort Delegate
        {
            if (x.Length == y.Length)
            {
                return 0;
            }

            if (x.Length > y.Length)
            { 
                return -1; 
            }
            return 1;
        }

        private static void EventsDemo()
        {
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed; //subscribe 

            timer.Interval = 5000;
            timer.Start();

            Console.ReadLine();

            Car car = new Car();
            //delegate
            //car.RegisterOnTooFast(HandleOnTooFast);
            //car.RegisterOnTooFast(HandleOnTooFast); //its not method it's subscribe. 2 subscribe = 2 methods in Accelerate
            //car.UnregisterOnTooFast(HandleOnTooFast);

            car.TooFastDriving += HandleOnTooFast; //event
            //car.TooFastDriving += HandleOnTooFast;

            //car.TooFastDriving -= HandleOnTooFast;

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Handling Timer Elapsed Event");
        }

        private static void HandleOnTooFast(object obj, CarArgs speed) //need same signature with delegate
        {
            Console.WriteLine($"Oh, I got it, calling Stop! Current speed = {speed.CurrentSpeed}");
            var car = (Car)obj;
            car.Stop();
        }
    }
}
