namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            title();
            int width;
            int height;
            int winLength;
            int menuSelection = myController.getInt("Select mode: \n1. Standard Dimensions \n2. Custom Dimensions", 1, 2);
            if (menuSelection == 1)
            {
                width = 3;
                height = 3;
                winLength = 3;
            } else
            {
                width = myController.getInt("Input Board Width: ", 2, 10);
                height = myController.getInt("Input Board Height: ", 2, 10);
                winLength = myController.getInt("Input How many X's or O's in a row you need in order to win: ", 2, Math.Min(width, height));
            }
            GameBoard TicTacToe = new GameBoard(width, height, winLength);
            string[] names = new string[2];
            names[0] = myController.getString("Input player 1 name: ");
            names[1] = myController.getString("Input player 2 name: ");
            bool gameInProgress = true;
            int turn = 0;
            char symbol;
            while (gameInProgress)
            {
                if (turn % 2 == 0)
                {
                    symbol = 'X';
                } else
                {
                    symbol = 'O';
                }
                TicTacToe.Display();
                Console.WriteLine($"Turn: {turn + 1}");
                Console.WriteLine($"{names[turn % 2]}'s turn");
                int[] selectedCel = myController.doTurn(TicTacToe);
                TicTacToe.PlacePiece(selectedCel, symbol);
                turn++;
                object?[] winStatus = TicTacToe.EndCheck(turn, selectedCel);
                if (winStatus[0].Equals(true))
                {
                    TicTacToe.Display();
                    if (winStatus[1] == null) {
                        Console.WriteLine("It's a tie!!");
                    } else
                    {
                        Console.WriteLine($"{symbol} wins!!");
                    }
                    break;
                }
            }
        }

        static void title()
        {
            Console.WriteLine("  _______         ______              ______         \r\n /_  __(_)____   /_  __/___ ______   /_  __/___  ___ \r\n  / / / / ___/    / / / __ `/ ___/    / / / __ \\/ _ \\\r\n / / / / /__     / / / /_/ / /__     / / / /_/ /  __/\r\n/_/ /_/\\___/    /_/  \\__,_/\\___/    /_/  \\____/\\___/ \r");
        }

        static void Scrap()
        {
            Console.WriteLine("Hello, World!");

            string[] playerNames = { "P1", "P2" };

            char[] playerSymbols = { 'X', 'O' };

            bool done = false;

            int turns = 0; //Current turn
            //int totalTurns = 0; //Tie when this reaches 9

            bool validInput = false;
            int chosenX;
            int chosenY;

            do
            {
                //Checks for valid input
                bool validRow = int.TryParse(Console.ReadLine(), out chosenX);
                bool validCol = int.TryParse(Console.ReadLine(), out chosenY);

            } while (!validInput);

            do
            {

                turns++;
            } while (!done);
        }
    }
}