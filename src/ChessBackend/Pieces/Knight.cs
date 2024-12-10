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
    if (Math.Abs(position.col - target.col) == 1
        && Math.Abs(position.row - target.row) == 2
        && board.GetPieceAt(target.row, target.col).Colour != Colour)
    {
      return true;
    }

    if (Math.Abs(position.row - target.row) == 1
        && Math.Abs(position.col - target.col) == 2
        && board.GetPieceAt(target.row, target.col).Colour != Colour)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool validateMove(string move, IBoard board)
  {
    var (position, target) = board.ParseMove(move);

    return validateMove((position.row, position.col), (target.row, target.col), board);
  }
}
