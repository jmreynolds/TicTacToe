


namespace TicTacToe
{
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();

            // MER 2025-09-14 - many changes here
            panel1.Controls.Remove(btnCellToBeDeleted);
            
            int buttonSize = 100;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Button newButton = new()
                    {
                        Font = new Font("Comic Sans MS", 27.75F),
                        Size = new Size(buttonSize, buttonSize),
                        Location = new Point(37 + col * (buttonSize + 20), 48 + row * (buttonSize + 20)),
                        Name = $"btnCell{row}{col}",
                        Tag = (row, col), // Store row and column in Tag for later use
                        Text = "?",
                        UseVisualStyleBackColor = true

                    };
                    panel1.Controls.Add(newButton);
                }
            }
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                btn.Click += Cell_Click;
            }
        }

        private void Cell_Click(object? sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Text = "X"; // Example action: set text to "X" on click
            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
