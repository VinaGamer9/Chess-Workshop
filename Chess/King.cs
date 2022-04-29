using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class King : Piece
    {
        private ChessGame game;
        public King(Chessb chessboard, Color color, ChessGame game)
        : base(color, chessboard)
        {
            this.game = game;
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
        private bool towerTestForRoque(Position pos)
        {
            Piece p = chessboard.piece(pos);
            return p != null && p is Tower && p.color == color && p.qtnMoves == 0;
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

            // # Special Move Roque

            if (qtnMoves == 0 && !game.check)
            {
                // #Special move menur Roque 
                Position posT1 = new Position(position.rows, position.columns + 3);
                if (towerTestForRoque(posT1))
                {
                    Position p1 = new Position(position.rows, position.columns + 1);
                    Position p2 = new Position(position.rows, position.columns + 2);
                    if (chessboard.piece(p1) == null && chessboard.piece(p2) == null)
                    {
                        mat[position.rows, position.columns + 2] = true;
                    }
                }
                // #Special move Biger Roque 
                Position posT2 = new Position(position.rows, position.columns - 4);
                if (towerTestForRoque(posT2))
                {
                    Position p1 = new Position(position.rows, position.columns - 1);
                    Position p2 = new Position(position.rows, position.columns - 2);
                    Position p3 = new Position(position.rows, position.columns - 3);
                    if (chessboard.piece(p1) == null && chessboard.piece(p2) == null && chessboard.piece(p3) == null)
                    {
                        mat[position.rows, position.columns - 2] = true;
                    }
                }
            }

            return mat;
        }
    }
}