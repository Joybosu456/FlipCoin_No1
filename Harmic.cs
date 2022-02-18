using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipProb
{
    public class Harmic
    {
        public static void HarmicNumber()
        {
            int count, num;
            double sum = 0;
            Console.WriteLine("\n\n");
            Console.WriteLine("Calculate the sum of harmonic series :\n");
            Console.WriteLine("********************************");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the value of N :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");

            for (count = 1; count <= num; count++)
            {
                Console.WriteLine("1/{0} +", count);
                sum += 1 / (float)count;
            }
            Console.WriteLine("\n sum of series of {0} terms : {1} \n", num, sum);
            Console.ReadLine();
        }
    }
}
