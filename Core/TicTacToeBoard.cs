using TicTacToe_Interfaces;

namespace Core
{
    public class TicTacToeBoard
    {
        public TicTacToeCell[,] Cells { get; private set; }
        public TicTacToeBoard()
        {
            Cells = new TicTacToeCell[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Cells[row, col] = new TicTacToeCell(row, col);
                }
            }
        }
        public bool PlaceMark(int row, int column, CellOwners mark)
        {
            if (row < 0 
                || row >= 3 
                || column < 0 
                || column >= 3)
                throw new ArgumentOutOfRangeException("Row and Column must be between 0 and 2.");
            if (mark != CellOwners.Human 
                && mark != CellOwners.Computer)
                throw new ArgumentException("Mark must be CellOwners.Human or CellOwners.Computer.");
            if (Cells[row, column].Value != CellOwners.Open)
                return false; // Cell already occupied
            Cells[row, column].Value = mark;
            return true;
        }
        public bool PlaceComputerMark(CellOwners mark)
        {
            var emptyCells = new List<TicTacToeCell>();
            foreach (var cell in Cells)
            {
                if (cell.Value == CellOwners.Open)
                    emptyCells.Add(cell);
            }
            if (emptyCells.Count == 0)
                return false; // No empty cells
            var random = new Random();
            var chosenCell = emptyCells[random.Next(emptyCells.Count)];
            chosenCell.Value = mark;
            return true;
        }
        public bool PlaceComputerMark(CellOwners mark, int row, int column)
        {
            if (row < 0 
                || row >= 3 
                || column < 0 
                || column >= 3)
                throw new ArgumentOutOfRangeException("Row and Column must be between 0 and 2.");
            if (mark != CellOwners.Human 
                && mark != CellOwners.Computer)
                throw new ArgumentException("Mark must be CellOwners.Human or CellOwners.Computer.");
            if (Cells[row, column].Value != CellOwners.Open)
                return false; // Cell already occupied
            Cells[row, column].Value = mark;
            return true;
        }
        public bool IsFull()
        {
            foreach (var cell in Cells)
            {
                if (cell.Value == CellOwners.Open )
                    return false;
            }
            return true;
        }
        public bool IsPlayerAboutToWin()
        {
            return false;
        }
        public CellOwners CheckWinner()
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if (Cells[i, 0].Value != CellOwners.Open 
                    && Cells[i, 0].Value == Cells[i, 1].Value 
                    && Cells[i, 1].Value == Cells[i, 2].Value)
                    return Cells[i, 0].Value;
                if (Cells[0, i].Value != CellOwners.Open
                    && Cells[0, i].Value == Cells[1, i].Value 
                    && Cells[1, i].Value == Cells[2, i].Value)
                    return Cells[0, i].Value;
            }
            // Check diagonals
            if (Cells[0, 0].Value != CellOwners.Open
                && Cells[0, 0].Value == Cells[1, 1].Value 
                && Cells[1, 1].Value == Cells[2, 2].Value)
                return Cells[0, 0].Value;
            if (Cells[0, 2].Value != CellOwners.Open 
                && Cells[0, 2].Value == Cells[1, 1].Value 
                && Cells[1, 1].Value == Cells[2, 0].Value)
                return Cells[0, 2].Value;
            return CellOwners.Open; // No winner
        }
        public void Reset()
        {
            foreach (var cell in Cells)
            {
                cell.Value = CellOwners.Open;
            }
        }
    }
}
