namespace ChessBackend;

public class Queen : IPiece
{
  public Colour Colour { get; }
  public string Type => "Queen";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour.ToString()[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Queen(Colour colour)
  {
    Colour = colour;
  }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    if (position.col == target.col
        && board.GetPieceAt(target.row, target.col).Colour != Colour)
    {
      var dy = (position.row > target.row) ? -1 : 1;
      for (var i = position.row + dy; i != target.row; i += dy)
      {
        if (board.IsSquareOccupied(i, target.col))
        {
          return false;
        }
      }
      return true;
    }

    if (position.row == target.row
        && board.GetPieceAt(target.row, target.col).Colour != Colour)
    {
      var dx = (position.col > target.col) ? -1 : 1;
      for (var i = position.col + dx; i != target.col; i += dx)
      {
        if (board.IsSquareOccupied(target.row, i))
        {
          return false;
        }
      }
      return true;
    }

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

    return validateMove((position[0], position[1]), (target[0], target[1]), board);
  }
}
