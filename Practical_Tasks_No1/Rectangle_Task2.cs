namespace Practical_Tasks_No1
{
    public class Rectangle_Task2
    {
        private readonly double lengthA = 0;
        private readonly double lengthB = 0;

        public double Perimetr => 2 * (lengthA + lengthB);

        public double Square => lengthA * lengthB;

        public Rectangle_Task2(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
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
    }
}