using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Program : TwoDimensional
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : There are two types of shapes which are Two dimensional , three dimensional
/// To set the class of TwoDimensional
/// 
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// abstract class for two dimensional shapes 
    /// two dimensional shape dose not have the volume. 
    /// </summary>
    public abstract class TwoDimensional : Shape
    {
        /// <summary>
        /// two dimensional shape can not be calculated the volume.
        /// </summary>
        /// <returns> 0 </returns>
        public override double CalculateVolume()
        {
            return 0;
        }
    }
}
