using TicTacToe_Interfaces;

namespace Core
{
    public class TicTacToeBoard
    {
        // MER 2025-09-17 : public???
        public TicTacToeCell[,] Cells { get; private set; }

        // MER 2025-09-17 : this is the collections I sp[oke of last night
        // or perhaps List<int[,]>
        private int[,,] winningMoves = new[, ,]
        {
            { {0,0},{0,1},{0,2 } },
            { {1,0},{1,1},{1,2 } },
            { {2,0},{2,1},{2,2 } },
            { {0,0 },{1,0 },{2,0 } },
            { {0,1 },{1,1 },{2,1 } },
            { {0,2 },{1,2 },{2,2 } },
            { {0,0 },{1,1 },{2,2 } },
            { {2,0 },{1,1 },{0,2 } }
        };
        // MER 2025-09-17 : the next computer play
        private int[,] nextMove = new [,]
        {
        {1,1}, // center
        {0,0},{0,0 },{0,2 },{2,0 },{2,2 }, // corners
        {0,1 },{1,0 },{1,2 },{2,1 } // sides
        };

        // MER 2025-09-17 : suggest move into Reset method below
        // MER 2025-09-17 : if you really want to be wild, have variable size
        // board(must be odd number). Nevertheless, never hardcode a value,
        // not even a tictctoe board size
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

        // MER 2025-0-16
        // 'mark' is an interesting parameter name. suggest CellOwner (singular)
        // according to uSoft, property names are capitalized, but ReSharper is different
        public bool PlaceMark(int row, int column, CellOwners mark)
        {
            // MER 2025-09-17 : consider writing an extension IsBewtween(int low, int high)
            if (row < 0 
                || row >= 3 
                || column < 0 
                || column >= 3)
                throw new ArgumentOutOfRangeException("Row and Column must be between 0 and 2.");
            // MER 2025-09-17 : is this test necessary? In future, maybe you to 'set' other values
            if (mark != CellOwners.Human 
                && mark != CellOwners.Computer)
                throw new ArgumentException("Mark must be CellOwners.Human or CellOwners.Computer.");
            if (Cells[row, column].Value != CellOwners.Open)
                return false; // Cell already occupied
            Cells[row, column].Value = mark;
            return true;
        }
        /* MER 2025-09-16
            the you can use this: (my syntax may be slightly incorrect)
            var demo = AlternatePlaceMark(new()
            { //RowID = 0, //ColID = 0, CellOwner = CellOwners.Error } );

        public bool AlternatePlaceMark(TicTacToeCell cell)
        {
            return false;
        }
        */

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
        // MER 2025-09-17 : isn't this redundant?
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
            // MER 2025-09-17 : if you use a List instead of Array, you can do this:
            var listCells = new List<TicTacToeCell>();
            var emptyCount = listCells.Count(cell => cell.CellOwner == CellOwners.Open);
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
