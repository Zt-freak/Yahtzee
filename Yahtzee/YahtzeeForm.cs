using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class YahtzeeForm : Form
    {
        private List<int> players = new List<int>();
        private int turnScore = 0;
        private int currentTurn = 0;
        private int rollsLeft = 0;

        public YahtzeeForm()
        {
            InitializeComponent();
        }

        private void ClearGameData()
        {
            this.players.Clear();
            this.turnScore = 0;
            this.currentTurn = 0;

            this.p1Score.Enabled = false;
            this.p2Score.Enabled = false;
            this.p3Score.Enabled = false;
            this.p4Score.Enabled = false;

            this.playerTurn.Enabled = false;
            this.rollsLeftAmount.Enabled = false;
            this.turnScoreAmount.Enabled = false;
            this.lock1.Enabled = false;
            this.dice1.Enabled = false;
            this.lock2.Enabled = false;
            this.dice2.Enabled = false;
            this.lock3.Enabled = false;
            this.dice3.Enabled = false;
            this.lock4.Enabled = false;
            this.dice4.Enabled = false;
            this.lock5.Enabled = false;
            this.dice5.Enabled = false;
            this.RollButton.Enabled = false;
        }

        private void UpdatePlayerScores()
        {
            this.p1Score.Enabled = true;
            this.p1Score.Text = "Player 1 score: " + this.players[0];
            this.p2Score.Enabled = true;
            this.p2Score.Text = "Player 2 score: " + this.players[1];
            if (this.players.Count > 2)
            {
                this.p3Score.Enabled = true;
                this.p3Score.Text = "Player 3 score: " + this.players[2];
            }
            if (this.players.Count == 4)
            {
                this.p4Score.Enabled = true;
                this.p4Score.Text = "Player 4 score: " + this.players[3];
            }
        }

        private void StartTurn()
        {
            this.lock1.Enabled = false;
            this.lock2.Enabled = false;
            this.lock3.Enabled = false;
            this.lock4.Enabled = false;
            this.lock5.Enabled = false;

            this.rollsLeft = 3;
            this.turnScore = 0;

            switch (this.currentTurn)
            {
                case 0:
                    this.playerTurn.Text = "Player 1 turn";
                    break;
                case 1:
                    this.playerTurn.Text = "Player 2 turn";
                    break;
                case 2:
                    this.playerTurn.Text = "Player 3 turn";
                    break;
                case 3:
                    this.playerTurn.Text = "Player 4 turn";
                    break;
            }

            this.rollsLeftAmount.Text = "rolls left: " + this.rollsLeft;
            this.turnScoreAmount.Text = "score: " + this.turnScore;
        }

        private void NextTurn ()
        {
            this.p1Score.Text = "Player 1 score: " + this.players[0];
            this.p2Score.Text = "Player 2 score: " + this.players[1];
            if (2 < this.players.Count - 1)
            {
                this.p3Score.Text = "Player 3 score: " + this.players[2];
            }
            if (3 < this.players.Count - 1)
            {
                this.p4Score.Text = "Player 4 score: " + this.players[3];
            }

            if (this.currentTurn < this.players.Count - 1)
            {
                this.currentTurn++;
            }
            else
            {
                this.currentTurn = 0;
            }
            this.StartTurn();
        }

        private void Roll()
        {
            Random rnd = new Random();

            if (!this.lock1.Checked)
            {
                this.dice1.Text = rnd.Next(1, 7).ToString();
            }
            if (!this.lock2.Checked)
            {
                this.dice2.Text = rnd.Next(1, 7).ToString();
            }
            if (!this.lock3.Checked)
            {
                this.dice3.Text = rnd.Next(1, 7).ToString();
            }
            if (!this.lock4.Checked)
            {
                this.dice4.Text = rnd.Next(1, 7).ToString();
            }
            if (!this.lock5.Checked)
            {
                this.dice5.Text = rnd.Next(1, 7).ToString();
            }

            this.CheckScore();

            this.rollsLeft--;
            this.rollsLeftAmount.Text = "rolls left: " + this.rollsLeft;
            this.turnScoreAmount.Text = "score: " + this.turnScore;
        }

        private void CheckScore()
        {
            this.turnScore = 0;

            List<int> diceValues = new List<int>();
            diceValues.Add(Int32.Parse(this.dice1.Text));
            diceValues.Add(Int32.Parse(this.dice2.Text));
            diceValues.Add(Int32.Parse(this.dice3.Text));
            diceValues.Add(Int32.Parse(this.dice4.Text));
            diceValues.Add(Int32.Parse(this.dice5.Text));

            int oneSum = 0;
            int twoSum = 0;
            int threeSum = 0;
            int fourSum = 0;
            int fiveSum = 0;
            int sixSum = 0;

            for (int i = 0; i < diceValues.Count - 1; i++)
            {
                switch (diceValues[i])
                {
                    case 1:
                        oneSum++;
                        break;
                    case 2:
                        twoSum += 2;
                        break;
                    case 3:
                        threeSum += 3;
                        break;
                    case 4:
                        fourSum += 4;
                        break;
                    case 5:
                        fiveSum += 5;
                        break;
                    case 6:
                        sixSum += 6;
                        break;
                }
            }

            this.turnScore = oneSum + twoSum + threeSum + fourSum + fiveSum + sixSum;


            if (this.rollsLeft == 1)
            {
                this.players[this.currentTurn] += this.turnScore;
            }
        }

        private void StartNewGame()
        {
            this.ClearGameData();
            int playerCount = Decimal.ToInt32(this.newPlayerUpDown.Value);
            for (int i = 0; i < playerCount; i++)
            {
                players.Add(0);
            }
            this.UpdatePlayerScores();
            this.StartTurn();

            this.playerTurn.Enabled = true;
            this.rollsLeftAmount.Enabled = true;
            this.turnScoreAmount.Enabled = true;
            this.lock1.Enabled = false;
            this.lock1.Checked = false;
            this.dice1.Enabled = true;
            this.lock2.Enabled = false;
            this.lock2.Checked = false;
            this.dice2.Enabled = true;
            this.lock3.Enabled = false;
            this.lock3.Checked = false;
            this.dice3.Enabled = true;
            this.lock4.Enabled = false;
            this.lock4.Checked = false;
            this.dice4.Enabled = true;
            this.lock5.Enabled = false;
            this.lock5.Checked = false;
            this.dice5.Enabled = true;
            this.RollButton.Enabled = true;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            this.StartNewGame();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            switch (this.rollsLeft)
            {
                case 0:
                    this.NextTurn();
                    this.RollButton.Text = "Roll";
                    break;
                case 1:
                    this.Roll();
                    this.lock1.Enabled = false;
                    this.lock2.Enabled = false;
                    this.lock3.Enabled = false;
                    this.lock4.Enabled = false;
                    this.lock5.Enabled = false;
                    this.lock1.Checked = false;
                    this.lock2.Checked = false;
                    this.lock3.Checked = false;
                    this.lock4.Checked = false;
                    this.lock5.Checked = false;
                    this.RollButton.Text = "Next Turn";
                    break;
                case 2:
                    this.Roll();
                    break;
                case 3:
                    this.Roll();
                    this.lock1.Enabled = true;
                    this.lock2.Enabled = true;
                    this.lock3.Enabled = true;
                    this.lock4.Enabled = true;
                    this.lock5.Enabled = true;
                    break;
                default:
                    this.Roll();
                    break;
            }
        }
    }
}
