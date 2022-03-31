using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class King : Piece
    {
        public King(Color color, Chessb chessboard)
        : base(color, chessboard)
        {

        }
        public override string ToString()
        {
            return "K";
        }
    }
}