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
        public CellOwners Value { get; set; } // CellOwners.Human, CellOwners.Computer, or ' ' for empty
        public int RowID { get; set; }
        public int ColID { get; set; }
        public CellOwners CellOwner { get ; set; }

        public TicTacToeCell(int row, int column)
        {
            RowID = row;
            ColID = column;
            // MER 2025-0-9-14 Value = ' '; // Initialize as empty
            Value = CellOwners.Open; // MER 2025-09-14
        }
    }
}