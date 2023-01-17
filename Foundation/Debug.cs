using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Debug
    {
        public static void Execute()
        {
            short i = 0;
            double total = 0;
            int[] ary = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 59482932 };
            string strTotal;

            for (i = 0; i < ary.GetLength(0); i++)
            {
                total = total + System.Math.Pow(ary[i], 2);
                total = InnerFunction(total);
            }
        }

        public static double InnerFunction(double d)
        {
            char c = (char)d;
            string s = c.ToString();
            return d + d;
        }
    }
}
