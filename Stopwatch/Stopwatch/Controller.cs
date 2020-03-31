using System;

namespace Stopwatch
{
    public class Controller

    {
        private Watch watch = new Watch();

        public Controller()
        {
        }

        public void StartController()
        {
            Start();
        }

        private void Start()
        {
            bool valid;
            int selection;
            valid = true;
            while (valid)
            {
                CreateMenu();
                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                    Operation(selection);
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nWrong input, please enter a correct number");
                    valid = false;
                    
                }


            }
            if(valid==false)
                try
                {
                    Restart();
                }
                catch (Exception)
                {

                    throw new FormatException("\nGone\n");

                }

            Console.WriteLine();
        }

        private void CreateMenu()
        {
            Console.WriteLine("1. Start the watch");
            Console.WriteLine("2. Stop the watch");
            Console.WriteLine("3. Duration");
            Console.WriteLine("4. Quit");
        }

        private void Operation(int operation)
        {
            switch (operation)
            {
                case 1:
                    watch.Start();
                    Console.WriteLine("\nThe watch has been started");
                    break;

                case 2:
                    watch.Stop();
                    Console.WriteLine("\nThe watch has been stopped");
                    break;

                case 3:
                    watch.Duration();
                    break;

                case 4:
                    Exit();
                    break;

                default:
                    Console.WriteLine("\nEnter a correct number");
                    break;
            }
        }

        private void Restart()
        {
            Console.WriteLine("\nAnother round? (1.Yes 2.No)");
            int selection = Convert.ToInt32(Console.ReadLine());
            RestartOp(selection);
        }

        private void RestartOp(int operation)
        {
            switch (operation)
            {
                case 1:
                    StartController();
                    break;

                case 2:
                    Exit();
                    break;
            }
        }

        private void Exit()
        {
            Console.WriteLine("\nApplication closes.");
            Environment.Exit(0);
        }
    }
}