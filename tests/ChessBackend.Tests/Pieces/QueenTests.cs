namespace ChessBackend;

[TestFixture]
public class QueenTests
{
  [Test]
  public void Queen_ValidateMove_ShouldReturnTrue_ForValidHorizontalEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var queen = new Queen(Colour.White);

    Assert.That(queen.validateMove("d3a3", board), Is.EqualTo(true));
  }

  [Test]
  public void Queen_ValidateMove_ShouldReturnTrue_ForValidVerticalEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var queen = new Queen(Colour.White);

    Assert.That(queen.validateMove("d3d1", board), Is.EqualTo(true));
  }

  [Test]
  public void Queen_ValidateMove_ShouldReturnTrue_ForValidDiagonalEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var queen = new Queen(Colour.White);

    Assert.That(queen.validateMove("d3f1", board), Is.EqualTo(true));
  }
  [Test]
  public void Queen_ValidateMove_ShouldReturnFalse_ForInvalidEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var queen = new Queen(Colour.White);

    Assert.That(queen.validateMove("d3e5", board), Is.EqualTo(false));
  }

  [Test]
  public void Queen_ValidateMove_ShouldReturnTrue_ForValidSquareWithPiece()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"bq", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var queen = new Queen(Colour.White);

    Assert.That(queen.validateMove("d3a6", board), Is.EqualTo(true));
  }

  [Test]
  public void Queen_ValidateMove_ShouldReturnFalse_ForValidSquareWithOwnPiece()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "wq", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var queen = new Queen(Colour.White);

    Assert.That(queen.validateMove("d3b5", board), Is.EqualTo(false));
  }

  [Test]
  public void Queen_ValidateMove_ShouldReturnFalse_ForValidSquareWithPieceAlongPath()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "bq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var queen = new Queen(Colour.White);

    Assert.That(queen.validateMove("d3d8", board), Is.EqualTo(false));
  }

  [Test]
  public void Queen_GetValidMoves_ShouldReturnCorrectMoves()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "bq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "wk", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "bq", "oo", "oo", "oo", "wk", "oo", "oo"}
    };
    var board = new Board(position);
    var queen = new Queen(Colour.White);

    var expectedMoves = new List<string> { "e3", "c3", "b3", "a3", "d2", "d1", "d4",
                                          "d5", "d6", "d7", "c2", "b1", "e4", "f5",
                                          "g6", "h7", "c4", "b5", "a6" };

    Assert.That(queen.GetValidMoves("d3", board), Is.EqualTo(expectedMoves));
  }
}

