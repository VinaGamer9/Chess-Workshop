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
                ChessPosition pos = new ChessPosition('c', 7);

                Console.WriteLine(pos);

                Console.WriteLine(pos.toPosition());
            }
            catch (ChessboardException e) { Console.WriteLine(e.Message); }
        }
    }
}