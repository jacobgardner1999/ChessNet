namespace ChessBackend;

public static class PieceFactory
{
  public static IPiece CreatePiece(string code)
  {
    if (string.IsNullOrEmpty(code))
      throw new ArgumentException("Code cannot be null or empty");

    switch (code)
    {
      case "br": return new Rook(Colour.Black);
      case "wr": return new Rook(Colour.White);
      case "bn": return new Knight(Colour.Black);
      case "wn": return new Knight(Colour.White);
      case "bb": return new Bishop(Colour.Black);
      case "wb": return new Bishop(Colour.White);
      case "bq": return new Queen(Colour.Black);
      case "wq": return new Queen(Colour.White);
      case "bk": return new King(Colour.Black);
      case "wk": return new King(Colour.White);
      case "bp": return new Pawn(Colour.Black);
      case "wp": return new Pawn(Colour.White);
      case "oo": return new EmptySquare();
      default: throw new ArgumentException($"Unknown piece code: {code}");
    }
  }
}
