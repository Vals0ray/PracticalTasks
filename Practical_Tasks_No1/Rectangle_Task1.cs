namespace Practical_Tasks_No1
{
    public class Rectangle_Task1
    {
        public double LengthA { get; set; } = 0;

        public double LengthB { get; set; } = 0;

        public Rectangle_Task1(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            // Finding the length of the side A = | x1 - x2 |
            this.LengthA = topLeftCorner_x - bottomRightCorner_x;
            if (LengthA < 0)
            {
                LengthA = LengthA * (-1);
            }

            // Finding the length of the side B = | y1 - y2 |
            LengthB = topLeftCorner_y - bottomRightCorner_y;
            if (LengthB < 0)
            {
                LengthB = LengthB * (-1);
            }
        }

        public double Perimeter()
        {
            return 2 * (LengthA + LengthB);
        }

        public double Square()
        {
            return LengthA * LengthB;
        }
    }
}
