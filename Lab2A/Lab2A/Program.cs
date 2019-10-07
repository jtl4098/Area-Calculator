using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Program : program
/// @author : Taekyung Kil
/// Date : 04/Oct/2019
/// 
/// Purpose : To set the view
/// 
/// I, Taekyung Kil, student number 000799798 , certify that all code submitted is my own work;
/// that I have not copied it from any other source. 
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace Lab2A
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Boolean running = true;  // To set boolean variable to finish the while loop
            string userinput; // To initiate string variable to get user's input

            List<Shape> shapeList = new List<Shape>(); // Create new List of Shape object
            try
            {
                while (running) // Keep going  until running variable is false
                {


                    Console.Write($"=============== [ MENU ] ===============\n" +
                                      "A - Rectangle        E - Ellipse     I - Triangle\n" +
                                      "B - Square           F - Circle      J - Tetrahedron\n" +
                                      "C - Box              G - Cylinder   \n" +
                                      "D - Cube             H - Sphere \n\n" +
                                      "0 - List All Shapes and Exit\n\n" +
                                      $"Enter your choice   \n");
                    Console.WriteLine($"                        [ {shapeList.Count} ] shapes entered so far");
                    string option = Console.ReadLine();

                    switch (option.ToLower())
                    {

                        case "a":
                            Console.WriteLine("Please Enter Length");
                            userinput = Console.ReadLine();
                            double userLengthOfRectangle = Convert.ToDouble(userinput); // To convert string into double  

                            Console.WriteLine("Please Enter Width");
                            userinput = Console.ReadLine();
                            double userHeightOfRectangle = Convert.ToDouble(userinput); // To convert string into double  

                            shapeList.Add(new Rectangle(userLengthOfRectangle, userHeightOfRectangle)); // Add new Rectangle object into shapeList
                            Console.Clear();
                            break;


                        case "b":
                            Console.WriteLine("Please Enter Length");
                            userinput = Console.ReadLine();
                            double userLengthOfSquare = Convert.ToDouble(userinput); // To convert string into double  
                            shapeList.Add(new Square(userLengthOfSquare)); // Add new Square object into shapeList
                            Console.Clear();
                            break;
                        case "c":
                            Console.WriteLine("Please Enter Length");
                            userinput = Console.ReadLine();
                            double userLengthOfBox = Convert.ToDouble(userinput); // To convert string into double  

                            Console.WriteLine("Please Enter Width");
                            userinput = Console.ReadLine();
                            double userWidthOfBox = Convert.ToDouble(userinput); // To convert string into double  

                            Console.WriteLine("Please Enter Height");
                            userinput = Console.ReadLine();
                            double userHeightOfBox = Convert.ToDouble(userinput); // To convert string into double  

                            shapeList.Add(new Box(userLengthOfBox, userWidthOfBox, userHeightOfBox)); // Add new Box object into shapeList
                            Console.Clear();
                            break;
                        case "d":
                            Console.WriteLine("Please Enter Length");
                            userinput = Console.ReadLine(); 
                            double userLengthOfCube = Convert.ToDouble(userinput); // To convert string into double  
                            shapeList.Add(new Cube(userLengthOfCube)); // Add new Cube object into shapeList
                            Console.Clear();
                            break;
                        case "e":
                            Console.WriteLine("Please Enter Semi-Major axis Length");
                            userinput = Console.ReadLine();
                            double userLengthOfMajorLength = Convert.ToDouble(userinput); // To convert string into double  

                            Console.WriteLine("Please Enter Semi-Minor axis Length");
                            userinput = Console.ReadLine();
                            double userLengthOfMinorLength = Convert.ToDouble(userinput); // To convert string into double  

                            shapeList.Add(new Ellipse(userLengthOfMajorLength, userLengthOfMinorLength)); // Add new Ellipse object into shapeList
                            Console.Clear();
                            break;
                        case "f":
                            Console.WriteLine("Please Enter a Radius");
                            userinput = Console.ReadLine();
                            double userRadius = Convert.ToDouble(userinput); // To convert string into double  

                            shapeList.Add(new Circle(userRadius));  // Add new Circle object into shapeList
                            Console.Clear();
                            break;

                        case "g":
                            Console.WriteLine("Please Enter Radius");
                            userinput = Console.ReadLine();
                            double userRadiusOfCylinder = Convert.ToDouble(userinput); // To convert string into double  

                            Console.WriteLine("Please Enter Height");
                            userinput = Console.ReadLine();
                            double userHeightOfCylinder = Convert.ToDouble(userinput); // To convert string into double  

                            shapeList.Add(new Cylinder(userRadiusOfCylinder, userHeightOfCylinder)); // Add new Cylinder object into shapeList
                            Console.Clear();
                            break;

                        case "h":
                            Console.WriteLine("Please Enter Radius");
                            userinput = Console.ReadLine();
                            double userRadius2 = Convert.ToInt32(userinput); // To convert string into double  

                            shapeList.Add(new Sphere(userRadius2));  // Add new Sphere object into shapeList
                            Console.Clear();
                            break;

                        case "i":
                            Console.WriteLine("Please Enter a Base");
                            userinput = Console.ReadLine();
                            double userBase = Convert.ToDouble(userinput); // To convert string into double  
                            Console.WriteLine("Please Enter a Height");

                            userinput = Console.ReadLine();
                            double userHeight = Convert.ToDouble(userinput); // To convert string into double  
                            shapeList.Add(new Triangle(userBase, userHeight)); // Add new Triangle object into shapeList
                            Console.Clear();
                            break;

                        case "j":
                            Console.WriteLine("Please Enter Length");
                            userinput = Console.ReadLine();
                            double userLengthOfTetragedron = Convert.ToInt32(userinput); // To convert string into double  
                            shapeList.Add(new Tetrahedron(userLengthOfTetragedron)); // Add new Tetrahedron object into shapeList
                            Console.Clear();
                            break;

                        case "0": // To print out each object of ToString method in the shapeList
                            for (int i = 0; i < shapeList.Count; i++)
                            {
                                Console.WriteLine(shapeList[i].ToString());
                            }
                            Console.WriteLine("Please type to Exit......");
                            Console.ReadLine();
                            running = false; // To finish the loop
                            break;
                        default: // if the user did not type, the error show up
                            Console.WriteLine("\nInvalid option - please re-enter, the range of option (a-h)\n");
                            break;

                    }


                }
            }catch (FormatException ex) // data validation for user's input
            {
                Console.WriteLine("\n Invalid Input - Please Re-enter \n", ex.Message);
            }

    
        }
    }
}
