using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class dowhileloop
    {
        public void dowhilemethod()
        {
            int count = 0;

            do
            {
                
                Console.WriteLine("Count " + count);
                count++;
            } while (count < 4);
        }
    }
}
