namespace ChessBackend;

public interface IPiece
{
  string Colour { get; }
  string Type { get; }
  string Code { get; }

  public bool validateMove(int posX, int posY, int targetX, int targetY);
}
