namespace ChessBackend;

public class Knight : IPiece
{
  public string Colour { get; }
  public string Type => "Knight";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour[0].ToString().ToLower()}n";

  public Knight(string colour)
  {
    Colour = colour;
  }

  public bool validateMove(int posX, int posY, int targetX, int targetY)
  {
    return true;
  }
}
