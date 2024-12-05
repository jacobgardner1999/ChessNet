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
}
