﻿//-----------------------------------------------------------------------
//
// <copyright file="Rectangle.cs" company="DCT">
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
    /// xgsdgb sdfsb.
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// blah blah blah
        /// </summary>
        private Pen pen = new Pen(Color.CadetBlue, 5);

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="point">Point type point parameter</param>
        public Rectangle(Point point)
        {
            RandomIntValue random = new RandomIntValue();

            this.Name = "Rectangle";

            this.SizeX = 50;
            this.SizeY = 100;
            
            this.CoordX = random.GetRandomValue(Figure.Min, point.X - this.SizeX);
            this.CoordY = random.GetRandomValue(Figure.Min, point.Y - this.SizeY);

            this.SpeedX = random.GetRandomValue(Figure.Min, Figure.MaxSpeed);
            this.SpeedY = random.GetRandomValue(Figure.Min, Figure.MaxSpeed);

            int temp = random.GetRandomValue(0, 2);

            if (temp == 0)
            {
                this.SpeedX = -this.SpeedX;
                this.SpeedY = -this.SpeedY;
            }

            this.Area = this.SizeX * this.SizeY;
        }

        /// <summary>
        /// Draw rectangle.
        /// </summary>
        /// <param name="graphics">Graphics type graphics parameter</param>
        internal override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(this.pen, this.CoordX, this.CoordY, this.SizeX, this.SizeY);
        }

        /// <summary>
        /// Change coordination X and Y. And chek the borders.
        /// </summary>
        /// <param name="pmax">Point type pmax parameter</param>
        internal override void Move(Point pmax)
        {
            if (this.CanMove)
            {
                if (this.CoordX + this.SizeX >= pmax.X || this.CoordX <= 0)
                {
                    this.SpeedX = -this.SpeedX;
                }

                if (this.CoordY + this.SizeY >= pmax.Y || this.CoordY <= 0)
                {
                    this.SpeedY = -this.SpeedY;
                }

                this.CoordX += this.SpeedX;
                this.CoordY += this.SpeedY;
            }
        }
    }
}
