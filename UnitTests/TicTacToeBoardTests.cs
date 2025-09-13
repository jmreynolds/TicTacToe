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
    [TestMethod]
    public void ShouldDetectFullBoard()
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
        board.IsFull().ShouldBeTrue();
        board = new TicTacToeBoard();
        board.PlaceMark(0, 0, 'X');
        board.IsFull().ShouldBeFalse();
    }
    [TestMethod]
    public void ShouldResetBoard()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, 'X');
        board.PlaceMark(1, 1, 'O');
        board.Reset();
        foreach (var cell in board.Cells)
        {
            cell.Value.ShouldBe(' ');
        }
    }
    [TestMethod]
    public void ShouldPlaceComputerMarkRandomly()
    {
        var board = new TicTacToeBoard();
        board.PlaceComputerMark('O').ShouldBeTrue();
        var occupiedCells = 0;
        foreach (var cell in board.Cells)
        {
            if (cell.Value == 'O')
                occupiedCells++;
        }
        occupiedCells.ShouldBe(1);
    }
    [TestMethod]
    public void ShouldNotPlaceComputerMarkOnFullBoard()
    {
        var board = new TicTacToeBoard();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board.PlaceMark(i, j, 'X');
            }
        }
        board.PlaceComputerMark('O').ShouldBeFalse();
    }
    [TestMethod]
    public void ShouldPlaceComputerMarkAtSpecificPosition()
    {
        var board = new TicTacToeBoard();
        var result = board.PlaceComputerMark('O', 2, 2);
        result.ShouldBeTrue();
        board.Cells[2, 2].Value.ShouldBe('O');
    }
    [TestMethod]
    public void ShouldNotPlaceComputerMarkInOccupiedCell()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(1, 1, 'X').ShouldBeTrue();
        var result = board.PlaceComputerMark('O', 1, 1);
        result.ShouldBeFalse();
        board.Cells[1, 1].Value.ShouldBe('X');
    }
    [TestMethod]
    public void ShouldThrowExceptionForInvalidComputerMarkPosition()
    {
        var board = new TicTacToeBoard();
        Should.Throw<ArgumentOutOfRangeException>(
            () => board.PlaceComputerMark('O', 3, 0));
        Should.Throw<ArgumentOutOfRangeException>(
            () => board.PlaceComputerMark('X', 0, -1));
    }
    [TestMethod]
    public void ShouldThrowExceptionForInvalidComputerMark()
    {
        var board = new TicTacToeBoard();
        Should.Throw<ArgumentException>(
            () => board.PlaceComputerMark('A', 1, 1));
        Should.Throw<ArgumentException>(
            () => board.PlaceComputerMark(' ', 2, 2));
    }
}
