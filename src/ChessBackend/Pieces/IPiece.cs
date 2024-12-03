namespace ChessBackend;

public interface IPiece
{
  string Colour { get; }
  string Type { get; }
  string Code { get; }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board);
}
