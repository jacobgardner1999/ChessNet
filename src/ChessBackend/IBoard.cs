namespace ChessBackend;

public interface IBoard
{
  bool IsSquareOccupied(int row, int col);
  IPiece GetPieceAt(int row, int col);
  (int[], int[]) ParseMove(string move);
}
