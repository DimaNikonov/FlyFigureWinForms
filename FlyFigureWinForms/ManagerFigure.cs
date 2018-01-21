//-----------------------------------------------------------------------
//
// <copyright file="ManagerFigure.cs" company="DCT">
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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// sadfas sdva
    /// </summary>
    internal class ManagerFigure
    {
        /// <summary>
        /// sdf saef a
        /// </summary>
        private List<Figure> listFigure;        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerFigure"/> class.
        /// </summary>
        /// <param name="listFigure">Figure type listFigure parameter</param>
        public ManagerFigure(List<Figure> listFigure)
        {
            this.listFigure = listFigure; 
        }

        /// <summary>
        /// xvsd sdf 
        /// </summary>
        public event EventHandler<CrossingFigureEventArgs> CrossingFigure;

        protected void OnCrossingFigure(CrossingFigureEventArgs e)
        { 
            EventHandler<CrossingFigureEventArgs> temp =  CrossingFigure;
            if (temp != null)
                temp(this, e);
        }

        public void CrossingFigureNow (Figure figure1, Figure figure2)
        {
            CrossingFigureEventArgs e = new CrossingFigureEventArgs(figure1, figure2);

            OnCrossingFigure(e);
        }
    }
}
