namespace Practical_Tasks_No1
{
    class Rectangle_Task4
    {
        private static double Length_A = 0, Length_B = 0;

        private static void FindLength(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            // Finding the length of the side A = | x1 - x2 |
            Length_A = topLeftCorner_x - bottomRightCorner_x;
            if (Length_A < 0)
            {
                Length_A = Length_A * (-1);
            }

            // Finding the length of the side B = | y1 - y2 |
            Length_B = topLeftCorner_y - bottomRightCorner_y;
            if (Length_B < 0)
            {
                Length_B = Length_B * (-1);
            }
        }

        public static double Perimeter(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            FindLength(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            return 2 * (Length_A + Length_B);
        }

        public static double Square(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            FindLength(topLeftCorner_x, topLeftCorner_y, bottomRightCorner_x, bottomRightCorner_y);
            return Length_A * Length_B;
        }
    }
}
