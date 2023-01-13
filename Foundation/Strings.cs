using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Strings
    {
        public static void Execute()
        {
            Console.WriteLine("What is your name? ");

            Console.Write(">");
            string strName = Console.ReadLine();
            // 3 ways to format strings
            Console.WriteLine("Heya " + strName + " glad to meet you!"); // String concatonation
            Console.WriteLine("Hiya {0}, I gotta say your name 3 times!", strName); // String interpolation
            Console.WriteLine($"Howdy {strName}, I'm glad to have said your name"); // String injection

            string strNeu = "Neumont College of Computer Science";
            Console.WriteLine(strNeu);
        
            Console.WriteLine("Length: {0}", strNeu.Length);
            Console.WriteLine("Contains 'of': {0}", strNeu.Contains("of"));
            int indexof = strNeu.IndexOf("of");
            Console.WriteLine("IndexOf Position: {0}", indexof == -1 ? "Not Found" : indexof.ToString());

            Console.WriteLine("Remove {0}", strNeu.Remove(indexof, 3));

            //StringBuilder is the fast way to make strings via lopos
            StringBuilder sb = new StringBuilder();
            sb.Append(strNeu);
            sb.Append(" is kinda");
            sb.Append(" doodoo");

            Console.WriteLine("StringBuilder: {0}", sb.ToString());




        }
    }
}
