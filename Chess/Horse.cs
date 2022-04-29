using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class Horse : Piece
    {
        public Horse(Chessb chessboard, Color color)
        : base(color, chessboard)
        {

        }
        public override string ToString()
        {
            return "H";
        }
        private bool canMove(Position pos)
        {
            Piece p = chessboard.piece(pos);
            return p == null || p.color != this.color;
        }
        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[chessboard.rows, chessboard.columns];

            Position pos = new Position(0, 0);

            pos.defineValues(position.rows - 1, position.columns - 2);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows - 2, position.columns - 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows - 2, position.columns + 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows - 1, position.columns + 2);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows + 1, position.columns + 2);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows + 2, position.columns + 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows - 1, position.columns - 2);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows - 2, position.columns - 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows + 1, position.columns - 2);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            pos.defineValues(position.rows + 2, position.columns - 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            return mat;
        }
    }
}