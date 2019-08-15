namespace Practical_Tasks_No1
{
    class Rectangle_Task2
    {
        private double length_A = 0, length_B = 0;

        public double Perimetr => 2 * (length_A + length_B);

        public double Square => length_A * length_B;

        public Rectangle_Task2(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            // Finding the length of the side A = | x1 - x2 |
            length_A = topLeftCorner_x - bottomRightCorner_x;
            if (length_A < 0)
            {
                length_A = length_A * (-1);
            }

            // Finding the length of the side B = | y1 - y2 |
            length_B = topLeftCorner_y - bottomRightCorner_y;
            if (length_B < 0)
            {
                length_B = length_B * (-1);
            }
        }
    }
}
