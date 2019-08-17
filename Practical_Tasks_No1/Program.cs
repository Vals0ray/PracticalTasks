namespace Practical_Tasks_No1
{
    using System;

    public class Program
    {
        #region properties
        public static double TopLeftCornerX { get; set; }

        public static double TopLeftCornerY { get; set; }

        public static double BottomRightCornerX { get; set; }

        public static double BottomRightCornerY { get; set; }

        public static double Perimeter { get; set; }

        public static double Square { get; set; }

        public static double Radius { get; set; }

        public static double Real { get; set; }

        public static double Imaginary { get; set; }
        #endregion

        private static void Main(string[] args)
        {
            while (!InPut())
            {
            }

            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

            Console.ReadKey();
        }

        private static bool InPut()
        {
            try
            {
                Console.WriteLine("--- Work with rectangles ---");
                Console.Write("Enter top left coordinate x: ");
                TopLeftCornerX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter top left coordinate y: ");
                TopLeftCornerY = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter bottom right coordinate x: ");
                BottomRightCornerX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter bottom right coordinate y: ");
                BottomRightCornerY = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n--- Work with circles ---");
                Console.Write("Enter the radius of the circle: ");
                Radius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n--- Work with Complex Numbers ---");
                Console.Write("Enter the real part of the first complex number: ");
                Real = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary part of the first complex number: ");
                Imaginary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the real part of the second complex number: ");
                Real = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary part of the second complex number: ");
                Imaginary = Convert.ToDouble(Console.ReadLine());
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
                return false;
            }
        }

        private static void Task1()
        {
            // Finding perimeter and square
            Console.WriteLine("\n--- Task1 Rectangle ---");

            Rectangle_Task1 rectangle = new Rectangle_Task1(TopLeftCornerX, TopLeftCornerY, BottomRightCornerX, BottomRightCornerY);
            Console.WriteLine($"Perimetr equals {rectangle.Perimeter()}");
            Console.WriteLine($"Perimetr equals {rectangle.Square()}");
        }

        private static void Task2()
        {
            Console.WriteLine("\n--- Task2 Rectangle ---");

            Rectangle_Task2 rectangle = new Rectangle_Task2(TopLeftCornerX, TopLeftCornerY, BottomRightCornerX, BottomRightCornerY);
            Console.WriteLine($"Perimetr equals {rectangle.Perimetr}");
            Console.WriteLine($"Perimetr equals {rectangle.Square}");
        }

        private static void Task3()
        {
            // Finding circuit and circleSquare
            Console.WriteLine("\n--- Task3 Circle ---");

            Circle_Task3 circle = new Circle_Task3();
            Console.WriteLine($"Circuit equals {circle.Circuit(Radius)}");
            Console.WriteLine($"CircleSquare equals {circle.CircleSquare(Radius)}\n");
        }

        private static void Task4()
        {
            Console.WriteLine("--- Task4 Rectangle ---");

            Perimeter = Rectangle_Task4.Perimeter(TopLeftCornerX, TopLeftCornerY, BottomRightCornerX, BottomRightCornerY);
            Square = Rectangle_Task4.Square(TopLeftCornerX, TopLeftCornerY, BottomRightCornerX, BottomRightCornerY);
            Console.WriteLine($"Perimetr equals {Perimeter}");
            Console.WriteLine($"Square equals {Square}\n");

            Console.WriteLine("--- Task4 Circle ---");

            Console.WriteLine($"Circuit equals {Circle_Task4.Circuit(Radius)}");
            Console.WriteLine($"CircleSquare equals {Circle_Task4.CircleSquare(Radius)}\n");
        }

        private static void Task5()
        {
            Console.WriteLine("--- Task5 Complex Number ---");

            ComplexNumber c1, c2 = new ComplexNumber();
            c1 = new ComplexNumber(Real, Imaginary);
            c2 = new ComplexNumber(Real, Imaginary);

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
