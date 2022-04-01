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
                    Console.Clear();
                    Screen.PrintChessboard(game.chess);

                    Console.Write("\nType origin:");
                    Position origin = Screen.readChessPosition().toPosition();

                    bool[,] possiblePositions = game.chess.piece(origin).possibleMoves();

                    Console.Clear();
                    Screen.PrintChessboard(game.chess, possiblePositions);


                    Console.Write("\nType destiny:");
                    Position destiny = Screen.readChessPosition().toPosition();

                    game.moveMaker(origin, destiny);
                }


            }
            catch (ChessboardException e)
            {
                System.Console.WriteLine(e.Message);
            }


        }

    }

}
