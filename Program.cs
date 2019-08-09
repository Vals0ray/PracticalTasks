using System;

namespace Practical_Tasks_No1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithRectangle();

            WorkWithCircle();

            WorkWithComplexNumbers();
            
            Console.ReadKey();
        }

        public static void WorkWithRectangle()
        {
            double topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y;
            double perimeter, square;

            try
            {
                Console.Write("Enter top left coordinate x: ");
                topLeftCorner_x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter top left coordinate y: ");
                topLeftCorner_y = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter bottom right coordinate x: ");
                bottomRightCorner_x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter bottom right coordinate y: ");
                bottomRightCorner_y = Convert.ToDouble(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            // Finding perimeter and square
            perimeter = Rectangle.Perimeter(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            square = Rectangle.Square(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);

            Console.WriteLine($"Perimetr equals {perimeter}");
            Console.WriteLine($"Square equals {square}\n");
        }

        public static void WorkWithCircle()
        {
            double radius;
            double circuit, circleSquare;

            try
            {
                Console.Write("Enter the radius of the circle: ");
                radius = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            // Finding circuit and circleSquare
            circuit = Circle.Circuit(radius);
            circleSquare = Circle.CircleSquare(radius);

            Console.WriteLine($"Circuit equals {circuit}");
            Console.WriteLine($"CircleSquare equals {circleSquare}\n");
        }

        public static void WorkWithComplexNumbers()
        {
            double real, imaginary;
            ComplexNumber c1, c2 = new ComplexNumber();

            try
            {
                Console.Write("Enter the real part of the first complex number: ");
                real = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary part of the first complex number: ");
                imaginary = Convert.ToDouble(Console.ReadLine());
                c1 = new ComplexNumber(real, imaginary);

                Console.Write("Enter the real part of the second complex number: ");
                real = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary part of the second complex number: ");
                imaginary = Convert.ToDouble(Console.ReadLine());
                c2 = new ComplexNumber(real, imaginary);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            
            // Multiplication
            ComplexNumber c3 = c1 * c2;
            Console.WriteLine("Multiplication result: ");
            Console.WriteLine($"c3 = {c3.R} + i * {c3.I}");

            // Division
            ComplexNumber c4 = c1 / c2;
            Console.WriteLine("Division result: ");
            Console.WriteLine($"c4 = {c4.R} + i * {c4.I}");
        }
    }
}
