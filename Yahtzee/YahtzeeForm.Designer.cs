namespace Yahtzee
{
    partial class YahtzeeForm
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.rollsLeftAmount = new System.Windows.Forms.Label();
            this.turnScoreAmount = new System.Windows.Forms.Label();
            this.newPlayerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.playerTurn = new System.Windows.Forms.Label();
            this.dice1 = new System.Windows.Forms.TextBox();
            this.lock1 = new System.Windows.Forms.CheckBox();
            this.lock2 = new System.Windows.Forms.CheckBox();
            this.dice2 = new System.Windows.Forms.TextBox();
            this.lock3 = new System.Windows.Forms.CheckBox();
            this.dice3 = new System.Windows.Forms.TextBox();
            this.lock4 = new System.Windows.Forms.CheckBox();
            this.dice4 = new System.Windows.Forms.TextBox();
            this.lock5 = new System.Windows.Forms.CheckBox();
            this.dice5 = new System.Windows.Forms.TextBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.p1Score = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.p3Score = new System.Windows.Forms.Label();
            this.p4Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newPlayerUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newGameButton.Location = new System.Drawing.Point(140, 11);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(87, 19);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // rollsLeftAmount
            // 
            this.rollsLeftAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rollsLeftAmount.AutoSize = true;
            this.rollsLeftAmount.Enabled = false;
            this.rollsLeftAmount.Location = new System.Drawing.Point(139, 112);
            this.rollsLeftAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rollsLeftAmount.Name = "rollsLeftAmount";
            this.rollsLeftAmount.Size = new System.Drawing.Size(54, 13);
            this.rollsLeftAmount.TabIndex = 1;
            this.rollsLeftAmount.Text = "rolls left: 0";
            this.rollsLeftAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // turnScoreAmount
            // 
            this.turnScoreAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.turnScoreAmount.AutoSize = true;
            this.turnScoreAmount.Enabled = false;
            this.turnScoreAmount.Location = new System.Drawing.Point(139, 125);
            this.turnScoreAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.turnScoreAmount.Name = "turnScoreAmount";
            this.turnScoreAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.turnScoreAmount.Size = new System.Drawing.Size(45, 13);
            this.turnScoreAmount.TabIndex = 2;
            this.turnScoreAmount.Text = "score: 0";
            this.turnScoreAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newPlayerUpDown
            // 
            this.newPlayerUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newPlayerUpDown.Location = new System.Drawing.Point(140, 67);
            this.newPlayerUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newPlayerUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.newPlayerUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.newPlayerUpDown.Name = "newPlayerUpDown";
            this.newPlayerUpDown.Size = new System.Drawing.Size(86, 20);
            this.newPlayerUpDown.TabIndex = 3;
            this.newPlayerUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "number of players:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // playerTurn
            // 
            this.playerTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerTurn.AutoSize = true;
            this.playerTurn.Enabled = false;
            this.playerTurn.Location = new System.Drawing.Point(139, 99);
            this.playerTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(66, 13);
            this.playerTurn.TabIndex = 5;
            this.playerTurn.Text = "Player 1 turn";
            this.playerTurn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dice1
            // 
            this.dice1.Enabled = false;
            this.dice1.Location = new System.Drawing.Point(9, 11);
            this.dice1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dice1.Name = "dice1";
            this.dice1.ReadOnly = true;
            this.dice1.Size = new System.Drawing.Size(67, 20);
            this.dice1.TabIndex = 6;
            this.dice1.Text = "0";
            // 
            // lock1
            // 
            this.lock1.AutoSize = true;
            this.lock1.Enabled = false;
            this.lock1.Location = new System.Drawing.Point(9, 34);
            this.lock1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lock1.Name = "lock1";
            this.lock1.Size = new System.Drawing.Size(75, 17);
            this.lock1.TabIndex = 8;
            this.lock1.Text = "lock value";
            this.lock1.UseVisualStyleBackColor = true;
            // 
            // lock2
            // 
            this.lock2.AutoSize = true;
            this.lock2.Enabled = false;
            this.lock2.Location = new System.Drawing.Point(9, 78);
            this.lock2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lock2.Name = "lock2";
            this.lock2.Size = new System.Drawing.Size(75, 17);
            this.lock2.TabIndex = 10;
            this.lock2.Text = "lock value";
            this.lock2.UseVisualStyleBackColor = true;
            // 
            // dice2
            // 
            this.dice2.Enabled = false;
            this.dice2.Location = new System.Drawing.Point(9, 55);
            this.dice2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dice2.Name = "dice2";
            this.dice2.ReadOnly = true;
            this.dice2.Size = new System.Drawing.Size(67, 20);
            this.dice2.TabIndex = 9;
            this.dice2.Text = "0";
            // 
            // lock3
            // 
            this.lock3.AutoSize = true;
            this.lock3.Enabled = false;
            this.lock3.Location = new System.Drawing.Point(9, 122);
            this.lock3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lock3.Name = "lock3";
            this.lock3.Size = new System.Drawing.Size(75, 17);
            this.lock3.TabIndex = 12;
            this.lock3.Text = "lock value";
            this.lock3.UseVisualStyleBackColor = true;
            // 
            // dice3
            // 
            this.dice3.Enabled = false;
            this.dice3.Location = new System.Drawing.Point(9, 99);
            this.dice3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dice3.Name = "dice3";
            this.dice3.ReadOnly = true;
            this.dice3.Size = new System.Drawing.Size(67, 20);
            this.dice3.TabIndex = 11;
            this.dice3.Text = "0";
            // 
            // lock4
            // 
            this.lock4.AutoSize = true;
            this.lock4.Enabled = false;
            this.lock4.Location = new System.Drawing.Point(9, 166);
            this.lock4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lock4.Name = "lock4";
            this.lock4.Size = new System.Drawing.Size(75, 17);
            this.lock4.TabIndex = 14;
            this.lock4.Text = "lock value";
            this.lock4.UseVisualStyleBackColor = true;
            // 
            // dice4
            // 
            this.dice4.Enabled = false;
            this.dice4.Location = new System.Drawing.Point(9, 143);
            this.dice4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dice4.Name = "dice4";
            this.dice4.ReadOnly = true;
            this.dice4.Size = new System.Drawing.Size(67, 20);
            this.dice4.TabIndex = 13;
            this.dice4.Text = "0";
            // 
            // lock5
            // 
            this.lock5.AutoSize = true;
            this.lock5.Enabled = false;
            this.lock5.Location = new System.Drawing.Point(9, 210);
            this.lock5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lock5.Name = "lock5";
            this.lock5.Size = new System.Drawing.Size(75, 17);
            this.lock5.TabIndex = 16;
            this.lock5.Text = "lock value";
            this.lock5.UseVisualStyleBackColor = true;
            // 
            // dice5
            // 
            this.dice5.Enabled = false;
            this.dice5.Location = new System.Drawing.Point(9, 187);
            this.dice5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dice5.Name = "dice5";
            this.dice5.ReadOnly = true;
            this.dice5.Size = new System.Drawing.Size(67, 20);
            this.dice5.TabIndex = 15;
            this.dice5.Text = "0";
            // 
            // RollButton
            // 
            this.RollButton.Enabled = false;
            this.RollButton.Location = new System.Drawing.Point(9, 238);
            this.RollButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(66, 19);
            this.RollButton.TabIndex = 17;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // p1Score
            // 
            this.p1Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p1Score.AutoSize = true;
            this.p1Score.Enabled = false;
            this.p1Score.Location = new System.Drawing.Point(138, 205);
            this.p1Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(86, 13);
            this.p1Score.TabIndex = 18;
            this.p1Score.Text = "Player 1 score: 0";
            this.p1Score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p2Score
            // 
            this.p2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Score.AutoSize = true;
            this.p2Score.Enabled = false;
            this.p2Score.Location = new System.Drawing.Point(138, 218);
            this.p2Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(86, 13);
            this.p2Score.TabIndex = 19;
            this.p2Score.Text = "Player 2 score: 0";
            this.p2Score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p3Score
            // 
            this.p3Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p3Score.AutoSize = true;
            this.p3Score.Enabled = false;
            this.p3Score.Location = new System.Drawing.Point(138, 231);
            this.p3Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p3Score.Name = "p3Score";
            this.p3Score.Size = new System.Drawing.Size(86, 13);
            this.p3Score.TabIndex = 20;
            this.p3Score.Text = "Player 3 score: 0";
            this.p3Score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p4Score
            // 
            this.p4Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p4Score.AutoSize = true;
            this.p4Score.Enabled = false;
            this.p4Score.Location = new System.Drawing.Point(138, 244);
            this.p4Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p4Score.Name = "p4Score";
            this.p4Score.Size = new System.Drawing.Size(86, 13);
            this.p4Score.TabIndex = 21;
            this.p4Score.Text = "Player 4 score: 0";
            this.p4Score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // YahtzeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 266);
            this.Controls.Add(this.p4Score);
            this.Controls.Add(this.p3Score);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.lock5);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.lock4);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.lock3);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.lock2);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.lock1);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPlayerUpDown);
            this.Controls.Add(this.turnScoreAmount);
            this.Controls.Add(this.rollsLeftAmount);
            this.Controls.Add(this.newGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "YahtzeeForm";
            this.Text = "Yahtzee";
            ((System.ComponentModel.ISupportInitialize)(this.newPlayerUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.NumericUpDown newPlayerUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerTurn;
        private System.Windows.Forms.Label rollsLeftAmount;
        private System.Windows.Forms.Label turnScoreAmount;
        private System.Windows.Forms.CheckBox lock1;
        private System.Windows.Forms.TextBox dice1;
        private System.Windows.Forms.CheckBox lock2;
        private System.Windows.Forms.TextBox dice2;
        private System.Windows.Forms.CheckBox lock3;
        private System.Windows.Forms.TextBox dice3;
        private System.Windows.Forms.CheckBox lock4;
        private System.Windows.Forms.TextBox dice4;
        private System.Windows.Forms.CheckBox lock5;
        private System.Windows.Forms.TextBox dice5;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.Label p3Score;
        private System.Windows.Forms.Label p4Score;
    }
}

