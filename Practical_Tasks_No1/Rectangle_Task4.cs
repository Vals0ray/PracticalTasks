namespace Practical_Tasks_No1
{
    public static class Rectangle_Task4
    {
        private static double lengthA = 0;
        private static double lengthB = 0;

        private static void FindLength(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            // Finding the length of the side A = | x1 - x2 |
            lengthA = topLeftCorner_x - bottomRightCorner_x;
            if (lengthA < 0)
            {
                lengthA = lengthA * (-1);
            }

            // Finding the length of the side B = | y1 - y2 |
            lengthB = topLeftCorner_y - bottomRightCorner_y;
            if (lengthB < 0)
            {
                lengthB = lengthB * (-1);
            }
        }

        public static double Perimeter(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            FindLength(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            return 2 * (lengthA + lengthB);
        }

        public static double Square(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            FindLength(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            return lengthA * lengthB;
        }
    }
}