using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    

    internal class GameBoard
    {
        char[,] board;
        int width;
        int height;
        int winLength;
        
        public GameBoard(int width = 3, int height = 3, int winLength = 3)
        {
            this.width = width;
            this.height = height;
            this.board = new char[this.width, this.height];
            this.winLength = winLength;
        }

        public void PlacePiece(int xPos, int yPos, char symbol)
        {
            this.board[xPos, yPos] = symbol;
        }

        public void PlacePiece(int[] pos, char symbol)
        {
            this.board[pos[0], pos[1]] = symbol;
        }

        public char GetVal(int xPos, int yPos)
        {
            return this.board[xPos, yPos];
        }

        public char GetVal(int[] pos)
        {
            return this.board[pos[0], pos[1]];
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

        public int GetWidth()
        {
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public object?[] EndCheck(int turns, int[] lastMove)
        {
            char debug;
            char symbol = this.GetVal(lastMove);
            int tokensInARow = 1;
            // Tie
            if (turns >= this.width * this.height)
            {
                return new object?[2] { true , null }; //Tie
            }

            //Horizontal
            for (int iter = 1; iter <= this.winLength; iter++)
            {
                if (lastMove[0] + iter < this.board.GetLength(0))
                {
                    debug = this.GetVal(lastMove[0] + iter, lastMove[1]);
                    if (this.GetVal(lastMove[0] + iter, lastMove[1]) == symbol)
                    {
                        tokensInARow++;
                    }
                } else if (lastMove[0] - iter >= 0)
                {
                    debug = this.GetVal(lastMove[0] - iter, lastMove[1]);
                    if (this.GetVal(lastMove[0] - iter, lastMove[1]) == symbol)
                    {
                        tokensInARow++;
                    }
                }
            }
            //Check if there is a horizontal win 
            if (tokensInARow < this.winLength) 
            {
                // If not, return tokensInARow to 1
                tokensInARow = 1;
            } 
            else
            {
                // Return win status
                return new object[] { true, symbol};
            }

            //Vertical
            for (int iter = 1; iter <= this.winLength; iter++)
            {
                if (lastMove[1] + iter < this.board.GetLength(1))
                {
                    debug = this.GetVal(lastMove[0], lastMove[1] + iter);
                    if (this.GetVal(lastMove[0], lastMove[1] + iter) == symbol)
                    {
                        tokensInARow++;
                    }
                }
                else if (lastMove[1] - iter >= 0)
                {

                    debug = this.GetVal(lastMove[0], lastMove[1] - iter);
                    if (this.GetVal(lastMove[0], lastMove[1] - iter) == symbol)
                    {
                        tokensInARow++;
                    }
                }
            }

            //Check if there is a vertical win 
            if (tokensInARow < this.winLength)
            {
                // If not, return tokensInARow to 1
                tokensInARow = 1;
            }
            else
            {
                // Return win status
                return new object[] { true, symbol };
            }

            //Diagonal
            for (int iter = 1; iter <= this.winLength; iter++)
            {
                if (
                    lastMove[0] + iter < this.board.GetLength(0) && 
                    lastMove[1] + iter < this.board.GetLength(1)
                    )
                {
                    if (this.GetVal(lastMove[0] + iter, lastMove[1] + iter) == symbol)
                    {
                        tokensInARow++;
                    }
                } 
                else if (
                    lastMove[0] - iter >= 0 && 
                    lastMove[1] - iter >= 0
                    )
                {
                    if (this.GetVal(lastMove[0] - iter, lastMove[1] - iter) == symbol)
                    {
                        tokensInARow++;
                    }
                }
                else if (
                    lastMove[0] + iter < this.board.GetLength(0) && 
                    lastMove[1] - iter >= 0
                    )
                {
                    if (this.GetVal(lastMove[0] + iter, lastMove[1] - iter) == symbol)
                    {
                        tokensInARow++;
                    }
                }
                else if (
                    lastMove[0] - iter >= 0 && 
                    lastMove[1] + iter < this.board.GetLength(1)
                    )
                {
                    if (this.GetVal(lastMove[0] - iter, lastMove[1] + iter) == symbol)
                    {
                        tokensInARow++;
                    }
                }
            }

            if (tokensInARow < this.winLength)
            {
                tokensInARow = 1;
                return new object[] { false, symbol };
            }
            else
            {
                return new object[] { true, symbol };
            }

            //No win
            
        }

        public void Display()
        {
            for (int j = -1; j < this.board.GetLength(1); j++) //j is the Y index
            {
                if (j == -1)
                {
                    string heading = " ";
                    for (int iter = 0; iter < this.board.GetLength(0); iter++)
                    {
                        heading += $"{iter + 1} ";
                    }
                    Console.WriteLine(heading);
                }
                else
                {
                    Console.Write($"{j+1}");
                    for (int i = 0; i < this.board.GetLength(0); i++) //i is the X index // I should have done better variable names but I don't wanna change them rn
                    {
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
                        string delineator = " ";
                        for (int count = 0; count < (this.board.GetLength(0) * 2) - 1; count++)
                        {
                            delineator += "-";
                        }
                        Console.WriteLine("\n" + delineator);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
