namespace Chessboard
{
    class Position
    {
        public int Columns { get; set; }
        public int Rows { get; set; }

        public Position(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;
        }
        public override string ToString()
        {
            return $"Position: {Columns}, {Rows}";
        }
    }
}