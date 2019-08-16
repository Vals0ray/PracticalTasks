namespace Practical_Tasks_No1.Task4
{
    internal static class Circle
    {
        private const double PI = 3.1415;

        public static double Circuit(double radius)
        {
            return 2 * PI * radius;
        }

        public static double CircleSquare(double radius)
        {
            return PI * radius * radius;
        }
    }
}
