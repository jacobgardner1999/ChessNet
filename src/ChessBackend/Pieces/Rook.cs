namespace ChessBackend;

public class Rook : IPiece
{
  public Colour Colour { get; }
  public string Type => "Rook";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour.ToString()[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Rook(Colour colour)
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
    return false;
  }

  public bool validateMove(string move, IBoard board)
  {
    var (position, target) = board.ParseMove(move);

    return validateMove((position[0], position[1]), (target[0], target[1]), board);
  }
}
