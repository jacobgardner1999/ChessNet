namespace ChessBackend;

[TestFixture]
public class RookTests
{
  [Test]
  public void Rook_ValidateMove_ShouldReturnTrue_ForValidEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wr", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var rook = new Rook(Colour.White);

    Assert.That(rook.validateMove("d3h3", board), Is.EqualTo(true));
  }

  [Test]
  public void Rook_ValidateMove_ShouldReturnFalse_ForInvalidEmptySquare()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wr", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var rook = new Rook(Colour.White);

    Assert.That(rook.validateMove("d3e5", board), Is.EqualTo(false));
  }

  [Test]
  public void Rook_ValidateMove_ShouldReturnTrue_ForValidSquareWithPiece()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "bq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wr", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var rook = new Rook(Colour.White);

    Assert.That(rook.validateMove("d3d6", board), Is.EqualTo(true));
  }

  [Test]
  public void Rook_ValidateMove_ShouldReturnFalse_ForValidSquareWithOwnPiece()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wr", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var rook = new Rook(Colour.White);

    Assert.That(rook.validateMove("d3d6", board), Is.EqualTo(false));
  }

  [Test]
  public void Rook_ValidateMove_ShouldReturnFalse_ForValidSquareWithPieceAlongPath()
  {
    var position = new string[8, 8]
    {
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wq", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "wr", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
      {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"}
    };
    var board = new Board(position);
    var rook = new Rook(Colour.White);

    Assert.That(rook.validateMove("d3d8", board), Is.EqualTo(false));
  }
}
