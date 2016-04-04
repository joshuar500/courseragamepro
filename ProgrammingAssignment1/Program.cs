using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Say hello to the user
            Console.WriteLine("Welcome!");

            // Ask the user for the first value
            Console.WriteLine("Enter the 1st value for x -- (x1, y1): ");
            float point1X = float.Parse(Console.ReadLine());

            // Ask the user for the second value
            Console.WriteLine("Enter the 1st value for y -- (" + point1X + ", y1): ");
            float point1Y = float.Parse(Console.ReadLine());

            // print both values for (x1, y1)
            Console.WriteLine("Values for 1st set are (" + point1X + ", " + point1Y + ")");

            // add some blank lines because pretty
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Enter the 2nd value for x -- (x2, y2): ");
            float point2X = float.Parse(Console.ReadLine());

            // Ask the user for the second value
            Console.WriteLine("Enter the 2nd value for y -- (" + point2X + ", y2): ");
            float point2Y = float.Parse(Console.ReadLine());

            // print both values for (x2, y2)
            Console.WriteLine("Values for 1st set are (" + point2X + ", " + point2Y + ")");

            // add some blank lines because pretty
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            // Calculate the horizontal distance between the coordinate points
            // of both the x and y by subtracting the 1st from 2nd of each value
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // use the pythagorean theorem to measure the diagonal
            // position of the two coordinate points (x1, y1) & (x2, y2)
            // use the delta values for this
            // also see this answer: http://stackoverflow.com/questions/3819396/how-can-i-measure-diagonal-distance-points
            // also notice that Math returns a double (as opposed to a float)
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            // Get the angle of the two points and convert radians to degrees
            // answer found here http://www.vcskicks.com/csharp_net_angles.php
            double angle = Math.Atan2(deltaY, deltaX) * (180.0 / Math.PI);

            // print everything out
            Console.WriteLine("The horizontal distance between two points is: " + deltaX);
            Console.WriteLine("The vertical distance between two points is: " + deltaY);
            // display value to only 3 decimal points using the ToString formatter
            Console.WriteLine("The diagonal distance between two points is: " + distance.ToString("#.###"));
            Console.WriteLine("The angle for the coordinates is: " + angle.ToString("#.###"));

            // add some space between lines for pretty and keep the console open.
            // if this is removed, then window would close after angle is printed
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
