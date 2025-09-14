
using NsqSharp;

namespace TicTacToe
{
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
            btnExit.Click += (s, e) => Application.Exit();
            // Duplicate the button and set properties for a 3x3 grid
            int buttonSize = 250;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (row == 0 && col == 0) continue; // Skip the first button, already created
                    Button newButton = new Button
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
            btnCell00.Tag = (0, 0); // Set Tag for the first button 
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
                var producer = new Producer("127.0.0.1:4150");
                producer.Publish("TicTacToe", button.Text);
                producer.Stop();
            }



        }
    }
}
