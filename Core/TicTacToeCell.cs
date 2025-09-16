using TicTacToe_Interfaces;

namespace Core
{
    public class TicTacToeCell : ITicTacToeCell // MER 9-14
    {
        // MER 2025-09-16 recommend not using 'Row', treat it as reserved
        // suggest RowID, ColID
        // either change these to RowID, ColID, or change the ITicTacToeCell
        // need to check range (1-3)


        // MER 2025-09-14 used the TicTacToe_Interfaces
        // I prefer to use Value within a property set

        // MER 2025-09-16 --- I think you are redundant here (Value and CellOwner).
        // I don't to use Value because it is part of C#'s property setting logic
        // suggest you use CellOwner, not Value
        public CellOwners Value { get; set; } // CellOwners.Human, CellOwners.Computer, or ' ' for empty
        public int RowID { get; init; } // MER 2025-09-16 use init instead of set when the property is immutable
        public int ColID { get; init; } // MER 2025-09-16 changed set to init
        public CellOwners CellOwner { get ; set; }

        // MER 2025-09-16 do you need this? Use property initializers
        public TicTacToeCell(int row, int column)
        {
            RowID = row;
            ColID = column;
            // MER 2025-0-9-14 Value = ' '; // Initialize as empty
            Value = CellOwners.Open; // MER 2025-09-14
        }
    }
}