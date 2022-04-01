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
        private bool canMove(Position pos)
        {
            Piece p = chessboard.piece(pos);
            return p == null || p.color != this.color;
        }
        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[chessboard.rows, chessboard.columns];

            Position pos = new Position(0, 0);

            //up
            pos.defineValues(position.rows - 1, position.columns);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            //up-right
            pos.defineValues(position.rows - 1, position.columns + 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            //up-left
            pos.defineValues(position.rows - 1, position.columns - 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            //left 
            pos.defineValues(position.rows, position.columns - 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            //right
            pos.defineValues(position.rows, position.columns + 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            //down
            pos.defineValues(position.rows + 1, position.columns);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            //down-left
            pos.defineValues(position.rows + 1, position.columns - 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            //down-right 
            pos.defineValues(position.rows + 1, position.columns + 1);
            if (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
            }
            return mat;
        }
    }
}