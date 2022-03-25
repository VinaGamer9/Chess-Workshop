using Chess.Chessboard.Enums;

namespace Chess.Chessboard
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtnMoves { get; private set; }
        public Chessb Chessboard { get; protected set; }

        public Piece(Position position, Color color, Chessb chessboard)
        {
            Position = position;
            Color = color;
            Chessboard = chessboard;
            QtnMoves = 0;
        }

    }

}