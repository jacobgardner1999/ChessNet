namespace ChessBackend;

public class Pawn : IPiece
{
  public Colour Colour { get; }
  public string Type => "Pawn";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour.ToString()[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Pawn(Colour colour)
  {
    Colour = colour;
  }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    if (position.col == target.col)
    {
      if (position.row - target.row == 1)
      {
        return true;
      }
      if (position.row - target.row == 2 && (position.row == 1 || position.row == 6))
      {
        return true;
      }
    }

    return false;
  }
}
