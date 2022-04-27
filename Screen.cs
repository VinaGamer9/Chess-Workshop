using System;
using Chessboard;
using ChessOnion;
using Chessboard.Enums;

namespace Chess
{
    class Screen
    {

        public static void printGame(ChessGame game)
        {
            Screen.PrintChessboard(game.chess);
            printCatchedPieces(game);

            if (!game.fineshed)
            {
                Console.WriteLine($"\nTurn: {game.turn} | Player: {game.currentPlayer}");

                if (game.check) { System.Console.WriteLine("CHECK"); }

            }
            else
            {
                Console.WriteLine($"\nCHECKMATE!!! \nWinner: {game.currentPlayer}");
            }
        }
        public static void printCatchedPieces(ChessGame game)
        {
            Console.WriteLine("Pieces catcheds: ");
            Console.Write("White: ");
            printHashSet(game.catchedPieces(Color.White));
            Console.Write("Black: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            printHashSet(game.catchedPieces(Color.Black));
            Console.ForegroundColor = aux;
        }
        public static void printHashSet(HashSet<Piece> hash)
        {
            Console.Write("[");
            foreach (Piece x in hash)
            {
                Console.Write(x + " ");
            }
            Console.Write("]\n");
        }

        public static void PrintChessboard(Chessb chessboard)
        {
            for (int i = 0; i < chessboard.rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < chessboard.columns; j++)
                {

                    printPiece(chessboard.piece(i, j));

                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void PrintChessboard(Chessb chessboard, bool[,] possiblePositions)
        {

            ConsoleColor defaulBackground = Console.BackgroundColor;
            ConsoleColor modifiedBackground = ConsoleColor.DarkGray;

            for (int i = 0; i < chessboard.rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < chessboard.columns; j++)
                {
                    if (possiblePositions[i, j])
                    {
                        Console.BackgroundColor = modifiedBackground;
                    }
                    else
                    { Console.BackgroundColor = defaulBackground; }

                    printPiece(chessboard.piece(i, j));
                    Console.BackgroundColor = defaulBackground;

                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = defaulBackground;
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
            if (piece == null) { System.Console.Write("- "); }
            else
            {

                if (piece.color == Color.White)
                { Console.Write(piece); }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }

        }


    }
}