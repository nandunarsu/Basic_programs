using System;
namespace Arithmetic
{
    class Arith
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int sum = x + y;
            Console.WriteLine("sum:" + sum);
            int diff = x - y;
            Console.WriteLine("Difference:" + diff);
            int pro = x * y;
            Console.WriteLine("Product:" + pro);
            double div = x / y;
            Console.WriteLine("Division:" + div);


            //switch1 obj1 = new switch1();
            // obj1.Switchmethod();

            //whileloop obj2 = new whileloop();
            //obj2.looping();

            //dowhileloop obj3 = new dowhileloop();
            //obj3.dowhilemethod();

        }
    }

}
