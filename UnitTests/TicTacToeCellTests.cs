using Core;
using Shouldly;
using TicTacToe_Interfaces;

namespace UnitTests;

[TestClass]
public class TicTacToeCellTests 
{
    [TestMethod]
    public void ShouldReturnTicTacToeCell()
    {
        var cell = new TicTacToeCell(1, 2);
        cell.Value.ShouldBe(CellOwners.Open);
        cell.RowID.ShouldBe(1);
        cell.ColID.ShouldBe(2);
    }

    // MER 2025-09-16 this is a more elegant and complete test method
    [DataTestMethod]
    [DataRow(0, 0, CellOwners.Open)]
    [DataRow(0, 1, CellOwners.Human)]
    [DataRow(2, 0, CellOwners.Computer)]
    [DataRow(2, 2, CellOwners.Error)]
    public void AlternateShouldReturnTicTacToeCell(int testrow, int testcol, CellOwners testowner)
    {
        // MER 2025-09-16 
        // remove the constructor in the TicTacToeCell class and use class initializers
        // this will not compile until the constuctor is removed
        var cell = new TicTacToeCell()
        {
            RowID = testrow,
            ColID = testcol,
            CellOwner = testowner
        };
        cell.Value.ShouldBe(testowner);
        cell.RowID.ShouldBe(testrow);
        cell.ColID.ShouldBe(testcol);
    }
}
