namespace ChessBackend;

public class Bishop : IPiece
{
  public string Colour { get; }
  public string Type => "Bishop";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Bishop(string colour)
  {
    Colour = colour;
  }

  public bool validateMove(int posX, int posY, int targetX, int targetY)
  {
    return true;
  }
}
