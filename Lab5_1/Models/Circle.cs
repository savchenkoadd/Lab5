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
	public class Circle : Figure
	{
		private int _radius;

		public Circle(int radius, PictureBox pictureBox) : base(pictureBox)
		{
			if (radius < 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			_radius = radius;
		}

		public override void DrawBlack()
		{
			_graphics.DrawEllipse(new Pen(Color.Black), new Rectangle(_x, _y, _radius, _radius));
		}

		public override void HideDrawingBackground()
		{
			Color backgroundColor = Color.White;

			using (Brush brush = new SolidBrush(backgroundColor))
			{
				_graphics.FillRectangle(brush, 0, 0, _pictureBox.Width, _pictureBox.Height);
			}
		}
	}
}
