using System;

namespace Stopwatch
{
    internal class Watch
    {
        private DateTime startTime;
        private DateTime stopTime;
        private bool isRunning;

        public Watch()
        {
        }

        public void Start()
        {
            if (isRunning)
            {
                
               throw new InvalidOperationException("The stopwatch is already running");
            }

            startTime = DateTime.Now;
            isRunning = true;
        }

        public void Stop()
        {
            if (!isRunning)
                throw new InvalidOperationException("The watch has been stopped already");
            else
            {
                stopTime = DateTime.Now;
                isRunning = false;
            }
        }

        public TimeSpan Duration()
        {
            TimeSpan duration = stopTime - startTime;
            Console.WriteLine(duration);
            return duration;
        }
    }
}