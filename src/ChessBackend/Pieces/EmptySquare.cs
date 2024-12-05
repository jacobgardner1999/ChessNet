namespace ChessBackend;

public class EmptySquare : IPiece
{
  public Colour Colour => Colour.None;
  public String Type => "Empty";
  public String Name => "Empty Square";
  public String Code => "oo";

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    return true;
  }
}
