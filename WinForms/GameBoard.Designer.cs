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
            btnCell00 = new Button();
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
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCell00);
            panel1.Location = new Point(34, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 321);
            panel1.TabIndex = 3;
            // 
            // btnCell00
            // 
            btnCell00.Font = new Font("Comic Sans MS", 27.75F);
            btnCell00.Location = new Point(13, 15);
            btnCell00.Name = "btnCell00";
            btnCell00.Size = new Size(94, 94);
            btnCell00.TabIndex = 2;
            btnCell00.Text = "?";
            btnCell00.UseVisualStyleBackColor = true;
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
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
        private Button btnCell00;
    }
}
