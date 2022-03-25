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
    }
}