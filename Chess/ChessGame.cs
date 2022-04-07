using System;
using Chessboard;
using Chessboard.Enums;

namespace ChessOnion
{
    class ChessGame
    {

        public Chessb chess { get; private set; }
        public int turn { get; private set; }
        public Color currentPlayer { get; private set; }

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
            performsMove(origin, destiny);

        }
        public void performsMove(Position origin, Position destiny)
        {
            turn++;
            changePlayer();
        }
        private void changePlayer()
        {
            if (currentPlayer == Color.White) { currentPlayer = Color.Black; }
            else { currentPlayer = Color.White; }
        }
        public void validOriginPosition(Position pos)
        {
            if (chess.piece(pos) == null)
            {
                throw new ChessboardException("must select a piece for moves");
            }
            if (currentPlayer != chess.piece(pos).color)
            {
                throw new ChessboardException("The pice selected is not yours");
            }
            if (!chess.piece(pos).PossibleMovesExist())
            {
                throw new ChessboardException("not have any moves for this piece");
            }
        }
        public void validDestinyPosition(Position origin, Position destiny)
        {
            if (!chess.piece(origin).canMoveTo(destiny))
            {
                throw new ChessboardException("Invalid destiny position");
            }
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