using System;

namespace Chessboard
{
    class ChessboardException : Exception
    {
        public ChessboardException(string msg) : base(msg) { }
    }
}