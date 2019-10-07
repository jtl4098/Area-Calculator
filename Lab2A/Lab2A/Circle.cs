using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program : Circle
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Circle
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    public class Circle : TwoDimensional
    {
        private double radiusOfCircle; // Backing variable
        public double RadiusOfCircle 
        {
            get
            {
                return radiusOfCircle; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");
                else
                    radiusOfCircle = value;
            }
        }
        /// <summary>
        /// set the type into Circle
        /// to create Circle object with radius
        /// </summary>
        /// <param name="radiusOfCircle"></param>
        public Circle(double radiusOfCircle)
        {
            Type = "Circle";
            RadiusOfCircle = radiusOfCircle;
        }
        /// <summary>
        /// To calcualate the area of this object
        /// </summary>
        /// <returns> double </returns>
        public override double CalculateArea() => (PI * radiusOfCircle * radiusOfCircle);

        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type, radiusOfCircle ,CalculateArea()</returns>

        public override string ToString()
        {
            return $"[TYPE = {Type}] , Radius : {radiusOfCircle} , Area : {CalculateArea()}";
        }
    }
}
