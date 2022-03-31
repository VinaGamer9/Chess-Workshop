namespace Chessboard
{
    class Position
    {
        public int columns { get; set; }
        public int rows { get; set; }

        public Position(int columns, int rows)
        {
            this.columns = columns;
            this.rows = rows;
        }
        public override string ToString()
        {
            return $"Position: {columns}, {rows}";
        }
    }
}