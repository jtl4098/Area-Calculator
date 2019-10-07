using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program : Cylinder
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Cylinder
/// 
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    public class Ellipse : TwoDimensional
    {
        private double lengthOfMajor; // Backing variable
        public double LengthOfMajor
        {
            get
            {
                return lengthOfMajor;  // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");
                else
                    lengthOfMajor = value;
            }
        }

        private double lengthOfMinor; // Backing variable
        public double LengthOfMinor
        {
            get
            {
                return lengthOfMinor;  // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");
                else
                    lengthOfMinor = value;
            }
        }

        /// <summary>
        /// Set the type into Ellipse
        /// To create Ellipse object with major length and minor length
        /// </summary>
        /// <param name="lengthOfMajor"></param>
        /// <param name="lengthOfMinor"></param>
        public Ellipse(double lengthOfMajor, double lengthOfMinor)
        {
            Type = "Ellipse";
            LengthOfMajor = lengthOfMajor;
            LengthOfMinor = lengthOfMinor;
            
        }

        /// <summary>
        /// To calcualate the area of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateArea() => (PI * lengthOfMajor * LengthOfMinor);


        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type, lengthOfMajor, lengthOfMinor, CalculateArea() </returns>
        public override string ToString()
        {
            return $"[TYPE = {Type}] , Semi-major axis length : {lengthOfMajor} , Semi-minor axis length : {LengthOfMinor} , Area : {CalculateArea()}";
        }
    }
}
