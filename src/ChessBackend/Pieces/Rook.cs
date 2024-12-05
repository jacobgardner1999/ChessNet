namespace ChessBackend;

public class Rook : IPiece
{
  public Colour Colour { get; }
  public string Type => "Rook";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour.ToString()[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Rook(Colour colour)
  {
    Colour = colour;
  }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    return true;
  }
}
