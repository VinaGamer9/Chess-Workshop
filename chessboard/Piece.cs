using Chessboard.Enums;

namespace Chessboard
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtnMoves { get; private set; }
        public Chessb Chessboard { get; protected set; }

        public Piece(Color color, Chessb chessboard)
        {
            Position = null;
            Color = color;
            Chessboard = chessboard;
            QtnMoves = 0;
        }

    }

}