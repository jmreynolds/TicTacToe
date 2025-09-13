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
            ticTacToeGrid = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            ticTacToeGrid.SuspendLayout();
            SuspendLayout();
            // 
            // ticTacToeGrid
            // 
            ticTacToeGrid.ColumnCount = 3;
            ticTacToeGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ticTacToeGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ticTacToeGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ticTacToeGrid.Controls.Add(textBox1, 0, 0);
            ticTacToeGrid.Controls.Add(textBox2, 1, 0);
            ticTacToeGrid.Controls.Add(textBox3, 2, 0);
            ticTacToeGrid.Controls.Add(textBox4, 0, 1);
            ticTacToeGrid.Controls.Add(textBox5, 1, 1);
            ticTacToeGrid.Controls.Add(textBox6, 2, 1);
            ticTacToeGrid.Controls.Add(textBox7, 0, 2);
            ticTacToeGrid.Controls.Add(textBox8, 1, 2);
            ticTacToeGrid.Controls.Add(textBox9, 2, 2);
            ticTacToeGrid.Location = new Point(83, 52);
            ticTacToeGrid.Name = "ticTacToeGrid";
            ticTacToeGrid.RowCount = 3;
            ticTacToeGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ticTacToeGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ticTacToeGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ticTacToeGrid.Size = new Size(1182, 635);
            ticTacToeGrid.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 55);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(396, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 55);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(790, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 55);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 55);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(396, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 55);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(790, 214);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(300, 55);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 425);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(300, 55);
            textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(396, 425);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(300, 55);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(790, 425);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(300, 55);
            textBox9.TabIndex = 8;
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 716);
            Controls.Add(ticTacToeGrid);
            Name = "GameBoard";
            Text = "Tic Tac Toe";
            ticTacToeGrid.ResumeLayout(false);
            ticTacToeGrid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ticTacToeGrid;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}
