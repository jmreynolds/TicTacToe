namespace TicTacToe
{
    partial class GameBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            panel1 = new Panel();
            btnCellToBeDeleted = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 403);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 35);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit Tic Tac Toe";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCellToBeDeleted);
            panel1.Location = new Point(234, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 3;
            // 
            // btnCellToBeDeleted
            // 
            btnCellToBeDeleted.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCellToBeDeleted.Location = new Point(13, 15);
            btnCellToBeDeleted.Name = "btnCellToBeDeleted";
            btnCellToBeDeleted.Size = new Size(287, 78);
            btnCellToBeDeleted.TabIndex = 2;
            btnCellToBeDeleted.Text = "this is an example; it will be removed";
            btnCellToBeDeleted.UseVisualStyleBackColor = true;
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 444);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Margin = new Padding(1);
            Name = "GameBoard";
            Text = "Tic Tac Toe";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Panel panel1;
        private Button btnCellToBeDeleted;
        
    }
}
