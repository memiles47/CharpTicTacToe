﻿using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main()
        {
            var gameSetup = new GameSetup();
            var gameBoard = gameSetup.NewBoard;
            var players = gameSetup.PlayerNames;
            var gameMechanics = new GameMechanics();

            gameSetup.EnterPlayers(players);
            gameSetup.PrintBoard(gameBoard);

            foreach (var name in players)
                Console.WriteLine(name);

            Console.WriteLine(gameMechanics.WinLoseDraw("Mike"));

            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }
}
