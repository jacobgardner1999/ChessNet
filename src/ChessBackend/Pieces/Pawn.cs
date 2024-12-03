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

  public bool validateMove(int posX, int posY, int targetX, int targetY)
  {
    return posX == targetX && targetY - posY < 2;
  }
}
