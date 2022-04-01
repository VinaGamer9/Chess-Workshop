using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class King : Piece
    {
        public King(Chessb chessboard, Color color)
        : base(color, chessboard)
        {

        }
        public override string ToString()
        {
            return "K";
        }
    }
}