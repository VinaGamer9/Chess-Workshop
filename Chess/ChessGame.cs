using System;
using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class ChessGame
    {

        public Chessb chess { get; private set; }
        private int turn;
        private Color currentPlayer;
        public bool fineshed { get; private set; }

        public ChessGame()
        {
            chess = new Chessb(8, 8);
            turn = 1;
            currentPlayer = Color.White;
            setPieces();
            fineshed = false;
        }

        public void moveMaker(Position origin, Position destiny)
        {
            Piece p = chess.removePiece(origin);
            p.increaceQtnMoves();
            Piece catchedPiece = chess.removePiece(destiny);
            chess.insertPiece(p, destiny);

        }
        public void setPieces()
        {
            Console.WriteLine(new ChessPosition('c', 3).toPosition());
            chess.insertPiece(new Tower(chess, Color.White), new ChessPosition('c', 1).toPosition());
            chess.insertPiece(new Tower(chess, Color.White), new ChessPosition('c', 2).toPosition());
            chess.insertPiece(new Tower(chess, Color.White), new ChessPosition('d', 2).toPosition());
            chess.insertPiece(new Tower(chess, Color.White), new ChessPosition('e', 1).toPosition());
            chess.insertPiece(new Tower(chess, Color.White), new ChessPosition('e', 2).toPosition());
            chess.insertPiece(new King(chess, Color.White), new ChessPosition('d', 1).toPosition());

            chess.insertPiece(new Tower(chess, Color.Black), new ChessPosition('c', 7).toPosition());
            chess.insertPiece(new Tower(chess, Color.Black), new ChessPosition('c', 8).toPosition());
            chess.insertPiece(new Tower(chess, Color.Black), new ChessPosition('d', 7).toPosition());
            chess.insertPiece(new Tower(chess, Color.Black), new ChessPosition('e', 7).toPosition());
            chess.insertPiece(new Tower(chess, Color.Black), new ChessPosition('e', 8).toPosition());
            chess.insertPiece(new King(chess, Color.Black), new ChessPosition('d', 8).toPosition());

        }
    }
}