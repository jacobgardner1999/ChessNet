namespace ChessBackend;

[TestFixture]
public class PawnTests
{

  [Test]
  public void Pawn_ValidateMove_ShouldReturnTrue_ForOneSquareForward()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove((6, 4), (5, 4), board), Is.EqualTo(true));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForInvalidSquare()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove((6, 4), (3, 6), board), Is.EqualTo(false));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnTrue_ForTwoSquaresOnFirstMove()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove((6, 4), (4, 4), board), Is.EqualTo(true));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForWhiteBackwardsMove()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove((3, 4), (5, 4), board), Is.EqualTo(false));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForBlackBackwardsMove()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.Black);

    Assert.That(pawn.validateMove((3, 4), (2, 4), board), Is.EqualTo(false));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_IfSquareIsOccupied()
  {
    var position = new string[8, 8]
    {
      {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
      {"bp", "bp", "bp", "bp", "oo", "bp", "bp", "bp"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "bp", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "wp", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"wp", "wp", "wp", "wp", "oo", "wp", "wp", "wp"},
      {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
    };

    var board = new Board(position);
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove((4, 4), (3, 4), board), Is.EqualTo(false));
  }
}
