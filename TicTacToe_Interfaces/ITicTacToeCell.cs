namespace TicTacToe_Interfaces;

/*
 * MER 2025-09-16 : modern C# applications do not need the {} after the namespace, just the ;
 * therefore, the indentation is reduced
 * I'll let you appliy this across the other code.
 */


public interface ITicTacToeCell
{
    /// <summary>
    /// Property indicating the row of the referenced square. (0-2)
    /// </summary>
    int RowID { get; init; }

    /// <summary>
    /// Property indicating the column of the referenced square. (0-2)
    /// </summary>
    int ColID { get; init; } // MER 2025-09-16 changed set to init

    /// <summary>
    /// Property indicating the owner of a square (human, computer, open, error)
    /// </summary>
    CellOwners CellOwner { get; set; }
}
