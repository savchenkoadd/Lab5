using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_1.Models.Interfaces
{
	public abstract class Figure
	{
		protected int _x;
		protected int _y;
		protected PictureBox _pictureBox;
		protected Graphics _graphics;

		public Figure(PictureBox pictureBox)
		{
			_pictureBox = pictureBox;
			_graphics = pictureBox.CreateGraphics();
		}

		public abstract void DrawBlack();
		public abstract void HideDrawingBackground();

		public void MoveRight(int step)
		{
			if (step < 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			_x += step;
		}
	}
}
