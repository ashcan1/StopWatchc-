using System;
using System.Threading;

namespace DesignStopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool running;
        public void Start()
        {
            if (running)
            
                throw new InvalidCastException("Stopwatch is alreday running");
               _startTime = DateTime.Now;
                running = true;
            }

        public void Stop()
        {
            if (!running)
            
                throw new InvalidCastException("Stopwatch is alreday running");
            
                    _endTime = DateTime.Now;
                    running = false;
                }
            

        public TimeSpan GetInterval()
        {
            return  _endTime - _startTime;
            
        }





        internal class Program
    {

    }


        public static void Main(string[] args)
        {
             var stopwatch = new Stopwatch();
             for (var i = 0; i < 2; i++)
             {
                 stopwatch.Start();
               
                 Thread.Sleep(1);
                 
                 stopwatch.Stop();
                 Console.WriteLine(stopwatch.GetInterval());
                 Console.ReadLine();
             }
        }

    }
}