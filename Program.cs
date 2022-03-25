using System;
using Chess.Chessboard;
using Chess.Chessboard.Enums;
using Chess.ChessOnion;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessb chessboard = new Chessb(8, 8);

            chessboard.insertPiece(new Tower(Color.Black, chessboard), new Position(0, 0));
            chessboard.insertPiece(new Tower(Color.Black, chessboard), new Position(1, 3));
            chessboard.insertPiece(new King(Color.Black, chessboard), new Position(2, 4));

            Screen.PrintChessboard(chessboard);

            Console.ReadLine();
        }
    }
}