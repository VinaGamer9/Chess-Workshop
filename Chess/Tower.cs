using Chess.Chessboard;
using Chess.Chessboard.Enums;

namespace Chess.ChessOnion
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