using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOvn1
{
    public class NumberGenerator
    {
        static Random random = new Random();

        public event Action<int, bool> Even;

        public void Start()
        {
            int[] randomNumbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                randomNumbers[i] = random.Next(1, 1001);
                // Console.WriteLine(randomNumbers[i]);
                if (randomNumbers[i] % 2 == 0)
                {
                    Even?.Invoke(randomNumbers[i], true);
                }
            }
        }
    }
}
