using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ACNH_win
{
	public partial class Form2frmSpeechBubble : Form
	{
		private readonly Timer _timer;
		private readonly string _text;

		public Form2frmSpeechBubble(string text)
		{
			InitializeComponent();

			_text = $"「{text}」";

			// Form 外觀
			this.FormBorderStyle = FormBorderStyle.None;
			this.ShowInTaskbar = false;
			this.TopMost = true;

			this.Padding = new Padding(8);
			this.Size = new Size(130, 48);
			this.BackColor = Color.White;

			// 減少閃爍、確保繪圖順
			this.DoubleBuffered = true;

			// Timer
			_timer = new Timer();
			_timer.Interval = 5000; // 5 秒
			_timer.Tick += (_, __) =>
			{
				_timer.Stop();
				this.Close();
			};
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			ApplyRoundedCorners(14);
			_timer.Start();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			// 畫半透明背景（淡米白 + alpha）
			var bg = Color.FromArgb(220, 255, 252, 245); // 0~255，越小越透明
			using (var brush = new SolidBrush(bg))
			{
				e.Graphics.FillRectangle(brush, this.ClientRectangle);
			}

			// 畫文字（置中）
			using (var font = new Font("微軟正黑體", 9.5f, FontStyle.Bold))
			using (var textBrush = new SolidBrush(Color.FromArgb(80, 60, 40)))
			{
				var rect = Rectangle.Inflate(this.ClientRectangle, -8, -8);
				var sf = new StringFormat
				{
					Alignment = StringAlignment.Center,
					LineAlignment = StringAlignment.Center,
					Trimming = StringTrimming.EllipsisCharacter
				};

				e.Graphics.DrawString(_text, font, textBrush, rect, sf);
			}
		}

		private void ApplyRoundedCorners(int radius)
		{
			var path = new GraphicsPath();
			int w = this.Width;
			int h = this.Height;
			int r = radius;

			path.StartFigure();
			path.AddArc(0, 0, r, r, 180, 90);
			path.AddArc(w - r, 0, r, r, 270, 90);
			path.AddArc(w - r, h - r, r, r, 0, 90);
			path.AddArc(0, h - r, r, r, 90, 90);
			path.CloseFigure();

			this.Region = new Region(path);
		}
	}
}
