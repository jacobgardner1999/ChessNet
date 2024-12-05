namespace ChessBackend;

public interface IPiece
{
  Colour Colour { get; }
  string Type { get; }
  string Code { get; }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board);
}

public enum Colour
{
  White = 1,
  Black = -1,
  None = 0
}
