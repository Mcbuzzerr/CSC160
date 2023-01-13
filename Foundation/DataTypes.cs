using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class DataTypes
    {
        public static void Execute()
        {
            short myShort = 23498; //16 bits WOWZA
            int myInt = 10; //32 bits WOWOWOWA
            uint myuInt = 456; //32 bits (unsigned) can't go negative, can go bigger than reg int?
            long myLong = 444; //64 bits
            float myFloat = 234.99f; //4 bytes
            double myDouble = 234.6; //8 bytes
            decimal myDecimal = 230.045M; //16 bytes

            Console.WriteLine("Short Min: {0}", short.MinValue);
            Console.WriteLine("Short Max: {0}", short.MaxValue);
            Console.WriteLine();

            Console.WriteLine("int Min: {0}", int.MinValue);
            Console.WriteLine("int Max: {0}", int.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Uint Min: {0}", uint.MinValue);
            Console.WriteLine("Uint Max: {0}", uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine("long Min: {0}", long.MinValue);
            Console.WriteLine("long Max: {0}", long.MaxValue);
            Console.WriteLine();

            Console.WriteLine("double Min: {0}", double.MinValue);
            Console.WriteLine("double Max: {0}", double.MaxValue);
            Console.WriteLine();

            Console.WriteLine("float Min: {0}", float.MinValue);
            Console.WriteLine("float Max: {0}", float.MaxValue);
            Console.WriteLine();

            Console.WriteLine("decimal Min: {0}", decimal.MinValue);
            Console.WriteLine("decimal Max: {0}", decimal.MaxValue);
            Console.WriteLine();

            char c = 'W';
            Console.WriteLine("Char is: {0}", c);
            Console.WriteLine("IsDigit: {0}", char.IsDigit(c));
            Console.WriteLine("IsLetter: {0}", char.IsLetter(c));
        }
        
    }
}
