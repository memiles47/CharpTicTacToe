using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class GameMechanics
    {
        public readonly Dictionary<string, string> NewBoard = new Dictionary<string, string>
        {
            {"top_L", " "}, {"top_M", " "}, {"top_R", " "},
            {"mid_L", " "}, {"mid_M", " "}, {"mid_R", " "},
            {"low_L", " "}, {"low_M", " "}, {"low_R", " "}
        };

        public Dictionary<int, string> playerNames = new Dictionary<int, string>
        {
            {1, ""},
            {2, ""}
        };

        public void EnterPlayers(Dictionary<int, string> names)
        {
            for (var i = 1; i < 3; i++)
            {
                Console.Write($"Enter name for player {i}: ");
                names[i] = Console.ReadLine();
            }
            Console.Clear();
        }

        public void PrintBoard(Dictionary<string, string> board)
        {
            Console.WriteLine("-------------");
            Console.WriteLine($"| {board["top_L"]} | {board["top_M"]} | {board["top_R"]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {board["mid_L"]} | {board["mid_M"]} | {board["mid_R"]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {board["low_L"]} | {board["low_M"]} | {board["low_R"]} |");
            Console.WriteLine("-------------\n\n");
        }
    }
}    