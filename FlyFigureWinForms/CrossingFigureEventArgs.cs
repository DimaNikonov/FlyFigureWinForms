//-----------------------------------------------------------------------
//
// <copyright file="CrossingFigureEventArgs.cs" company="DCT">
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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// esf e fw
    /// </summary>
    public class CrossingFigureEventArgs : EventArgs
    {
        /// <summary>
        /// werq w3r 
        /// </summary>
        private readonly Figure figure1;

        /// <summary>
        /// w3er q3erqw
        /// </summary>
        private readonly Figure figure2;

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossingFigureEventArgs"/> class.
        /// </summary>
        /// <param name="figure1">Figure type figure1 parameter</param>
        /// <param name="figure2">Figure type figure2 parametr</param>
        public CrossingFigureEventArgs(Figure figure1, Figure figure2)
        {
            this.figure1 = figure1;
            this.figure2 = figure2;
        }

        /// <summary>
        /// Gets figure1
        /// </summary>
        public Figure Figure1
        {
            get
            {
                return this.figure1;
            }
        }

        /// <summary>
        /// Gets figure2
        /// </summary>
        public Figure Figure2
        {
            get
            {
                return this.figure2;
            }
        }
    }
}
