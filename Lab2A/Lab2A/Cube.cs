using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Program : Cube
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Cube
/// 
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    public class Cube : ThreeDimensional
    {
        private double lengthOfCube; // Backing variable
        public double LengthOfCube
        {
            get
            {
                return lengthOfCube; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else
                    lengthOfCube = value;

            }
        }
        /// <summary>
        /// set the type into Cube
        /// To create Cube object with length
        /// </summary>
        /// <param name="lengthOfCube"></param>
       
        public Cube(double lengthOfCube)
        {
            Type = "Cube";
            LengthOfCube = lengthOfCube;
        }

        /// <summary>
        /// To calcualate the surface area of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateArea() => (6 * lengthOfCube * lengthOfCube);

        /// <summary>
        /// To calculate the volume of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateVolume() => (lengthOfCube * lengthOfCube * lengthOfCube);

        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type, length, CalculateArea(), CalculateVolume() </returns>
        public override string ToString()
        {
            return $"[TYPE = {Type}] , Length : {lengthOfCube} , Surface Area : {CalculateArea()} , Volume : {CalculateVolume()}";
        }

    }
}
