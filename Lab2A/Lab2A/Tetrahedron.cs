using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Program : Tetrahedron
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the class of Tetrahedron
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    public class Tetrahedron : ThreeDimensional
    {
        private double lengthOfTetrahedron; // Backing variable
        public double LengthOfTetrahedron
        {
            get
            {
                return lengthOfTetrahedron; // return baking variable
            }
            set // set the backing variable with the data validation.
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be < 100 or > 0");

                else
                    lengthOfTetrahedron = value;

            }
        }

        /// <summary>
        /// Set the type into Tetrahedron
        /// To create Tetrahedron object with length
        /// </summary>
        /// <param name="lengthOfTetrahedron"></param>
        public Tetrahedron(double lengthOfTetrahedron)
        {
            Type = "TeTrahedron";
            LengthOfTetrahedron = lengthOfTetrahedron;
        }


        /// <summary>
        /// To calcualate the surface area of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateArea() => (Math.Sqrt(3) * lengthOfTetrahedron * lengthOfTetrahedron);



        /// <summary>
        /// To calculate the volume of this object
        /// </summary>
        /// <returns>double</returns>
        public override double CalculateVolume() => ((double)1 / (double)12 * Math.Sqrt(2) * lengthOfTetrahedron * lengthOfTetrahedron * lengthOfTetrahedron);

        /// <summary>
        /// To print out all variables and the area of this object.
        /// </summary>
        /// <returns>Type,lengthOfTetrahedron, CalculateArea(), CalculateVolume() </returns>
        public override string ToString()
        {
            return $"[TYPE = {Type}] , Length : {lengthOfTetrahedron} , Surface Area : {CalculateArea()} , Volume : {CalculateVolume()}";
        }
    }
}
