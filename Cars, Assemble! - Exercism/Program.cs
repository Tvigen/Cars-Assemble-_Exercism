using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars__Assemble____Exercism
{
    static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            double successRate = 0;


            if (speed == 0)
            {
                return successRate = 0;
            }
            else if (speed > 0 && speed < 5)
            {
                return successRate = 1.00;
            }
            else if (speed >= 5 && speed < 9)
            {
                return successRate = 0.90;
            }
            else if (speed == 9)
            {
                return successRate = 0.80;
            }
            else
            {
                return successRate = 0.77;
            }
        }


        public static double ProductionRatePerHour(int speed)
        {
            return AssemblyLine.SuccessRate(speed) * speed * 221;
        }

        public static int WorkingItemsPerMinute(int speed)
        {
            return (int)(AssemblyLine.ProductionRatePerHour(speed) / 60);
        }
        public static void Main()
        {
            Console.WriteLine(AssemblyLine.SuccessRate(5));
            Console.WriteLine(ProductionRatePerHour(5));
            Console.WriteLine(WorkingItemsPerMinute(5));
            Console.ReadKey();
        }
    }
    
}
