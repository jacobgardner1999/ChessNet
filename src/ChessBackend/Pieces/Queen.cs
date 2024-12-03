namespace ChessBackend;

public class Queen : IPiece
{
  public string Colour { get; }
  public string Type => "Queen";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Queen(string colour)
  {
    Colour = colour;
  }

  public bool validateMove(int posX, int posY, int targetX, int targetY)
  {
    return true;
  }
}
