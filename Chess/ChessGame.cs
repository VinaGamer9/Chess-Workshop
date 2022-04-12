using System.Collections.Generic;
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
        private HashSet<Piece> pieces;
        private HashSet<Piece> capturedPieces;

        public ChessGame()
        {
            chess = new Chessb(8, 8);
            turn = 1;
            currentPlayer = Color.White;
            fineshed = false;
            pieces = new HashSet<Piece>();
            capturedPieces = new HashSet<Piece>();
            setPieces();
        }

        public void moveMaker(Position origin, Position destiny)
        {
            Piece p = chess.removePiece(origin);
            p.increaceQtnMoves();
            Piece catchedPiece = chess.removePiece(destiny);
            chess.insertPiece(p, destiny);
            if (catchedPiece != null)
            {
                capturedPieces.Add(catchedPiece);
            }


        }
        public void performsMove(Position origin, Position destiny)
        {
            moveMaker(origin, destiny);
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
        public HashSet<Piece> catchedPieces(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece x in capturedPieces)
            {
                if (x.color == color)
                {
                    aux.Add(x);
                }

            }
            return aux;
        }
        public HashSet<Piece> piecesInGame(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece x in pieces)
            {
                if (x.color == color)
                {
                    aux.Add(x);
                }

            }
            aux.ExceptWith(catchedPieces(color));
            return aux;
        }
        public void setNewPiece(char column, int row, Piece piece)
        {
            chess.insertPiece(piece, new ChessPosition(column, row).toPosition());
            pieces.Add(piece);
        }
        public void setPieces()
        {

            setNewPiece('d', 1, new King(chess, Color.White));
            setNewPiece('d', 2, new Tower(chess, Color.White));
            setNewPiece('c', 1, new Tower(chess, Color.White));
            setNewPiece('c', 2, new Tower(chess, Color.White));
            setNewPiece('e', 1, new Tower(chess, Color.White));
            setNewPiece('e', 2, new Tower(chess, Color.White));

            setNewPiece('d', 8, new King(chess, Color.Black));
            setNewPiece('d', 7, new Tower(chess, Color.Black));
            setNewPiece('c', 8, new Tower(chess, Color.Black));
            setNewPiece('c', 7, new Tower(chess, Color.Black));
            setNewPiece('e', 8, new Tower(chess, Color.Black));
            setNewPiece('e', 7, new Tower(chess, Color.Black));

        }
    }
}