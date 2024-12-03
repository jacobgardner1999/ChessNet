namespace ChessBackend;

[TestFixture]
public class PawnTests
{
  [Test]
  public void Pawn_ValidateMove_ShouldReturnTrue_ForOneSquareForward()
  {
    var pawn = new Pawn("White");

    Assert.That(pawn.validateMove(4, 1, 4, 2), Is.EqualTo(true));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForInvalidSquare()
  {
    var pawn = new Pawn("White");

    Assert.That(pawn.validateMove(4, 1, 6, 3), Is.EqualTo(false));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnTrue_ForTwoSquaresOnFirstMove()
  {
    var pawn = new Pawn("White");

    Assert.That(pawn.validateMove(4, 1, 4, 3), Is.EqualTo(true));
  }
}
