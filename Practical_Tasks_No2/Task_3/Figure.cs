namespace Practical_Tasks_No2.Task_3
{
    internal class Figure
    {
        public int X { get; }
        public int Y { get; }

        public Figure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public virtual void Draw()
        {
            System.Console.WriteLine(this);
        }
    }
}
