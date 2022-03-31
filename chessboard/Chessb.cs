namespace Chess.Chessboard
{
    class Chessb
    {
        public int Columns { get; set; }
        public int Rows { get; set; }
        private Piece[,] Pieces;

        public Chessb(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;
            Pieces = new Piece[Rows, Columns];
        }
        public Piece piece(int row, int column)
        {
            return Pieces[row, column];
        }
        public Piece piece(Position pos)
        {
            return Pieces[pos.Rows, pos.Columns];
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
            Pieces[pos.Rows, pos.Columns] = p;
            p.Position = pos;
        }
        public bool positionValid(Position pos)
        {
            if (pos.Rows < 0 || pos.Rows > Rows || pos.Columns < 0 || pos.Columns > Columns)
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