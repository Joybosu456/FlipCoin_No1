using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipProb
{
    internal class FlipProb
    {
        public static void FlipThecoin()
        {
            Console.WriteLine("Please enter the value of number of flips :");

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;  
            int FlipProb=Convert.ToInt32(Console.ReadLine());

            if(FlipProb>0)
            {
                for(int i=0;i<FlipProb; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    if(number == 1)
                    {
                        Head = 1;
                        HeadCount += Head;
                    }
                    else if(number == 0)
                    {
                        Tail = 1;
                        TailCount+=Tail;
                        Console.WriteLine(number);
                    }
                    Console.WriteLine("......................");

                    HeadPercentage = HeadCount * 100 / FlipProb;
                    TailPercentage = TailCount * 100 / FlipProb;

                    Console.WriteLine("Head Percentage :" + HeadPercentage);
                    Console.WriteLine("Tail percentage :" + TailPercentage);

                }
                
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
