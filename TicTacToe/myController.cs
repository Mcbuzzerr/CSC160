using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class myController
    {
        public static Array doTurn(GameBoard board)
        {
            bool validSelection = false;
            int selectedX;
            int selectedY;
            do
            {
                bool validX = int.TryParse(Console.ReadLine(), out selectedX);
                bool validY = int.TryParse(Console.ReadLine(), out selectedY);

                if ((validX && validY) && board.isNull(selectedX, selectedY))
                {
                    validSelection = true;
                }
            } while (!validSelection);
            return new int[] { selectedX, selectedY};
        }
    }
}
