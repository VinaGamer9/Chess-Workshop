using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class Tower : Piece
    {
        public Tower(Color color, Chessb chessboard)
        : base(color, chessboard)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}