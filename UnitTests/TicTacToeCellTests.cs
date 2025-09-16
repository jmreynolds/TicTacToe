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
}
