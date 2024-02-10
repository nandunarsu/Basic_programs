using System;


namespace Arithmetic
{
    class prime
    {
        static void Main()
        {

            Console.WriteLine("Enter the number:");
            int x = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (x <= 1)
            {
                isPrime = false;

            }
            else
            {

                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if(isPrime)
            {
                Console.WriteLine($"The number {x} is Prime " + x);
            }
            else
            {
                Console.WriteLine("The number is not Prime " + x);
            }
        }
    }
}