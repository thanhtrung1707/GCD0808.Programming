using System;
using System.Windows.Forms;

namespace TickTacToe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private bool _playerStatus = true; // true: playerOne, false: playerTwo

		private void CheckWinner()
		{
			if (button_11.Text.Equals("X") && button_12.Text.Equals("X") && button_13.Text.Equals("X"))
			{
				winner.Text = "Player 1 Won...";
			}
		}

		private void ButtonClick(Button button)
		{
			if (String.IsNullOrEmpty(button.Text))
			{
				if (_playerStatus)
				{
					button.Text = "X";
				}
				else
				{
					button.Text = "0";
				}

				CheckWinner();

				_playerStatus = !_playerStatus;

				if (_playerStatus)
				{
					playerOneStatus.Text = "Player One is playing...";
					playerTwoStatus.Text = "Player Two";
				}
				else
				{
					playerOneStatus.Text = "Player One";
					playerTwoStatus.Text = "Player Two is playing...";
				}
			}
		}
		private void buttonClick(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);



		}

		private void button_12_Click(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);
		}

		private void button_13_Click(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);

		}

		private void button_21_Click(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);

		}

		private void button_22_Click(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);

		}

		private void button_23_Click(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);

		}

		private void button_31_Click(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);

		}

		private void button_32_Click(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);

		}

		private void button_33_Click(object sender, EventArgs e)
		{
			ButtonClick((Button)sender);

		}
	}
}
