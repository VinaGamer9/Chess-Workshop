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
            while (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
                if (chessboard.piece(pos) != null && chessboard.piece(pos).color != this.color)
                {
                    break;
                }
                pos.rows -= 1;
            }
            //up 
            pos.defineValues(position.rows + 1, position.columns);
            while (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
                if (chessboard.piece(pos) != null && chessboard.piece(pos).color != this.color)
                {
                    break;
                }
                pos.rows += 1;
            }
            //right 
            pos.defineValues(position.rows, position.columns + 1);
            while (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
                if (chessboard.piece(pos) != null && chessboard.piece(pos).color != this.color)
                {
                    break;
                }
                pos.columns += 1;
            }
            //left 
            pos.defineValues(position.rows, position.columns - 1);
            while (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
                if (chessboard.piece(pos) != null && chessboard.piece(pos).color != this.color)
                {
                    break;
                }
                pos.columns -= 1;
            }
            return mat;

        }
    }
}