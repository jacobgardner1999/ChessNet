namespace ChessBackend;

public class Board : IBoard
{
  public string[,] StringPosition { get; private set; }
  public IPiece[,] Position { get; private set; }

  public Board()
  {
    StringPosition = new string[8, 8]
        {
          {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
          {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
          {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
          {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
          {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
          {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
          {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
          {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
        };
    Position = GetPieces(StringPosition);
  }

  public Board(string[,] position)
  {
    StringPosition = position;
    Position = GetPieces(StringPosition);
  }

  public string[,] GetStringPosition()
  {
    return StringPosition;
  }

  public bool IsSquareOccupied(int row, int col)
  {
    return Position[row, col].Type != "Empty";
  }

  private IPiece[,] GetPieces(string[,] position)
  {
    IPiece[,] pieces = new IPiece[8, 8];

    for (int row = 0; row < 8; row++)
    {
      for (int col = 0; col < 8; col++)
      {
        pieces[row, col] = PieceFactory.CreatePiece(position[row, col]);
      }
    }
    return pieces;
  }

  public IPiece GetPieceAt(string square)
  {
    if (string.IsNullOrEmpty(square) || square.Length != 2)
    {
      throw new ArgumentException("Invalid square notation");
    }

    var (row, col) = ParseSquare(square);

    return Position[row, col];
  }

  public IPiece GetPieceAt(int rowIndex, int colIndex)
  {
    return Position[rowIndex, colIndex];
  }

  public IPiece[,] MakeMove(string move)
  {
    var ((pieceRow, pieceCol), (targetRow, targetCol)) = ParseMove(move);

    var piece = GetPieceAt(pieceRow, pieceCol);

    if (piece.GetType() == typeof(EmptySquare))
    {
      throw new ArgumentException("Square must contain a piece");
    }

    var valid = piece.validateMove((pieceRow, pieceCol), (targetRow, targetCol), this);

    if (!valid)
    {
      throw new ArgumentException("Invalid move");
    }

    Position[pieceRow, pieceCol] = new EmptySquare();

    Position[targetRow, targetCol] = piece;

    StringPosition = UpdateStringPos(Position);

    return Position;
  }

  public IPiece[,] MakeMoves(string[] moves)
  {
    for (var i = 0; i < moves.Length; i++)
    {
      MakeMove(moves[i]);
    }
    return Position;
  }

  private string[,] UpdateStringPos(IPiece[,] position)
  {
    var newStringPosition = new string[8, 8];

    for (var i = 0; i < 8; i++)
    {
      for (var j = 0; j < 8; j++)
      {
        newStringPosition[i, j] = GetPieceAt(i, j).Code;
      }
    }

    return newStringPosition;
  }

  public ((int row, int col) position, (int row, int col) target) ParseMove(string move)
  {
    if (move.Length != 4)
    { throw new ArgumentException("Invalid move structure"); }

    var piece = move.Substring(0, 2);
    var pieceIndex = ParseSquare(piece);

    var target = move.Substring(2, 2);
    var targetIndex = ParseSquare(target);

    return (pieceIndex, targetIndex);
  }

  public (int row, int col) ParseSquare(string square)
  {
    char column = square[0];
    if (column < 'a' || column > 'h')
    {
      throw new ArgumentException("Invalid column notation");
    }
    int colIndex = column - 'a';

    char row = square[1];
    if (row < '1' || row > '8')
    {
      throw new ArgumentException("Invalid row notation");
    }
    int rowIndex = 8 - (row - '0');

    return (rowIndex, colIndex);
  }

  public string ParseIndex((int row, int col) square)
  {
    if (square.row > 7)
    {
      throw new ArgumentException("Invalid row index");
    }
    string row = (8 - square.row).ToString();

    if (square.col > 7)
    {
      throw new ArgumentException("Invalid column index");
    }
    char col = (char)(square.col + 97);

    string stringSquare = col + row;

    return stringSquare;
  }

}
