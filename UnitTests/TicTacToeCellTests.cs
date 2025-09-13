using Core;
using Shouldly;

namespace UnitTests;

[TestClass]
public class TicTacToeCellTests 
{
    [TestMethod]
    public void ShouldReturnTicTacToeCell()
    {
        var cell = new TicTacToeCell(1, 2);
        cell.Value.ShouldBe(' ');
        cell.Row.ShouldBe(1);
        cell.Column.ShouldBe(2);
    }
}
