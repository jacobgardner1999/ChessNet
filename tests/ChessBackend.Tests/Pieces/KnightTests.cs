namespace ChessBackend;

[TestFixture]
public class KnightTests
{
  [Test]
  public void Knight_ValidateMove_ShouldReturnTrue_ForValidSquare()
  {
    var board = new Board();
    var knight = new Knight(Colour.White);

    Assert.That(knight.validateMove("g1f3", board), Is.EqualTo(true));
  }

  [Test]
  public void Knight_ValidateMove_ShouldReturnFalse_ForInvalidSquare()
  {
    var board = new Board();
    var knight = new Knight(Colour.White);

    Assert.That(knight.validateMove("g1f4", board), Is.EqualTo(false));
  }

  [Test]
  public void Knight_ValidateMove_ShouldReturnFalse_IfSquareHasOwnPiece()
  {
    var position = new string[8, 8]
    {
      {"br", "oo", "bb", "bq", "bk", "bb", "bn", "br"},
      {"bp", "bp", "bp", "bp", "oo", "bp", "bp", "bp"},
      {"oo", "oo", "bn", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "bp", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "wp", "oo", "oo", "oo"},
      {"oo", "oo", "wn", "oo", "oo", "oo", "oo", "oo"},
      {"wp", "wp", "wp", "wp", "oo", "wp", "wp", "wp"},
      {"wr", "oo", "wb", "wq", "wk", "wb", "wn", "wr"},
    };

    var board = new Board(position);
    var knight = new Knight(Colour.White);

    Assert.That(knight.validateMove("c3e4", board), Is.EqualTo(false));

  }

  [Test]
  public void Knight_ValidateMove_ShouldThrowError_IfSquareOutOfBounds()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "wn"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
    };
    var board = new Board(position);
    var knight = new Knight(Colour.White);

    Assert.Throws<ArgumentException>(() => knight.validateMove("h4i6", board));
  }
}
