namespace ChessBackend;

[TestFixture]
public class BishopTests
{
  [Test]
  public void Bishop_ValidateMove_ShouldReturnTrue_ForValidEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wb", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var bishop = new Bishop(Colour.White);

    Assert.That(bishop.validateMove("d3f1", board), Is.EqualTo(true));
  }

  [Test]
  public void Bishop_ValidateMove_ShouldReturnFalse_ForInvalidEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wb", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var bishop = new Bishop(Colour.White);

    Assert.That(bishop.validateMove("d3e5", board), Is.EqualTo(false));
  }

  [Test]
  public void Bishop_ValidateMove_ShouldReturnTrue_ForValidSquareWithPiece()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"bq", "oo", "oo", "bq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wb", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var bishop = new Bishop(Colour.White);

    Assert.That(bishop.validateMove("d3a6", board), Is.EqualTo(true));
  }

  [Test]
  public void Bishop_ValidateMove_ShouldReturnFalse_ForValidSquareWithOwnPiece()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "wq", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wb", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var bishop = new Bishop(Colour.White);

    Assert.That(bishop.validateMove("d3b5", board), Is.EqualTo(false));
  }

  [Test]
  public void Bishop_ValidateMove_ShouldReturnFalse_ForValidSquareWithPieceAlongPath()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "bq", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wb", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var bishop = new Bishop(Colour.White);

    Assert.That(bishop.validateMove("d3a6", board), Is.EqualTo(false));
  }
}

