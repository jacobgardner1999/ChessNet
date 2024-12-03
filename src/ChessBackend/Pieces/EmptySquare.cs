namespace ChessBackend;

public class EmptySquare : IPiece
{
  public String Colour => "None";
  public String Type => "Empty";
  public String Name => "Empty Square";
  public String Code => "oo";

  public bool validateMove(int posX, int posY, int targetX, int targetY)
  {
    return false;
  }
}
