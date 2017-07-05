using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main()
        {
            var gameMechanics = new GameMechanics();
            var gameBoard = gameMechanics.NewBoard;
            var players = gameMechanics.playerNames;

            gameMechanics.EnterPlayers(players);
            gameMechanics.PrintBoard(gameBoard);

            foreach (var name in players)
            {
                Console.WriteLine(name);
            }
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }
}
