using System;

namespace Arithmetic
{
    class whileloop
    {
        public void looping()
        {
            Console.WriteLine("Enter the value");
            int x = int.Parse(Console.ReadLine());

            while (x > 2)
            {
            Console.WriteLine("The values are :" + x);
                x--;
            }
        }

    }
}
