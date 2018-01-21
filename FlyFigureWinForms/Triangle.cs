//-----------------------------------------------------------------------
//
// <copyright file="Triangle.cs" company="DCT">
//
//     Company copyright tag.
//
// </copyright>
//
//-----------------------------------------------------------------------
namespace FlyFigureWinForms
{    
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using RandomIntValue;

    /// <summary>
    /// asdas asac.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// blah blah blah
        /// </summary>
        private Pen pen = new Pen(Color.Crimson, 5);

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="point">Point type point parametr</param>
        public Triangle(Point point)
        {
            RandomIntValue random = new RandomIntValue();

            this.Name = "Triangle";

            int sizeX = 75;
            int sizeY = 100;
            this.CoordX = random.GetRandomValue(sizeX, point.X - sizeX);
            this.CoordY = random.GetRandomValue(Figure.Min, point.Y - sizeY);

            this.SpeedX = random.GetRandomValue(Figure.Min, Figure.MaxSpeed);
            this.SpeedY = random.GetRandomValue(Figure.Min, Figure.MaxSpeed);

            int temp = random.GetRandomValue(0, 2);
            if (temp == 0)
            {
                this.SpeedX = -this.SpeedX;
                this.SpeedY = -this.SpeedY;
            }

            this.Area = this.SizeY * this.SizeX;
        }

        /// <summary>
        /// Draw triangle.
        /// </summary>
        /// <param name="graphics">Graphics type graphics parameter</param>
        internal override void Draw(Graphics graphics)
        {
            graphics.DrawLine(this.pen, this.CoordX, this.CoordY, this.CoordX - 75, this.CoordY + 100);
            graphics.DrawLine(this.pen, this.CoordX - 75, this.CoordY + 100, this.CoordX + 75, this.CoordY + 100);
            graphics.DrawLine(this.pen, this.CoordX, this.CoordY, this.CoordX + 75, this.CoordY + 100);
        }

        /// <summary>
        /// Change coordination X and Y. And chek the borders.
        /// </summary>
        /// <param name="pmax">Point type pmax parameter</param>
        internal override void Move(Point pmax)
        {
            if (this.CanMove)
            {
                if (this.CoordX + 75 >= pmax.X || this.CoordX - 75 <= 0)
                {
                    this.SpeedX = -this.SpeedX;
                }

                if (this.CoordY + 100 >= pmax.Y || this.CoordY <= 0)
                {
                    this.SpeedY = -this.SpeedY;
                }

                this.CoordX += this.SpeedX;
                this.CoordY += this.SpeedY;
            }
        }
    }
}
