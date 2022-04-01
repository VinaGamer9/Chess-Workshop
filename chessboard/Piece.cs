using Chessboard.Enums;

namespace Chessboard
{
    abstract class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int qtnMoves { get; private set; }
        public Chessb chessboard { get; protected set; }

        public Piece(Color color, Chessb chessboard)
        {
            position = null;
            this.color = color;
            this.chessboard = chessboard;
            qtnMoves = 0;
        }
        public void increaceQtnMoves()
        {
            qtnMoves++;
        }

        public abstract bool[,] possibleMoves();

    }

}