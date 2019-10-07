using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program : Box
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Box
///
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{

    public class Box : ThreeDimensional
    {
        private double lengthOfBox; // Backing variable
        public double LengthOfBox
        {
            get
            {
                return lengthOfBox; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else
                    lengthOfBox = value;

            }
        }

        private double widthOfBox; // Backing variable
        public double WidthOfBox 
        {
            get
            {
                return widthOfBox; // return baking variable
            }
            set  // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else
                    widthOfBox = value;

            }
        }

        private double heightOfBox;  // Backing variable
        public double HeightOfBox
        {
            get 
            {
                return heightOfBox; // return baking variable
            }
            set  // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else
                    heightOfBox = value;

            }
        }
        /// <summary>
        /// set the type into Box
        /// to create Box object with length, width , height from user's input
        /// </summary>
        /// <param name="lengthOfBox"></param>
        /// <param name="widthOfBox"></param>
        /// <param name="heightOfBox"></param>
        public Box(double lengthOfBox, double widthOfBox, double heightOfBox)
        {
            Type = "Box";
            LengthOfBox = lengthOfBox;
            WidthOfBox = widthOfBox;
            HeightOfBox = heightOfBox;
        }
        /// <summary>
        /// To calcualate the surface area of the Box 
        /// </summary>
        /// <returns>double </returns>
        public override double CalculateArea() => ((2.0 * heightOfBox * widthOfBox) + (2.0 * heightOfBox * lengthOfBox) + (2.0 * widthOfBox * lengthOfBox));

        /// <summary>
        /// To calcualate the volume of the Box
        /// </summary>
        /// <returns> double</returns>
        public override double CalculateVolume() => (heightOfBox * widthOfBox * lengthOfBox);
        /// <summary>
        /// To express all variables,  the surface of the box and the volume of the box
        /// </summary>
        /// <returns>Type, heightOfBox, widthOfBox, lengthOfBox, CalculateArea(), CalculateVolume() </returns>
        public override string ToString()
        {
            return $"[TYPE = {Type}] , Height : {heightOfBox} , Width : {widthOfBox} , Length : {lengthOfBox} , " +
                $"Surface Area : {CalculateArea()} , Volume : {CalculateVolume()}";
        }
    }
}
