using System;
using Chess.Chessboard;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessb chessboard = new Chessb(8, 8);

            Screen.PrintChessboard(chessboard);

            Console.ReadLine();
        }
    }
}