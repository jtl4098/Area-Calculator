using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{// same as posted with changes
 // o REMOVE SetData - prompt the user and call appropropriate constructor that will accept all appropirtae arguments
 // o REMOVE Override of ToString - Not used here
 // o VALIDATE derived class data in the Concrete classes

    public abstract class Shape
    {
        public string Type { get; protected set; } //The type of shape
        public static int Count { get; private set; } //
        protected const double PI = 3.141592653589793; //Constant value for pi

        //All this constructor does is increment the number of Shape instances
        public Shape()
        {
            Shape.Count++;
        }

        public abstract double CalculateArea(); //Calculate the Shape's area (surface area if 3-d)
        public abstract double CalculateVolume(); //Calculate the Shape's volume (if 3-d)

        //Retrieves the current number of Shape instances
    }
}
