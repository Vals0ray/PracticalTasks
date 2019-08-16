namespace Practical_Tasks_No2.Task_2
{
    internal abstract class Figure
    {
        public int X { get; }
        public int Y { get; }

        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void Draw();
    }
}
