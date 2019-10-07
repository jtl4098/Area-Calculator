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
    public class Cylinder : ThreeDimensional
    {
        private double radiusOfCylinder; // Backing variable
        public double RadiusOfCylinder
        {
            get
            {
                return radiusOfCylinder; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");
                else
                    radiusOfCylinder = value;
            }
        }
        private double heightOfCylinder; // Backing variable
        public double HeightOfCylinder
        {
            get
            {
                return heightOfCylinder; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");
                else
                    heightOfCylinder = value;
            }
        }

        /// <summary>
        /// Set the type into Cylinder
        /// To create Cylinder object with radius and height
        /// </summary>
        /// <param name="radiusOfCylinder"></param>
        /// <param name="heightOfCylinder"></param>
        public Cylinder(double radiusOfCylinder, double heightOfCylinder)
        {
            Type = "Cylinder";
            RadiusOfCylinder = radiusOfCylinder;
            HeightOfCylinder = heightOfCylinder;
        }

        /// <summary>
        /// To calcualate the surface area of this object
        /// </summary>
        /// <returns>double</returns>
        
        public override double CalculateArea() => (((double)2 * PI * radiusOfCylinder * radiusOfCylinder) + ((double)2 * PI * radiusOfCylinder * heightOfCylinder));

        /// <summary>
        /// To calculate the volume of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateVolume() => (PI * radiusOfCylinder * radiusOfCylinder * heightOfCylinder);


        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type,radiusOfCylinder, heightOfCylinder, CalculateArea(), CalculateVolume() </returns>
        public override string ToString()
        {
            return $"[TYPE = {Type}], Radius : {radiusOfCylinder} , Height : {heightOfCylinder} , Surface Area : {CalculateArea()} , Volume : {CalculateVolume()}";
        }

    }
}
