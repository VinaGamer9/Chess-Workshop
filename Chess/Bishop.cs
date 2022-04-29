using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class Bishop : Piece
    {
        public Bishop(Chessb chessboard, Color color)
        : base(color, chessboard)
        {

        }
        public override string ToString()
        {
            return "B";
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

            //up-right
            pos.defineValues(position.rows - 1, position.columns + 1);
            while (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
                if (chessboard.piece(pos) != null && chessboard.piece(pos).color != this.color)
                {
                    break;
                }
                pos.rows -= 1;
                pos.columns += 1;
            }
            //up-left
            pos.defineValues(position.rows - 1, position.columns - 1);
            while (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
                if (chessboard.piece(pos) != null && chessboard.piece(pos).color != this.color)
                {
                    break;
                }
                pos.rows -= 1;
                pos.columns -= 1;
            }
            //down-left
            pos.defineValues(position.rows + 1, position.columns - 1);
            while (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
                if (chessboard.piece(pos) != null && chessboard.piece(pos).color != this.color)
                {
                    break;
                }
                pos.rows += 1;
                pos.columns -= 1;
            }
            //down-right 
            pos.defineValues(position.rows + 1, position.columns + 1);
            while (chessboard.positionValid(pos) && canMove(pos))
            {
                mat[pos.rows, pos.columns] = true;
                if (chessboard.piece(pos) != null && chessboard.piece(pos).color != this.color)
                {
                    break;
                }
                pos.rows += 1;
                pos.columns += 1;
            }
            return mat;
        }
    }
}