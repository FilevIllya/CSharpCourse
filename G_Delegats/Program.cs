using System;
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
    class Program
    {
        static void Main(string[] args)
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
