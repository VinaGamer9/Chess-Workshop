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
        public void DecreaceQtnMoves()
        {
            qtnMoves--;
        }
        public bool PossibleMovesExist()
        {
            bool[,] mat = possibleMoves();
            for (int i = 0; i < chessboard.rows; i++)
            {
                for (int j = 0; j < chessboard.columns; j++)
                {
                    if (mat[i, j]) { return true; }
                }
            }
            return false;
        }
        public bool canMoveTo(Position pos)
        {
            return possibleMoves()[pos.rows, pos.columns];
        }

        public abstract bool[,] possibleMoves();

    }

}