using Core;
using Shouldly; 
namespace UnitTests;

[TestClass]
public class TicTacToeBoardTests
{
    [TestMethod]
    public void ShouldReturnPopulatedBoard()
    {
        var board = new TicTacToeBoard();
        board.Cells.ShouldNotBeNull();
        board.Cells.Length.ShouldBe(9);
    }
    [TestMethod]
    public void ShouldPlaceMark()
    {
        var board = new TicTacToeBoard();
        var result = board.PlaceMark(1, 1, 'X');
        result.ShouldBeTrue();
        board.Cells[1, 1].Value.ShouldBe('X');
    }
    [TestMethod]
    public void ShouldNotPlaceMarkInOccupiedCell()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, 'O').ShouldBeTrue();
        var result = board.PlaceMark(0, 0, 'X');
        result.ShouldBeFalse();
        board.Cells[0, 0].Value.ShouldBe('O');
    }
    [TestMethod]
    public void ShouldThrowExceptionForInvalidPosition()
    {
        var board = new TicTacToeBoard();
        Should.Throw<ArgumentOutOfRangeException>(
            () => board.PlaceMark(3, 0, 'X'));
        Should.Throw<ArgumentOutOfRangeException>(
            () => board.PlaceMark(0, -1, 'O'));
    }
    [TestMethod]
    public void ShouldThrowExceptionForInvalidMark()
    {
        var board = new TicTacToeBoard();
        Should.Throw<ArgumentException>(
            () => board.PlaceMark(1, 1, 'A'));
        Should.Throw<ArgumentException>(
            () => board.PlaceMark(2, 2, ' '));
    }
    [TestMethod]
    public void ShouldDetectWinner()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, 'X');
        board.PlaceMark(0, 1, 'X');
        board.PlaceMark(0, 2, 'X');
        board.CheckWinner().ShouldBe('X');
        board = new TicTacToeBoard();
        board.PlaceMark(0, 0, 'O');
        board.PlaceMark(1, 0, 'O');
        board.PlaceMark(2, 0, 'O');
        board.CheckWinner().ShouldBe('O');
        board = new TicTacToeBoard();
        board.PlaceMark(0, 0, 'X');
        board.PlaceMark(1, 1, 'X');
        board.PlaceMark(2, 2, 'X');
        board.CheckWinner().ShouldBe('X');
        board = new TicTacToeBoard();
        board.PlaceMark(0, 2, 'O');
        board.PlaceMark(1, 1, 'O');
        board.PlaceMark(2, 0, 'O');
        board.CheckWinner().ShouldBe('O');
    }
    [TestMethod]
    public void ShouldReturnNoWinner()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, 'X');
        board.PlaceMark(0, 1, 'O');
        board.PlaceMark(0, 2, 'X');
        board.PlaceMark(1, 0, 'O');
        board.PlaceMark(1, 1, 'X');
        board.PlaceMark(1, 2, 'O');
        board.PlaceMark(2, 0, 'O');
        board.PlaceMark(2, 1, 'X');
        board.PlaceMark(2, 2, 'O');
        board.CheckWinner().ShouldBe(' ');
    }
}
