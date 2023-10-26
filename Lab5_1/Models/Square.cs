using Lab5_1.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_1.Models
{
	public class Square : Figure
	{
		private int _diameter;

		public Square(int diameter ,PictureBox pictureBox) : base(pictureBox)
		{
			if (diameter < 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			_diameter = diameter;
		}

		public override void DrawBlack()
		{
			Graphics g = _pictureBox.CreateGraphics();

			g.DrawRectangle(new Pen(Color.Black), new Rectangle(_x, _y, _diameter, _diameter));
		}

		public override void HideDrawingBackground()
		{
			Graphics g = _pictureBox.CreateGraphics();

			Color backgroundColor = Color.White;

			using (Brush brush = new SolidBrush(backgroundColor))
			{
				g.FillRectangle(brush, 0, 0, _pictureBox.Width, _pictureBox.Height);
			}
		}
	}
}
