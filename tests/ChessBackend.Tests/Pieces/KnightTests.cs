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
}
