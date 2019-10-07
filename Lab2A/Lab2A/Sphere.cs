using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program : Sphere
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Sphere
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    public class Sphere : ThreeDimensional
    {
        private double radiusOfSphere; // Backing variable
        public double RadiusOfSphere
        {
            get
            {
                return radiusOfSphere; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");
                else
                    radiusOfSphere = value;
            }
        }
        /// <summary>
        /// Set the type into Sphere
        /// To create Sphere object with radius
        /// </summary>
        /// <param name="radiusOfSphere"></param>
        public Sphere(double radiusOfSphere)
        {
            Type = "Sphere";
            RadiusOfSphere = radiusOfSphere;
        }

        /// <summary>
        /// To calcualate the surface area of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateArea() => ((double)4 * PI * radiusOfSphere * radiusOfSphere);

        /// <summary>
        /// To calculate the volume of this object
        /// </summary>
        /// <returns>double</returns>

        public override double CalculateVolume() => ((double)(4 / 3) * PI * radiusOfSphere * radiusOfSphere * radiusOfSphere);

        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type,radiusOfSphere , CalculateArea(), CalculateVolume() </returns>
        public override string ToString()
        {
            return $"[TYPE = {Type}] , Radius : {radiusOfSphere} , Surface area : {CalculateArea()} , Volume : {CalculateVolume()}";
        }

    }
}
