namespace Practical_Tasks_No1.Task3
{
    internal class Circle
    {
        private const double PI = 3.1415;

        public double Circuit(double radius)
        {
            return 2 * PI * radius;
        }

        public double CircleSquare(double radius)
        {
            return PI * radius * radius;
        }
    }
}
