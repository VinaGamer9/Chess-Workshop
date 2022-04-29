using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class Pawn : Piece
    {
        private ChessGame game;
        public Pawn(Chessb chessboard, Color color, ChessGame game)
        : base(color, chessboard)
        {
            this.game = game;
        }
        public override string ToString()
        {
            return "P";
        }

        private bool existEnimy(Position pos)
        {
            Piece p = chessboard.piece(pos);
            return p != null && p.color != color;
        }
        private bool free(Position pos)
        {
            return chessboard.piece(pos) == null;
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

            if (color == Color.White)
            {
                //up 
                pos.defineValues(position.rows - 1, position.columns);
                if (chessboard.positionValid(pos) && free(pos))
                {
                    mat[pos.rows, pos.columns] = true;
                }
                //up 
                pos.defineValues(position.rows - 2, position.columns);
                if (chessboard.positionValid(pos) && qtnMoves == 0)
                {
                    mat[pos.rows, pos.columns] = true;
                }

                pos.defineValues(position.rows - 1, position.columns - 1);
                if (chessboard.positionValid(pos) && existEnimy(pos))
                {
                    mat[pos.rows, pos.columns] = true;
                }
                pos.defineValues(position.rows - 1, position.columns + 1);
                if (chessboard.positionValid(pos) && existEnimy(pos))
                {
                    mat[pos.rows, pos.columns] = true;
                }

                // Special Move en Passant 
                if (position.rows == 3)
                {
                    Position left = new Position(position.rows, position.columns - 1);
                    if (chessboard.positionValid(left) && existEnimy(left)
                        && chessboard.piece(left) == game.vulnerableEnPassant)
                    {
                        mat[left.rows - 1, left.columns] = true;
                    }
                    Position right = new Position(position.rows, position.columns + 1);
                    if (chessboard.positionValid(right) && existEnimy(right)
                        && chessboard.piece(right) == game.vulnerableEnPassant)
                    {
                        mat[right.rows - 1, right.columns] = true;
                    }
                }

            }
            else
            {
                pos.defineValues(position.rows + 1, position.columns);
                if (chessboard.positionValid(pos) && free(pos))
                {
                    mat[pos.rows, pos.columns] = true;
                }
                //up 
                pos.defineValues(position.rows + 2, position.columns);
                if (chessboard.positionValid(pos) && qtnMoves == 0)
                {
                    mat[pos.rows, pos.columns] = true;
                }

                pos.defineValues(position.rows + 1, position.columns + 1);
                if (chessboard.positionValid(pos) && existEnimy(pos))
                {
                    mat[pos.rows, pos.columns] = true;
                }
                pos.defineValues(position.rows + 1, position.columns - 1);
                if (chessboard.positionValid(pos) && existEnimy(pos))
                {
                    mat[pos.rows, pos.columns] = true;
                }
                // Special Move en Passant 
                if (position.rows == 4)
                {
                    Position left = new Position(position.rows, position.columns - 1);
                    if (chessboard.positionValid(left) && existEnimy(left)
                        && chessboard.piece(left) == game.vulnerableEnPassant)
                    {
                        mat[left.rows + 1, left.columns] = true;
                    }
                    Position right = new Position(position.rows, position.columns + 1);
                    if (chessboard.positionValid(right) && existEnimy(right)
                        && chessboard.piece(right) == game.vulnerableEnPassant)
                    {
                        mat[right.rows + 1, right.columns] = true;
                    }
                }

            }

            return mat;
        }


    }
}
