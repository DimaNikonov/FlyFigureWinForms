//-----------------------------------------------------------------------
//
// <copyright file="RandomIntValue.cs" company="DCT">
//
//          Company copyright tag.
//
// </copyright>
//
//-----------------------------------------------------------------------
namespace RandomIntValue
{
    using System;

    /// <summary>
    /// sdfs sef 
    /// </summary>
    public class RandomIntValue
    {
        /// <summary>
        /// asda wed wa
        /// </summary>
        private Random random;

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomIntValue"/> class.
        /// </summary>
        public RandomIntValue()
        {
            this.random = new Random();
        }

        /// <summary>
        /// Method return random value type int from firstValue to secondValue
        /// </summary>
        /// <param name="firstValue">Int type firstValue parameter</param>
        /// <param name="secondValue">Int type second parameter</param>
        /// <returns>Random value type int</returns>
        public int GetRandomValue(int firstValue, int secondValue)
        {
            return this.random.Next(firstValue, secondValue);
        }
    }
}
