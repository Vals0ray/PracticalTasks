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

            Console.WriteLine("/n Task1 Rectangle");

            Rectangle_Task1 rectangle_Task1 = new Rectangle_Task1(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            Console.WriteLine($"Perimetr equals {rectangle_Task1.Perimeter()}");
            Console.WriteLine($"Perimetr equals {rectangle_Task1.Square()}");

            Console.WriteLine("/n Task2 Rectangle");

            Rectangle_Task2 rectangle_Task2 = new Rectangle_Task2(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            Console.WriteLine($"Perimetr equals {rectangle_Task2.Perimetr}");
            Console.WriteLine($"Perimetr equals {rectangle_Task2.Square}");

            Console.WriteLine("/n Task4 Rectangle");
            
            perimeter = Rectangle_Task4.Perimeter(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            square = Rectangle_Task4.Square(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            Console.WriteLine($"Perimetr equals {perimeter}");
            Console.WriteLine($"Square equals {square}\n");
        }

        public static void WorkWithCircle()
        {
            double radius;

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

            Console.WriteLine("/n Task3 Circle");

            Circle_Task3 circle_Task3 = new Circle_Task3();
            Console.WriteLine($"Circuit equals {circle_Task3.Circuit(radius)}");
            Console.WriteLine($"CircleSquare equals {circle_Task3.CircleSquare(radius)}\n");

            Console.WriteLine("/n Task4 Circle");

            Console.WriteLine($"Circuit equals {Circle_Task4.Circuit(radius)}");
            Console.WriteLine($"CircleSquare equals {Circle_Task4.CircleSquare(radius)}\n");
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
