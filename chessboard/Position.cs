namespace Chessboard
{
    class Position
    {
        public int columns { get; set; }
        public int rows { get; set; }

        public Position(int rows, int columns)
        {
            this.columns = columns;
            this.rows = rows;
        }
        public override string ToString()
        {
            return $"rows:{rows}, columns:{columns}";
        }
    }
}