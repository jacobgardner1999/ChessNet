namespace ChessBackend.Tests;

[TestFixture]
public class BoardTests
{
  public string[,] initialBoard = new string[8, 8]
        {
          {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
          {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
          {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
          {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
          {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
          {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
          {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
          {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
        };

  [Test]
  public void Board_ShouldInitialiseWithStandardSetup()
  {
    var board = new Board();

    var positions = board.GetStringPosition();

    Assert.That(positions, Is.EqualTo(initialBoard));
  }

  [Test]
  public void Board_GetPiece_ShouldReturnPiece_WhenSquareIsValidAndOccupied()
  {
    var board = new Board();

    var whiteKing = board.GetPiece("e1");

    Assert.That(whiteKing.Code, Is.EqualTo("wk"));
  }

  [Test]
  public void Board_GetPiece_ShouldReturnEmpty_WhenSquareIsValidAndUnoccupied()
  {
    var board = new Board();

    var emptySquare = board.GetPiece("h6");

    Assert.That(emptySquare.Code, Is.EqualTo("oo"));
  }

  [Test]
  public void Board_GetPiece_ShouldThrowException_WhenSquareIsInvalid()
  {
    var board = new Board();

    var tooManyChars = "e44";
    var invalidColumn = "i1";
    var invalidRow = "a9";

    Assert.Throws<ArgumentException>(() => board.GetPiece(tooManyChars));
    Assert.Throws<ArgumentException>(() => board.GetPiece(invalidColumn));
    Assert.Throws<ArgumentException>(() => board.GetPiece(invalidRow));
  }

  [Test]
  public void Board_MovePiece_CanMovePieceToValidSquare()
  {
    var board = new Board();

    var move = "e2e4";

    board.MakeMove(move);

    var updatedBoard = board.GetStringPosition();

    var expectedBoard = new string[8, 8]
          {
            {"br", "bn", "bb", "bq", "bk", "bb", "bn", "br"},
            {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
            {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
            {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
            {"oo", "oo", "oo", "oo", "wp", "oo", "oo", "oo"},
            {"oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo"},
            {"wp", "wp", "wp", "wp", "oo", "wp", "wp", "wp"},
            {"wr", "wn", "wb", "wq", "wk", "wb", "wn", "wr"},
          };

    Assert.That(updatedBoard, Is.EqualTo(expectedBoard));
  }

  [Test]
  public void Board_MovePiece_ShouldThrowException_WhenSquareIsEmpty()
  {
    var board = new Board();

    var move = "e4f6";

    Assert.Throws<ArgumentException>(() => board.MakeMove(move));
  }

  [Test]
  public void Board_MovePiece_ShouldThrowException_WhenMoveIsInvalid()
  {
    var board = new Board();

    var move = "e4g5";

    Assert.Throws<ArgumentException>(() => board.MakeMove(move));
  }
}
