
namespace EventDrivenProgramming
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
			this.FirstNumber = new System.Windows.Forms.TextBox();
			this.SecondNumber = new System.Windows.Forms.TextBox();
			this.AddAction = new System.Windows.Forms.Button();
			this.EqualSign = new System.Windows.Forms.Label();
			this.Result = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FirstNumber
			// 
			this.FirstNumber.BackColor = System.Drawing.SystemColors.Highlight;
			this.FirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstNumber.Location = new System.Drawing.Point(85, 68);
			this.FirstNumber.Name = "FirstNumber";
			this.FirstNumber.Size = new System.Drawing.Size(100, 34);
			this.FirstNumber.TabIndex = 0;
			this.FirstNumber.Text = "0";
			// 
			// SecondNumber
			// 
			this.SecondNumber.Location = new System.Drawing.Point(304, 69);
			this.SecondNumber.Name = "SecondNumber";
			this.SecondNumber.Size = new System.Drawing.Size(100, 22);
			this.SecondNumber.TabIndex = 1;
			this.SecondNumber.Text = "0";
			// 
			// AddAction
			// 
			this.AddAction.Location = new System.Drawing.Point(204, 68);
			this.AddAction.Name = "AddAction";
			this.AddAction.Size = new System.Drawing.Size(75, 23);
			this.AddAction.TabIndex = 2;
			this.AddAction.Text = "+";
			this.AddAction.UseVisualStyleBackColor = true;
			this.AddAction.Click += new System.EventHandler(this.AddAction_Click);
			// 
			// EqualSign
			// 
			this.EqualSign.AutoSize = true;
			this.EqualSign.Location = new System.Drawing.Point(438, 71);
			this.EqualSign.Name = "EqualSign";
			this.EqualSign.Size = new System.Drawing.Size(16, 17);
			this.EqualSign.TabIndex = 3;
			this.EqualSign.Text = "=";
			// 
			// Result
			// 
			this.Result.AutoSize = true;
			this.Result.Location = new System.Drawing.Point(509, 71);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(31, 17);
			this.Result.TabIndex = 4;
			this.Result.Text = "N/A";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(204, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Result);
			this.Controls.Add(this.EqualSign);
			this.Controls.Add(this.AddAction);
			this.Controls.Add(this.SecondNumber);
			this.Controls.Add(this.FirstNumber);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FirstNumber;
		private System.Windows.Forms.TextBox SecondNumber;
		private System.Windows.Forms.Button AddAction;
		private System.Windows.Forms.Label EqualSign;
		private System.Windows.Forms.Label Result;
		private System.Windows.Forms.Button button1;
	}
}

