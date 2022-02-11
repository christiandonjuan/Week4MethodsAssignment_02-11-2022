using System;

namespace Week_4_Assignment
{
    class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            random = new Random();
            int min = 1; //set minimum rectangle measurement
            int max = 10; //set maximum rectangle measurement
            int randomLength = 0; //length to use in MakeRectangle method
            int randomWidth = 0; //width to use in MakeRectangle method

            MakeRectangle(min, max, out randomLength, out randomWidth);
            Rectangle rectangle1 = new Rectangle(randomLength, randomWidth); //create rectangle object using randomized values

            //Output
            Console.WriteLine("Length: " + rectangle1.Length);
            Console.WriteLine("Width: " + rectangle1.Width);
            Console.WriteLine("Area: " + Utility.GetArea(rectangle1.Length, rectangle1.Width)); //get objects variables to use as parameters in GetArea method
            Console.WriteLine("Perimeter: " + Utility.GetPerimeter(rectangle1.Length, rectangle1.Width)); //get objects variables to use as parameters in GetPerimeter method
        }
        static void MakeRectangle(int min, int max, out int l, out int w) //Method to create rectangle measurements
        {
            l = random.Next(min, max);
            w = random.Next(min, max);
        }
    }

    public class Rectangle //Class holds objects length and width
    {
        private int length;
        private int width;

        public Rectangle() //Default constructor
        {
            length = 0;
            width = 0;
        }
        public Rectangle(int l, int w) //Overloaded constructor
        {
            length = l;
            width = w;
        }

        public int Length //Length accessor
        {
            get => length;
            set => length = value;
        }
        public int Width //Width accessor
        {
            get => width;  
            set => width = value;
        }
    }

    public class Utility //Class holds area and perimeter methods
    {
        public static int GetArea(int l, int w) 
        {
            return (l * w);
        }
        public static int GetPerimeter(int l, int w)
        {
            return (2 * (l + w));
        }
    }
}