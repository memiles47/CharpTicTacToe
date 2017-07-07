using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main()
        {
            var gameSetup = new GameSetup();
            var gameBoard = gameSetup.NewBoard;
            var players = gameSetup.PlayerNames;

            gameSetup.EnterPlayers(players);
            gameSetup.PrintBoard(gameBoard);

            foreach (var name in players)
                Console.WriteLine(name);

            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }

    public class gameMechanics
    {
        //Win/Lose/Draw
        //Playermove
    }
}
