using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            // Set up new board
            var theBoard = new Dictionary<string, string>
            {
                {"top_L", " " },
                {"top_M", " " },
                {"top_R", " " },
                {"mid_L", " " },
                {"mid_M", " " },
                {"low_L", " " },
                {"low_M", " " },
                {"low_R", " " }
            };
        }
    }
}
