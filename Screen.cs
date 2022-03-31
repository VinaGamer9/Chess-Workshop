using System;
using Chessboard;

namespace Chess
{
    class Screen
    {
        public static void PrintChessboard(Chessb chessboard)
        {
            for (int i = 0; i < chessboard.rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < chessboard.columns; j++)
                {
                    if (chessboard.piece(i, j) == null)
                    { Console.Write("- "); }
                    else
                    {
                        printPiece(chessboard.piece(i, j));
                        Console.Write(" ");
                    }
                }
                System.Console.WriteLine("");
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void printPiece(Piece piece)
        {
            if (piece.color == Chessboard.Enums.Color.White)
            { Console.Write(piece); }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }

        }
    }
}