namespace TicTacToeCSharpGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(12, 13);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(93, 83);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(12, 101);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(93, 83);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(12, 190);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(93, 83);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(111, 190);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(93, 83);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(111, 101);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(93, 83);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(111, 12);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(93, 83);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(210, 190);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(93, 83);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(210, 101);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(93, 83);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(210, 12);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(93, 83);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(12, 300);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(93, 33);
            this.NewGameButton.TabIndex = 9;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(111, 300);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(93, 33);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(210, 300);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 33);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(330, 44);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(90, 42);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "label1";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(330, 132);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(90, 42);
            this.OWin.TabIndex = 13;
            this.OWin.Text = "label2";
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(330, 221);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(90, 42);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 419);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
    }
}

