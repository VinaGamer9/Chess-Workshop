using Chess.Chessboard;
using Chess.Chessboard.Enums;

namespace Chess.ChessOnion
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