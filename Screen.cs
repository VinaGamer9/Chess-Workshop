using System;
using Chessboard;

namespace Chess
{
    class Screen
    {
        public static void PrintChessboard(Chessb chessboard)
        {
            for (int i = 0; i < chessboard.Rows; i++)
            {
                for (int j = 0; j < chessboard.Columns; j++)
                {
                    if (chessboard.piece(i, j) == null)
                    { Console.Write("- "); }
                    else
                    {
                        Console.Write(chessboard.piece(i, j) + " ");
                    }
                }
                System.Console.WriteLine("");
            }
        }
    }
}