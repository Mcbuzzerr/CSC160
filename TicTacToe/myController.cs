using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class myController
    {
        public static int[] doTurn(GameBoard board)
        {
            bool validSelection = false;
            int selectedX;
            int selectedY;
            do
            {
                selectedX = getInt("Input X position: ", 1, board.GetWidth()) - 1;
                selectedY = getInt("Input Y position: ", 1, board.GetHeight()) - 1;

                if (board.isNull(selectedX, selectedY))
                {
                    validSelection = true;
                } else
                {
                    validSelection = false;
                    Console.WriteLine("Invalid coordinates");
                }
            } while (!validSelection);
            return new int[] { selectedX, selectedY};
        }
        public static int getInt(string prompt, int min, int max)
        {
            bool validSelection = false;
            int result = 0;
            do
            {
                Console.WriteLine(prompt + $" (Min: {min} - Max: {max})");
                bool validInt = int.TryParse(Console.ReadLine(), out result);
                if (validInt)
                {
                    result = Math.Clamp(result, min, max);
                    validSelection = true;
                }
            } while(!validSelection);
            return result;
        }

        public static string getString(string prompt)
        {
            Console.WriteLine(prompt);
            string result;
            bool isValid = false;
            do
            {
                result = Console.ReadLine();
                if (result != null && result.Length > 0)
                {
                    isValid = true;
                } else
                {
                    Console.WriteLine("Invalid input, try again: ");
                }
            } while (!isValid);
                
            return result;
        }
    }
}
