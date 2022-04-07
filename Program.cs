using System;
using Chessboard;
using Chessboard.Enums;
using ChessOnion;

namespace Chess
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {

                ChessGame game = new ChessGame();

                while (!game.fineshed)
                {
                    try
                    {
                        Console.Clear();
                        Screen.PrintChessboard(game.chess);
                        Console.WriteLine($"\nTurn: {game.turn} | Player: {game.currentPlayer}");

                        Console.Write("\nType origin:");
                        Position origin = Screen.readChessPosition().toPosition();
                        game.validOriginPosition(origin);

                        bool[,] possiblePositions = game.chess.piece(origin).possibleMoves();

                        Console.Clear();
                        Screen.PrintChessboard(game.chess, possiblePositions);


                        Console.Write("\nType destiny:");
                        Position destiny = Screen.readChessPosition().toPosition();

                        game.validDestinyPosition(origin, destiny);

                        game.moveMaker(origin, destiny);
                    }
                    catch (ChessboardException e)
                    {
                        Console.WriteLine("\n" + e.Message);
                        Console.ReadLine();
                    }

                }
            }


            catch (ChessboardException e)
            {
                System.Console.WriteLine(e.Message);
            }


        }

    }

}
