namespace ChessBackend;

public class Bishop : IPiece
{
  public Colour Colour { get; }
  public string Type => "Bishop";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour.ToString()[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Bishop(Colour colour)
  {
    Colour = colour;
  }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    if (Math.Abs(position.row - target.row) == Math.Abs(position.col - target.col)
        && board.GetPieceAt(target.row, target.col).Colour != Colour)
    {
      var dx = (position.row > target.row) ? -1 : 1;
      var dy = (position.col > target.col) ? -1 : 1;
      var j = position.col + dy;
      for (var i = position.row + dx; i != target.row; i += dx)
      {
        if (board.IsSquareOccupied(i, j))
        {
          return false;
        }
        j += dy;
      }
      return true;
    }
    return false;
  }

  public bool validateMove(string move, IBoard board)
  {
    var (position, target) = board.ParseMove(move);

    return validateMove((position.row, position.col), (target.row, target.col), board);
  }
}
