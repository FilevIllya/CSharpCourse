using System;

namespace G_Delegation
{
    public class Car
    {
        int speed = 0;
        public delegate void TooFast(int currentSpeed);

        //The delegate describes a signature
        //and this signature must be followed by the handler
        private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                tooFast(speed); //handler "HandleOnTooFast"
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        public void RegisterOnTooFast(TooFast tooFast) //Linc on method
        {
            this.tooFast = tooFast;
        }
    }
    class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            car = new Car();
            car.RegisterOnTooFast(HandleOnTooFast);

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }
            
        }

        private static void HandleOnTooFast(int speed) //need same signature with delegate
        {
            Console.WriteLine($"Oh, I got it, calling Stop! Current speed = {speed}");
            car.Stop();
        }
    }
}
