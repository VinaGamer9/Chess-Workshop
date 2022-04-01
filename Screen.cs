using System;
using Chessboard;
using ChessOnion;

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
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static ChessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
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