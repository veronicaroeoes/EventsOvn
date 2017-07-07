using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOvn1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            numberGenerator.Even += NumberGenerator_Even;

            numberGenerator.Start();
        }

        private static void NumberGenerator_Even(int i, bool isEven)
        {
            Console.WriteLine($"{i} is even");
        }
    }
}
