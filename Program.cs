namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gm = new GameManager();

            do
            {
                RoundResult result = gm.Playground();

                if (result == RoundResult.Player1Win)
                {
                    System.Console.WriteLine("Player 1 wins");
                }
                else if (result == RoundResult.Player2Win)
                {
                    System.Console.WriteLine("Player 2 wins");
                }
                else
                {
                    System.Console.WriteLine("It's a draw!");
                }
                System.Console.Write("Play again (Y/N)? ");
            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}
