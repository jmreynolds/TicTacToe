using TicTacToe_Interfaces;

namespace Core
{
    public class TicTacToeCell:ITicTacToeCell // MER 9-14
    {
        // MER 2025-09-16 recommend not using 'Row', treat it as reserved
        // suggest RowID, ColID
        // either change these to RowID, ColID, or change the ITicTacToeCell
        // need to check range (1-3)
        public int Row { get; private set; }
        int ITicTacToeCell.RowID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Column { get; private set; }
        int ITicTacToeCell.ColID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        // MER 2025-09-14 used the TicTacToe_Interfaces
        // I prefer to use Value within a property set
        public CellOwners Value { get; set; } // 'X', 'O', or ' ' for empty
        CellOwners ITicTacToeCell.CellOwner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public TicTacToeCell(int row, int column)
        {
            Row = row;
            Column = column;
            // MER 2025-0-9-14 Value = ' '; // Initialize as empty
            Value = CellOwners.Open; // MER 2025-09-14
        }
    }
}