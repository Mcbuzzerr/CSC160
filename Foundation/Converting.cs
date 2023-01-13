using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Converting
    {
        public static void Execute()
        {
            //implicit conversion because a long is bigger than an int
            int i = 234234;
            long l = i;
            Console.WriteLine(l);
            Console.WriteLine("Type: {0}", l.GetType());
            char c = 'c';
            var v = c;
            Console.WriteLine(v);
            Console.WriteLine("Type: {0}", v.GetType());

            //explicit conversion
            double d = 231.34;
            int i2;

            i2 = (int)d;

            string s = "5";
            //i = s;
            bool bSuccess = int.TryParse(s, out i2);
            Console.WriteLine(s + " converts to int? " + bSuccess);
        }

        public static bool IsNumeric(string strNumber)
        {
            double dblIsNumber;
            return double.TryParse(strNumber, out dblIsNumber);
        }
    }
}
