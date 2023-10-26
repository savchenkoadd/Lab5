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
	public class Rhomb : Figure
	{
		private int _width;
		private int _height;

		public Rhomb(int width, int height, PictureBox pictureBox) : base(pictureBox)
		{
			if (width < 0 || height < 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			_width = width;
			_height = height;
		}

		public override void DrawBlack()
		{
			Point[] points =
			{
				new Point(_x + _width / 2, _y),
				new Point(_x + _width, _y + _height / 2),
				new Point(_x + _width / 2, _y + _height),
				new Point(_x, _y + _height / 2)
			};

			_graphics.DrawPolygon(new Pen(Color.Black), points);
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
