namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameBoard TicTacToe = new GameBoard(5, 5);
            bool gameInProgress = true;
            while (gameInProgress)
            {
                TicTacToe.Display();

                myController.doTurn(TicTacToe);

            }
        }

        static void Scrap()
        {
            Console.WriteLine("Hello, World!");

            string[] playerNames = { "P1", "P2" };

            char[] playerSymbols = { 'X', 'O' };

            bool done = false;

            int turns = 0; //Current turn
            int totalTurns = 0; //Tie when this reaches 9

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