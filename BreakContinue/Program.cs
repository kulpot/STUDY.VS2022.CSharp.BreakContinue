using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            ////    Break
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if(counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }

            }
            Console.Read();
            ////   Continue
            for(int counter1 =0; counter1 < 10; counter1++)
            {
                if(counter1 %2 == 0)
                {
                    Console.WriteLine("Now comes an odd number!");
                    continue;
                }
                Console.WriteLine(counter1);
            }
            Console.ReadKey();
        }
    }
}