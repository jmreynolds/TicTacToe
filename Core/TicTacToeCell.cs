namespace Core
{
    public class TicTacToeCell
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public char Value { get; set; } // 'X', 'O', or ' ' for empty
        public TicTacToeCell(int row, int column)
        {
            Row = row;
            Column = column;
            Value = ' '; // Initialize as empty
        }
    }
}