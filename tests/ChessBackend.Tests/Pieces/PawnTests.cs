namespace ChessBackend;

[TestFixture]
public class PawnTests
{

  [Test]
  public void Pawn_ValidateMove_ShouldReturnTrue_ForOneSquareForward()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove("e2e3", board), Is.EqualTo(true));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForInvalidSquare()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove("e2f8", board), Is.EqualTo(false));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnTrue_ForTwoSquaresOnFirstMove()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove("e2e4", board), Is.EqualTo(true));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForTwoSquaresOnFirstMoveIfFirstSquareIsOccupied()
  {
    var position = new string[8, 8]
    {
      {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
      {"bp", "bp", "bp", "bp", "oo", "bp", "bp", "bp"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "bp", "oo", "oo", "oo"},
      {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
      {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
    };
    var board = new Board(position);
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove("e2e4", board), Is.EqualTo(false));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForWhiteBackwardsMove()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove("e3e2", board), Is.EqualTo(false));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForBlackBackwardsMove()
  {
    var board = new Board();
    var pawn = new Pawn(Colour.Black);

    Assert.That(pawn.validateMove("e5e6", board), Is.EqualTo(false));
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

    Assert.That(pawn.validateMove("e4e5", board), Is.EqualTo(false));
  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnTrue_ForWhiteCapture()
  {
    var position = new string[8, 8]
    {
      {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
      {"bp", "bp", "bp", "bp", "oo", "bp", "bp", "bp"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "bp", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "wp", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"wp", "wp", "wp", "wp", "oo", "wp", "wp", "wp"},
      {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
    };

    var board = new Board(position);
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove("e4d5", board), Is.EqualTo(true));

  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnTrue_ForBlackCapture()
  {
    var position = new string[8, 8]
    {
      {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
      {"bp", "bp", "bp", "bp", "oo", "bp", "bp", "bp"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "bp", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "wp", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"wp", "wp", "wp", "wp", "oo", "wp", "wp", "wp"},
      {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
    };

    var board = new Board(position);
    var pawn = new Pawn(Colour.Black);

    Assert.That(pawn.validateMove("d5e4", board), Is.EqualTo(true));

  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForCaptureOnEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
      {"bp", "bp", "bp", "bp", "oo", "bp", "bp", "bp"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "bp", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "wp", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"wp", "wp", "wp", "wp", "oo", "wp", "wp", "wp"},
      {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
    };

    var board = new Board(position);
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove("e4f5", board), Is.EqualTo(false));

  }

  [Test]
  public void Pawn_ValidateMove_ShouldReturnFalse_ForCaptureOfOwnPiece()
  {
    var position = new string[8, 8]
    {
      {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
      {"bp", "bp", "bp", "oo", "oo", "bp", "bp", "bp"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "bp", "bp", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "wp", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wp", "oo", "oo", "oo", "oo"},
      {"wp", "wp", "wp", "oo", "oo", "wp", "wp", "wp"},
      {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
    };

    var board = new Board(position);
    var pawn = new Pawn(Colour.White);

    Assert.That(pawn.validateMove("d3e4", board), Is.EqualTo(false));

  }
}
