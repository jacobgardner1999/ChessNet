namespace ChessBackend;

[TestFixture]
public class KingTests
{
  [Test]
  public void King_ValidateMove_ShouldReturnTrue_ForValidEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wk", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var king = new King(Colour.White);

    Assert.That(king.validateMove("d3e4", board), Is.EqualTo(true));
  }

  [Test]
  public void King_ValidateMove_ShouldReturnFalse_ForInvalidEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wk", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var king = new King(Colour.White);

    Assert.That(king.validateMove("d3e5", board), Is.EqualTo(false));
  }

  [Test]
  public void King_ValidateMove_ShouldReturnTrue_ForValidSquareWithPiece()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "bq", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wk", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var king = new King(Colour.White);

    Assert.That(king.validateMove("d3e4", board), Is.EqualTo(true));
  }

  [Test]
  public void King_ValidateMove_ShouldReturnFalse_ForValidSquareWithOwnPiece()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "wq", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wk", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var king = new King(Colour.White);

    Assert.That(king.validateMove("d3e4", board), Is.EqualTo(false));
  }

  [Test]
  public void King_GetValidMoves_ShouldReturnCorrectMoves()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "bb", "wp", "wq", "oo", "oo", "oo"},
      {"oo", "oo", "wr", "wk", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var king = new King(Colour.White);

    var validMoves = new List<string> { "c4", "e3", "c2", "d2", "e2" };

    Assert.That(king.GetValidMoves("d3", board), Is.EqualTo(validMoves));
  }
}
