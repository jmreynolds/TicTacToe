using Core;
using Shouldly;
using TicTacToe_Interfaces;
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
        var result = board.PlaceMark(1, 1, CellOwners.Human);
        result.ShouldBeTrue();
        board.Cells[1, 1].Value.ShouldBe(CellOwners.Human);
    }
    [TestMethod]
    public void ShouldNotPlaceMarkInOccupiedCell()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, CellOwners.Computer).ShouldBeTrue();
        var result = board.PlaceMark(0, 0, CellOwners.Human);
        result.ShouldBeFalse();
        board.Cells[0, 0].Value.ShouldBe(CellOwners.Computer);
    }
    [TestMethod]
    public void ShouldThrowExceptionForInvalidPosition()
    {
        var board = new TicTacToeBoard();
        Should.Throw<ArgumentOutOfRangeException>(
            () => board.PlaceMark(3, 0, CellOwners.Human));
        Should.Throw<ArgumentOutOfRangeException>(
            () => board.PlaceMark(0, -1, CellOwners.Computer));
    }
    [TestMethod]
    public void ShouldDetectWinner()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, CellOwners.Human);
        board.PlaceMark(0, 1, CellOwners.Human);
        board.PlaceMark(0, 2, CellOwners.Human);
        board.CheckWinner().ShouldBe(CellOwners.Human);
        board = new TicTacToeBoard();
        board.PlaceMark(0, 0, CellOwners.Computer);
        board.PlaceMark(1, 0, CellOwners.Computer);
        board.PlaceMark(2, 0, CellOwners.Computer);
        board.CheckWinner().ShouldBe(CellOwners.Computer);
        board = new TicTacToeBoard();
        board.PlaceMark(0, 0, CellOwners.Human);
        board.PlaceMark(1, 1, CellOwners.Human);
        board.PlaceMark(2, 2, CellOwners.Human);
        board.CheckWinner().ShouldBe(CellOwners.Human);
        board = new TicTacToeBoard();
        board.PlaceMark(0, 2, CellOwners.Computer);
        board.PlaceMark(1, 1, CellOwners.Computer);
        board.PlaceMark(2, 0, CellOwners.Computer);
        board.CheckWinner().ShouldBe(CellOwners.Computer);
    }
    [TestMethod]
    public void ShouldReturnNoWinner()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, CellOwners.Human);
        board.PlaceMark(0, 1, CellOwners.Computer);
        board.PlaceMark(0, 2, CellOwners.Human);
        board.PlaceMark(1, 0, CellOwners.Computer);
        board.PlaceMark(1, 1, CellOwners.Human);
        board.PlaceMark(1, 2, CellOwners.Computer);
        board.PlaceMark(2, 0, CellOwners.Computer);
        board.PlaceMark(2, 1, CellOwners.Human);
        board.PlaceMark(2, 2, CellOwners.Computer);
        board.CheckWinner().ShouldBe(CellOwners.Open);
    }
    [TestMethod]
    public void ShouldDetectFullBoard()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, CellOwners.Human);
        board.PlaceMark(0, 1, CellOwners.Computer);
        board.PlaceMark(0, 2, CellOwners.Human);
        board.PlaceMark(1, 0, CellOwners.Computer);
        board.PlaceMark(1, 1, CellOwners.Human);
        board.PlaceMark(1, 2, CellOwners.Computer);
        board.PlaceMark(2, 0, CellOwners.Computer);
        board.PlaceMark(2, 1, CellOwners.Human);
        board.PlaceMark(2, 2, CellOwners.Computer);
        board.IsFull().ShouldBeTrue();
        board = new TicTacToeBoard();
        board.PlaceMark(0, 0, CellOwners.Human);
        board.IsFull().ShouldBeFalse();
    }
    [TestMethod]
    public void ShouldResetBoard()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(0, 0, CellOwners.Human);
        board.PlaceMark(1, 1, CellOwners.Computer);
        board.Reset();
        foreach (var cell in board.Cells)
        {
            cell.Value.ShouldBe(CellOwners.Open);
        }
    }
    [TestMethod]
    public void ShouldPlaceComputerMarkRandomly()
    {
        var board = new TicTacToeBoard();
        board.PlaceComputerMark(CellOwners.Computer).ShouldBeTrue();
        var occupiedCells = 0;
        foreach (var cell in board.Cells)
        {
            if (cell.Value == CellOwners.Computer)
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
                board.PlaceMark(i, j, CellOwners.Human);
            }
        }
        board.PlaceComputerMark(CellOwners.Computer).ShouldBeFalse();
    }
    [TestMethod]
    public void ShouldPlaceComputerMarkAtSpecificPosition()
    {
        var board = new TicTacToeBoard();
        var result = board.PlaceComputerMark(CellOwners.Computer, 2, 2);
        result.ShouldBeTrue();
        board.Cells[2, 2].Value.ShouldBe(CellOwners.Computer);
    }
    [TestMethod]
    public void ShouldNotPlaceComputerMarkInOccupiedCell()
    {
        var board = new TicTacToeBoard();
        board.PlaceMark(1, 1, CellOwners.Human).ShouldBeTrue();
        var result = board.PlaceComputerMark(CellOwners.Computer, 1, 1);
        result.ShouldBeFalse();
        board.Cells[1, 1].Value.ShouldBe(CellOwners.Human);
    }
    [TestMethod]
    public void ShouldThrowExceptionForInvalidComputerMarkPosition()
    {
        var board = new TicTacToeBoard();
        Should.Throw<ArgumentOutOfRangeException>(
            () => board.PlaceComputerMark(CellOwners.Computer, 3, 0));
        Should.Throw<ArgumentOutOfRangeException>(
            () => board.PlaceComputerMark(CellOwners.Human, 0, -1));
    }
    [TestMethod]
    public void ShouldThrowExceptionForInvalidComputerMark()
    {
        var board = new TicTacToeBoard();
        Should.Throw<ArgumentException>(
            () => board.PlaceComputerMark(CellOwners.Open, 2, 2));
    }
}
