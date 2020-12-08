using System;
using System.Windows.Forms;

namespace EventDrivenProgramming
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void AddAction_Click(object sender, EventArgs e)
		{
			var firstNumber = int.Parse(FirstNumber.Text);
			var secondNumber = int.Parse(SecondNumber.Text);

			Result.Text = $"{firstNumber + secondNumber}";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Result.Text = "N/A";
			FirstNumber.Text = "0";
			SecondNumber.Text = "0";
		}
	}
}
