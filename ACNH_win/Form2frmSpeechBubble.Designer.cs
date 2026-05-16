namespace ACNH_win
{
	partial class Form2frmSpeechBubble
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
			lblSpeech = new Label();
			SuspendLayout();
			// 
			// lblSpeech
			// 
			lblSpeech.Font = new Font("微軟正黑體", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
			lblSpeech.Location = new Point(10, 10);
			lblSpeech.MaximumSize = new Size(140, 0);
			lblSpeech.Name = "lblSpeech";
			lblSpeech.Size = new Size(140, 0);
			lblSpeech.TabIndex = 0;
			lblSpeech.Text = "label1";
			lblSpeech.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form2frmSpeechBubble
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(800, 450);
			Controls.Add(lblSpeech);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form2frmSpeechBubble";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.Manual;
			Text = "對話框";
			TopMost = true;
			ResumeLayout(false);
		}

		#endregion

		private Label lblSpeech;
	}
}