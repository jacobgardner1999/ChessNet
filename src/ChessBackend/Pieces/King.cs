namespace ChessBackend;

public class King : IPiece
{
  public string Colour { get; }
  public string Type => "King";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public King(string colour)
  {
    Colour = colour;
  }

  public bool validateMove(int posX, int posY, int targetX, int targetY)
  {
    return true;
  }
}
