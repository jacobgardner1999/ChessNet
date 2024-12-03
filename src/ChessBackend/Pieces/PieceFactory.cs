namespace ChessBackend;

public static class PieceFactory
{
  public static IPiece CreatePiece(string code)
  {
    if (string.IsNullOrEmpty(code))
      throw new ArgumentException("Code cannot be null or empty");

    switch (code)
    {
      case "br": return new Rook("Black");
      case "wr": return new Rook("White");
      case "bn": return new Knight("Black");
      case "wn": return new Knight("White");
      case "bb": return new Bishop("Black");
      case "wb": return new Bishop("White");
      case "bq": return new Queen("Black");
      case "wq": return new Queen("White");
      case "bk": return new King("Black");
      case "wk": return new King("White");
      case "bp": return new Pawn("Black");
      case "wp": return new Pawn("White");
      case "oo": return new EmptySquare();
      default: throw new ArgumentException($"Unknown piece code: {code}");
    }
  }
}
