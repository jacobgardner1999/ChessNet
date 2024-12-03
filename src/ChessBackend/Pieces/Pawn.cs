namespace ChessBackend;

public class Pawn : IPiece
{
  public string Colour { get; }
  public string Type => "Pawn";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Pawn(string colour)
  {
    Colour = colour;
  }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    if (position.col == target.col)
    {
      if (Math.Abs(position.row - target.row) == 1)
      {
        return true;
      }
      if (Math.Abs(position.row - target.row) == 2 && (position.row == 1 || position.row == 6))
      {
        return true;
      }
    }

    return false;
  }
}
