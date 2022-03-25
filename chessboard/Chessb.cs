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
        public void insertPiece(Piece p, Position pos)
        {
            Pieces[pos.Rows, pos.Columns] = p;
            p.Position = pos;
        }
    }
}