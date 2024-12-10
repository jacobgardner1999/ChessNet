namespace ChessBackend;

public class Pawn : IPiece
{
  public Colour Colour { get; }
  public string Type => "Pawn";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour.ToString()[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public Pawn(Colour colour)
  {
    Colour = colour;
  }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    if (position.col == target.col && !board.IsSquareOccupied(target.row, target.col))
    {
      if (position.row - target.row == (int)Colour)
      {
        return true;
      }
      if (position.row - target.row == 2 * (int)Colour && (position.row == 1 || position.row == 6) && !board.IsSquareOccupied(target.row + (int)Colour, target.col))
      {
        return true;
      }
    }

    if (Math.Abs(position.col - target.col) == 1
        && position.row - target.row == (int)Colour
        && board.IsSquareOccupied(target.row, target.col)
        && board.GetPieceAt(target.row, target.col).Colour != Colour)
    {
      return true;
    }

    return false;
  }

  public bool validateMove(string move, IBoard board)
  {
    var (position, target) = board.ParseMove(move);

    return validateMove((position.row, position.col), (target.row, target.col), board);
  }

  public List<string> GetValidMoves(string square, IBoard board)
  {
    var (row, col) = board.ParseSquare(square);
    var squares = new (int, int)[]
      {
        (row - (int)Colour, col - 1),
        (row - (int)Colour, col),
        (row - (2*(int)Colour), col),
        (row - (int)Colour, col + 1),
      };

    var validSquares = new List<String>();

    for (var i = 0; i < 4; i++)
    {
      if (validateMove((row, col), squares[i], board))
      {
        validSquares.Add(board.ParseIndex(squares[i]));
      }
    }

    return validSquares;
  }
}
