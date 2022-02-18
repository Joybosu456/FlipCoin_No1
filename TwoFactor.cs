using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipProb
{
    public class TwoFactor
    {
        public static void TwoFactorSeries()
        {
            static void Main(string[] args)
            {
                int num, power;
                Console.WriteLine("Enter the number :");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number1 :");
                power = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer is : " + powe(num, power));
                Console.ReadLine();

            }
            //Recurcive Method
            public static int powe(int num, int power)
            {
                if (power == 0)
                    return 1;
                return num * powe(num, --power);
            }
        }

        
    }
}

