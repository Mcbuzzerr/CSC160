using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    

    internal class GameBoard
    {
        char[,] board;
        int winLength;
        
        public GameBoard(int width = 3, int height = 3, int winLength = 3)
        {
            this.board = new char[width, height];
            this.winLength = winLength;
        }

        public void PlacePiece(int xPos, int yPos, char symbol)
        {
            this.board[xPos, yPos] = symbol;
        }

        public char GetVal(int xPos, int yPos)
        {
            return this.board[xPos, yPos];
        }

        public bool isNull(int xPos, int yPos)
        {
            if (this.board[xPos, yPos].Equals('O') || this.board[xPos, yPos].Equals('X')) {
                return false;
            } else
            {
                return true;
            }
        }

        public void Display()
        {
            for (int j = 0; j < this.board.GetLength(1); j++)
            {

                for (int i = 0; i < this.board.GetLength(0); i++)
                {
                    //Console.WriteLine(this.board.GetLength(0));
                    if (this.board[i, j].Equals('O') || this.board[i, j].Equals('X'))
                    {
                        
                        Console.Write(this.board[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    if (i < this.board.GetLength(0) - 1)
                    {
                        Console.Write("|");
                    }
                }
                if (j < this.board.GetLength(1) - 1)
                {
                    string delineator = "";
                    for (int count = 0; count < (this.board.GetLength(0) * 2) - 1; count++)
                    {
                        delineator += "-";
                    }
                    Console.WriteLine("\n" + delineator);
                }
            }
        }
    }
}
