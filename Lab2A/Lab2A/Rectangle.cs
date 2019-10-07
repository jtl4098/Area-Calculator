using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program : Rectangle
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Rectangle
/// 
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    public class Rectangle : TwoDimensional
    {
        private double lengthOfRectangle; // Backing variable
        public double LengthOfRectangle 
        {
            get
            {
                return lengthOfRectangle; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else
                    lengthOfRectangle = value;

            }
        }

        private double widthOfRectangle; // Backing variable
        public double WidthOfRectangle
        {
            get
            { 
                return widthOfRectangle; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else
                    widthOfRectangle = value;

            }
        }
        /// <summary>
        /// Set the type into Rectangle
        /// To create Rectangle object with length and width
        /// </summary>
        /// <param name="lengthOfRectangle"></param>
        /// <param name="widthOfRectangle"></param>
        public Rectangle (double lengthOfRectangle, double widthOfRectangle)
        {
            Type = "Rectangle";
            LengthOfRectangle = lengthOfRectangle;
            WidthOfRectangle = widthOfRectangle;
        }

        /// <summary>
        /// To calcualate the area of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateArea() => (lengthOfRectangle * widthOfRectangle);


        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type,lenthOfRectangle, widthOfRectangle, CalculateArea()</returns>

        public override string ToString()
        {
            return $"[TYPE = {Type}] , Length : {lengthOfRectangle} , Width : {widthOfRectangle} , Area : {CalculateArea()}";
        }
    }
}
