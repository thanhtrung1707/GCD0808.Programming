
namespace TickTacToe
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
			this.button_11 = new System.Windows.Forms.Button();
			this.button_12 = new System.Windows.Forms.Button();
			this.button_13 = new System.Windows.Forms.Button();
			this.button_21 = new System.Windows.Forms.Button();
			this.button_22 = new System.Windows.Forms.Button();
			this.button_23 = new System.Windows.Forms.Button();
			this.button_31 = new System.Windows.Forms.Button();
			this.button_32 = new System.Windows.Forms.Button();
			this.button_33 = new System.Windows.Forms.Button();
			this.playerOneStatus = new System.Windows.Forms.Label();
			this.playerTwoStatus = new System.Windows.Forms.Label();
			this.winner = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_11
			// 
			this.button_11.Location = new System.Drawing.Point(194, 77);
			this.button_11.Name = "button_11";
			this.button_11.Size = new System.Drawing.Size(75, 23);
			this.button_11.TabIndex = 0;
			this.button_11.UseVisualStyleBackColor = true;
			this.button_11.Click += new System.EventHandler(this.buttonClick);
			// 
			// button_12
			// 
			this.button_12.Location = new System.Drawing.Point(300, 76);
			this.button_12.Name = "button_12";
			this.button_12.Size = new System.Drawing.Size(75, 23);
			this.button_12.TabIndex = 1;
			this.button_12.UseVisualStyleBackColor = true;
			this.button_12.Click += new System.EventHandler(this.button_12_Click);
			// 
			// button_13
			// 
			this.button_13.Location = new System.Drawing.Point(420, 76);
			this.button_13.Name = "button_13";
			this.button_13.Size = new System.Drawing.Size(75, 23);
			this.button_13.TabIndex = 2;
			this.button_13.UseVisualStyleBackColor = true;
			this.button_13.Click += new System.EventHandler(this.button_13_Click);
			// 
			// button_21
			// 
			this.button_21.Location = new System.Drawing.Point(194, 119);
			this.button_21.Name = "button_21";
			this.button_21.Size = new System.Drawing.Size(75, 23);
			this.button_21.TabIndex = 3;
			this.button_21.UseVisualStyleBackColor = true;
			this.button_21.Click += new System.EventHandler(this.button_21_Click);
			// 
			// button_22
			// 
			this.button_22.Location = new System.Drawing.Point(300, 118);
			this.button_22.Name = "button_22";
			this.button_22.Size = new System.Drawing.Size(75, 23);
			this.button_22.TabIndex = 4;
			this.button_22.UseVisualStyleBackColor = true;
			this.button_22.Click += new System.EventHandler(this.button_22_Click);
			// 
			// button_23
			// 
			this.button_23.Location = new System.Drawing.Point(420, 118);
			this.button_23.Name = "button_23";
			this.button_23.Size = new System.Drawing.Size(75, 23);
			this.button_23.TabIndex = 5;
			this.button_23.UseVisualStyleBackColor = true;
			this.button_23.Click += new System.EventHandler(this.button_23_Click);
			// 
			// button_31
			// 
			this.button_31.Location = new System.Drawing.Point(194, 166);
			this.button_31.Name = "button_31";
			this.button_31.Size = new System.Drawing.Size(75, 23);
			this.button_31.TabIndex = 6;
			this.button_31.UseVisualStyleBackColor = true;
			this.button_31.Click += new System.EventHandler(this.button_31_Click);
			// 
			// button_32
			// 
			this.button_32.Location = new System.Drawing.Point(300, 166);
			this.button_32.Name = "button_32";
			this.button_32.Size = new System.Drawing.Size(75, 23);
			this.button_32.TabIndex = 7;
			this.button_32.UseVisualStyleBackColor = true;
			this.button_32.Click += new System.EventHandler(this.button_32_Click);
			// 
			// button_33
			// 
			this.button_33.Location = new System.Drawing.Point(420, 166);
			this.button_33.Name = "button_33";
			this.button_33.Size = new System.Drawing.Size(75, 23);
			this.button_33.TabIndex = 8;
			this.button_33.UseVisualStyleBackColor = true;
			this.button_33.Click += new System.EventHandler(this.button_33_Click);
			// 
			// playerOneStatus
			// 
			this.playerOneStatus.AutoSize = true;
			this.playerOneStatus.Location = new System.Drawing.Point(194, 30);
			this.playerOneStatus.Name = "playerOneStatus";
			this.playerOneStatus.Size = new System.Drawing.Size(139, 17);
			this.playerOneStatus.TabIndex = 9;
			this.playerOneStatus.Text = "Player 1 is playing ...";
			// 
			// playerTwoStatus
			// 
			this.playerTwoStatus.AutoSize = true;
			this.playerTwoStatus.Location = new System.Drawing.Point(420, 30);
			this.playerTwoStatus.Name = "playerTwoStatus";
			this.playerTwoStatus.Size = new System.Drawing.Size(60, 17);
			this.playerTwoStatus.TabIndex = 10;
			this.playerTwoStatus.Text = "Player 2";
			// 
			// winner
			// 
			this.winner.AutoSize = true;
			this.winner.Location = new System.Drawing.Point(317, 234);
			this.winner.Name = "winner";
			this.winner.Size = new System.Drawing.Size(0, 17);
			this.winner.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.winner);
			this.Controls.Add(this.playerTwoStatus);
			this.Controls.Add(this.playerOneStatus);
			this.Controls.Add(this.button_33);
			this.Controls.Add(this.button_32);
			this.Controls.Add(this.button_31);
			this.Controls.Add(this.button_23);
			this.Controls.Add(this.button_22);
			this.Controls.Add(this.button_21);
			this.Controls.Add(this.button_13);
			this.Controls.Add(this.button_12);
			this.Controls.Add(this.button_11);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_11;
		private System.Windows.Forms.Button button_12;
		private System.Windows.Forms.Button button_13;
		private System.Windows.Forms.Button button_21;
		private System.Windows.Forms.Button button_22;
		private System.Windows.Forms.Button button_23;
		private System.Windows.Forms.Button button_31;
		private System.Windows.Forms.Button button_32;
		private System.Windows.Forms.Button button_33;
		private System.Windows.Forms.Label playerOneStatus;
		private System.Windows.Forms.Label playerTwoStatus;
		private System.Windows.Forms.Label winner;
	}
}

