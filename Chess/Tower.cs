using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class Tower : Piece
    {
        public Tower(Chessb chessboard, Color color)
        : base(color, chessboard)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}