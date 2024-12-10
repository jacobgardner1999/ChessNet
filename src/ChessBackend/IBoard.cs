namespace ChessBackend;

public interface IBoard
{
  bool IsSquareOccupied(int row, int col);
  IPiece GetPieceAt(int row, int col);
  ((int row, int col) position, (int row, int col) target) ParseMove(string move);
  (int row, int col) ParseSquare(string square);
  string ParseIndex((int row, int col) square);
}
