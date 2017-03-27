using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCMApplication
{
    class Program
    {
        static void Main(string[] args)
        {
         //Declare the min and Max values of this project
            const int minValue = 2;
            const int maxValue = 20;

         //Set Min value = to a variable
            var minLCM = minValue;

         //Set up the for loop and the counter = 20, set minNum = LCM and Write Line
                for (var i = minValue; i <= maxValue; i++)
                    {
                minLCM = lowestMultiple(minLCM, i);
                    }

                Console.WriteLine(minLCM);
                Console.ReadLine();
            }

        //Ensures that if b = null then a is OK and return
        private static int getAnswer(int a, int b)
            {
                return b == 0 ? a : getAnswer(b, a % b);
            }

        //Returns a / getAnswer from above
            private static int lowestMultiple(int a, int b)
            {
                return a / getAnswer(a, b) * b;
            }
        }
    }
}
