namespace Chessboard
{
    class Chessb
    {
        public int columns { get; set; }
        public int rows { get; set; }
        private Piece[,] pieces;

        public Chessb(int columns, int rows)
        {
            this.columns = columns;
            this.rows = rows;
            pieces = new Piece[this.rows, this.columns];
        }
        public Piece piece(int row, int column)
        {
            return pieces[row, column];
        }
        public Piece piece(Position pos)
        {
            return pieces[pos.rows, pos.columns];
        }
        public bool hasPiece(Position pos)
        {
            validPosition(pos);
            return piece(pos) != null;
        }
        public void insertPiece(Piece p, Position pos)
        {
            if (hasPiece(pos))
            { throw new ChessboardException("already another piece in this position"); }
            pieces[pos.rows, pos.columns] = p;
            p.position = pos;
        }
        public Piece removePiece(Position pos)
        {
            if (piece(pos) == null)
            {
                return null;
            }
            Piece aux = piece(pos);
            aux.position = null;
            pieces[pos.rows, pos.columns] = null;
            return aux;
        }
        public bool positionValid(Position pos)
        {
            if (pos.rows < 0 || pos.rows >= rows || pos.columns < 0 || pos.columns >= columns)
            {
                return false;
            }
            return true;
        }
        public void validPosition(Position pos)
        {
            if (!positionValid(pos))
            { throw new ChessboardException("Position Invalid"); }
        }
    }
}