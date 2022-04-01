using Chessboard;

namespace ChessOnion
{
    class ChessPosition
    {
        public int column { get; set; }
        public int row { get; set; }

        public ChessPosition(int column, int row)
        {
            this.column = column;
            this.row = row;
        }

        public Position toPosition()
        {
            return new Position(8 - row, column - 'a');
        }
        public override string ToString()
        {
            return "" + column + row;
        }

    }

}