using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Parameters
    {
        public static void Execute()
        {
            int intRef = 8;
            int[] arry = new int[] { 6, 7, 8, 9 };
            string strByVal = "George";
            RefTest clsRT = new RefTest();
            clsRT.x = 1;
            int intValue = 99;
            int[] arry2 = new int[2];
            arry2 = arry;

            ByValRefTest(ref intRef, strByVal, arry, clsRT, intValue);
            Console.WriteLine($"Int ByRef: {intRef}");

            DefaultParam(intValue);
            DefaultParam();

            NamedFunction(1, 2);
            NamedFunction(y: 2, x: 1);
        }

        static void NamedFunction(int x, int y)
        {
            Console.WriteLine($"Named Param: {x} - {y}");
        }

        static void DefaultParam(int n = 20)
        {
            Console.WriteLine("DefaultParam: {0}", n);
        }

        public class RefTest
        {
            public int x;
        }

        public static void ByValRefTest(ref int xRef, string sVal, int[] arry, RefTest clsRefTest, int intValue)
        {
            xRef = xRef * xRef;
            sVal = "Spoont";
            arry[0] = 12;
            clsRefTest.x = 65;
            intValue = 23;
        }
    }
}
