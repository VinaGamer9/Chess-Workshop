using System;

namespace Chess.Chessboard
{
    class ChessboardException : Exception
    {
        public ChessboardException(string msg) : base(msg) { }
    }
}