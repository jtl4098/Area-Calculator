using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Program : Triangle
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Triangle
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    public class Triangle : TwoDimensional
    {
        private double baseOfTriangle; // Backing variable
        private double heightOfTriangle; // Backing variable
        public double BaseOfTriangle
        {
            get
            {
                return baseOfTriangle; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else                   
                    baseOfTriangle = value;

            }
        }
        public double HeightOfTriangle
        {
            get
            {
                return heightOfTriangle; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");
                else
                    heightOfTriangle = value;
            }
                
        }

        /// <summary>
        /// Set the type into Triangle
        /// To create Triangle object with base and height
        /// </summary>
        /// <param name="baseOfTriangle"></param>
        /// <param name="heightOfTriangle"></param>
        public Triangle(double baseOfTriangle, double heightOfTriangle)
 
        {
            Type = "Triangle";
            BaseOfTriangle = baseOfTriangle;
            HeightOfTriangle = heightOfTriangle;
        }


        /// <summary>
        /// To calcualate the area of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateArea() => (0.5 * baseOfTriangle * heightOfTriangle);


        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type,baseOfTriangle, heightOfTriangle, CalculateArea() </returns>
        public override string ToString()
        {
            return $"[TYPE = {Type}] , Base : {baseOfTriangle} , Height : {heightOfTriangle} , Area : {CalculateArea()}";
        }

    }
}



    

