//-----------------------------------------------------------------------
//
// <copyright file="Figure.cs" company="DCT">
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

    /// <summary>
    /// bla bla 
    /// </summary>
    public abstract class Figure 
    {
        /// <summary>
        /// blah blah blah
        /// </summary>
        public const int Min = 1;

        /// <summary>
        /// blah blah blah
        /// </summary>
        public const int Max = 300;

        /// <summary>
        /// blah blah blah
        /// </summary>
        public const int MaxSpeed = 5;

        /// <summary>
        /// bla bla
        /// </summary>
        private bool canMove = true;

        /// <summary>
        /// Gets or sets coordination X
        /// </summary>
        public int CoordX { get; set; }

        /// <summary>
        /// Gets or sets coordination Y
        /// </summary>
        public int CoordY { get; set; }

        /// <summary>
        /// Gets or sets size X
        /// </summary>
        public int SizeX { get; set; }

        /// <summary>
        /// Gets or sets size Y
        /// </summary>
        public int SizeY { get; set; }

        /// <summary>
        /// Gets or sets Speed X
        /// </summary>
        public int SpeedX { get; set; }

        /// <summary>
        /// Gets or sets Speed Y
        /// </summary>
        public int SpeedY { get; set; }

        /// <summary>
        /// Gets or sets Name figure
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets protected sets Area
        /// </summary>
        public double Area { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is can move.
        /// </summary>
        public bool CanMove { get => this.canMove; set => this.canMove = value; }

        /// <summary>
        /// Change coordination X and Y. And chek the borders.
        /// </summary>
        /// <param name="pmax">Point type pmax parametr</param>
        internal abstract void Move(Point pmax);

        /// <summary>
        /// Draw figure.
        /// </summary>
        /// <param name="graphics">Graphics type graphics parameter</param>
        internal abstract void Draw(Graphics graphics);
    }
}
