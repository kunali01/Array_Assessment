using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssessment
{
    internal class CountEven
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenCount = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine("Number of even elements: " + evenCount);
        }
    }
}
