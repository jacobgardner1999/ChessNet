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
    var rook = new Rook(Colour);
    var bishop = new Bishop(Colour);

    if (rook.validateMove(position, target, board))
    {
      return true;
    }

    if (bishop.validateMove(position, target, board))
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

    var validSquares = new List<string>();

    var bishop = new Bishop(Colour);

    for (var i = 1; i + col < 8; i++)
    {
      if (!validateMove((row, col), (row, col + i), board))
      {
        break;
      }
      validSquares.Add(board.ParseIndex((row, col + i)));
    }

    for (var i = 1; col - i >= 0; i++)
    {
      if (!validateMove((row, col), (row, col - i), board))
      {
        break;
      }
      validSquares.Add(board.ParseIndex((row, col - i)));
    }

    for (var i = 1; i + row < 8; i++)
    {
      if (!validateMove((row, col), (row + i, col), board))
      {
        break;
      }
      validSquares.Add(board.ParseIndex((row + i, col)));
    }

    for (var i = 1; row - i >= 0; i++)
    {
      if (!validateMove((row, col), (row - i, col), board))
      {
        break;
      }
      validSquares.Add(board.ParseIndex((row - i, col)));
    }

    validSquares = validSquares.Concat(bishop.GetValidMoves(square, board)).ToList();

    return validSquares;
  }
}
