namespace ChessBackend;

public class King : IPiece
{
  public Colour Colour { get; }
  public string Type => "King";
  public string Name => $"{Colour} {Type}";
  public string Code => $"{Colour.ToString()[0].ToString().ToLower()}{Type[0].ToString().ToLower()}";

  public King(Colour colour)
  {
    Colour = colour;
  }

  public bool validateMove((int row, int col) position, (int row, int col) target, IBoard board)
  {
    if (Math.Abs(position.row - target.row) < 2
        && Math.Abs(position.col - target.col) < 2
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

    var validMoves = new List<string>();

    for (var i = -1; i < 2; i++)
    {
      for (var j = -1; j < 2; j++)
      {
        if (validateMove((row, col), (row + i, col + j), board))
        {
          validMoves.Add(board.ParseIndex((row + i, col + j)));
        }
      }
    }

    return validMoves;
  }
}
