namespace Practical_Tasks_No1
{
    static class Rectangle
    {
        private static double a = 0, b = 0;

        public static double Perimeter(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            a = topLeftCorner_x - bottomRightCorner_x;
            a = a < 0 ? a * (-1) : a;

            b = topLeftCorner_y - bottomRightCorner_y;
            b = b < 0 ? b * (-1) : b;

            return 2 * (a + b);
        }

        public static double Square(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            a = topLeftCorner_x - bottomRightCorner_x;
            a = a < 0 ? a * (-1) : a;

            b = topLeftCorner_y - bottomRightCorner_y;
            b = b < 0 ? b * (-1) : b;

            return a * b;
        }
    }
}
