using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Program : Square
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Square
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    public class Square : TwoDimensional
    {
        private double lengthOfSquare; // Backing variable
        public double LengthOfSquare
        {
            get
            {
                return lengthOfSquare; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else
                    lengthOfSquare = value;

            }
        }
        /// <summary>
        /// Set the type into Square
        /// To create Square object with length
        /// </summary>
        /// <param name="lengthOfSquare"></param>
        public Square(double lengthOfSquare)
        {
            Type = "Square";
            LengthOfSquare = lengthOfSquare;
        }

        /// <summary>
        /// To calcualate the area of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateArea() => (lengthOfSquare * lengthOfSquare);


        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type,lengthOfSquare CalculateArea() </returns>
        public override string ToString()
        {
            return $"[TYPE = {Type}] , Length : {lengthOfSquare} , Area : {CalculateArea()}";
        }
    }
}
