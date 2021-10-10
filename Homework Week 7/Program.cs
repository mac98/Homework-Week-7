using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code to test the Counter Class.");
            Counter c_test = new Counter();
            bool run = true;
            while (run)
            {
                Console.WriteLine("The counter is currently at " + c_test.ToString() + ". Would you like to");

                Console.WriteLine("1 - Increment the counter?");
                Console.WriteLine("2 - Decrement the counter?");
                Console.WriteLine("3 - Display the counter?");
                Console.WriteLine("4 - Get the counter?");
                Console.WriteLine("5 - Compare the counter to something?");
                Console.WriteLine("6 - Reset the counter?");
                Console.WriteLine("7 - Exit the application?");
                Console.WriteLine("Enter the number of the operation you would like to perform:");

                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input < 1)
                        Console.WriteLine("ERROR: Please enter a positive whole number.");
                    else
                    {
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("Incrementing the count...");
                                c_test.Increment();
                                break;
                            case 2:
                                Console.WriteLine("Decrementing the count...");
                                c_test.Decrement();
                                break;
                            case 3:
                                c_test.DisplayCount();
                                break;
                            case 4:
                                Console.WriteLine("Getting the count...");
                                Console.WriteLine("The counter is " + c_test.GetCounter() + ", and the counter plus 5 is " + (c_test.GetCounter() + 5) + ".");
                                break;
                            case 5:
                                bool another_run = true;
                                while (another_run)
                                {
                                    Console.WriteLine("Enter a whole number to compare:");
                                    try
                                    {
                                        input = int.Parse(Console.ReadLine());
                                        another_run = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("ERROR: Enter a whole number.");
                                        another_run = true;
                                    }
                                }
                                if (c_test.Equals(input))
                                {
                                    Console.WriteLine(input + " is equal to the counter (" + c_test.GetCounter() + ")!");
                                }
                                else
                                {
                                    Console.WriteLine(input + " is not equal to the counter (" + c_test.GetCounter() + ").");
                                }
                                break;
                            case 6:
                                Console.WriteLine("Resetting the count...");
                                c_test.ResetCounter();
                                break;
                            case 7:
                                Console.WriteLine("Exiting program. Hit ENTER to continue.");
                                Console.Read();
                                run = false;
                                break;
                            default:
                                break;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Please enter a positive whole number.");
                }
                catch
                {
                    Console.WriteLine("ERROR: An unknown error has occurred. Terminating program");
                    Console.Read();
                    run = false;
                }
                
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
            }
        }
    }

    public class Counter
    {
        private int count;
        public Counter()
        {
            ResetCounter();
        }

        public void ResetCounter()
        {
            count = 0;
        }

        public void Increment()
        {
            count++;
        }

        public void Decrement()
        {
            count--;
            if (count < 0) count = 0;
        }

        public void DisplayCount()
        {
            Console.WriteLine("The counter is at " + count.ToString() + ".");
        }

        public int GetCounter()
        {
            return count;
        }

        public override string ToString()
        {
            return "" + count;
        }

        public bool Equals(int value)
        {
            return (value == count);
        }
    }
}
