namespace ChessBackend;

public class Knight : IPiece
{
  public Colour Colour { get; }
  public string Type => "Knight";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour.ToString()[0].ToString().ToLower()}n";

  public Knight(Colour colour)
  {
    Colour = colour;
  }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    return true;
  }
}
