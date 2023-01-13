using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class ValueReference
    {
        public static void Execute()
        {
            //value type
            int v1 = 324;
            int v2 = v1;
            v1 = 5;
            Console.WriteLine(v2);
            Console.WriteLine(v1);

            //reference type
            int[] ary1 = { 1, 2, 3 };
            int[] ary2 = ary1;
            ary1[0] = 5;
            Console.WriteLine("ary1: {0}", String.Join(", ", ary1));
            Console.WriteLine("ary2: {0}", String.Join(", ", ary2));

            Point p1 = new Point(1,2);
            Point p2 = p1;
            p1.x = 3;
            p2.y = 4;

            p1.Write();
            p2.Write();
        }

        struct Point //struct or class, struct is accessed by value, class is accessed by reference
        {
            public int x; 
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Write()
            {
                Console.WriteLine($"{x} - {y}");
            }
        }
    }
}
