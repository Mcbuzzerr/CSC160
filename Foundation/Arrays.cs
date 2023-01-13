using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Arrays
    {
        public static void Execute()
        {
            int[] myArray1 = new int[3];
            myArray1[0] = 55;
            myArray1[1] = 2;
            myArray1.SetValue(23, 2);

            int[] myArray2 = new int[] { 1, 3, 5, 7 };
            int[] myArray3 = { 2, 4, 6, 8 };

            for (int index = 0; index < myArray1.Length; index++) 
            {
                Console.WriteLine($"{myArray1[index]}");
            }

            foreach (int number in myArray1)
            {
                Console.WriteLine(number);
            }

            //Object array so any data type fits, Object is the base class for everything
            object[] myThings = new object[] { 10, "Junith", "Larry the Cucumber", 45.6f };

            string[,] alphabet = new string[2, 2] { { "A", "B" }, { "C", "D" } };
            
            for (int row=0; row < alphabet.GetLength(0); row++)
            {

            }

            //jagged array, specify rows, but columns can be any length
            int[][] jagged = new int[3][]; 
            jagged[0] = new int[] { 1, 2, 3, 4 };
            jagged[1] = new int[] { 9, 8, 7, 6, 5 };
            jagged[2] = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        }
    }
}
