namespace Practical_Tasks_No1
{
    class Rectangle_Task1
    {
        public double Length_A { get; set; } = 0;

        public double Length_B { get; set; } = 0;

        public Rectangle_Task1(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            // Finding the length of the side A = | x1 - x2 |
            Length_A = topLeftCorner_x - bottomRightCorner_x;
            if(Length_A < 0)
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

        public  double Perimeter()
        {
            return 2 * (Length_A + Length_B);
        }

        public  double Square()
        {
            return Length_A * Length_B;
        }
    }
}
