namespace Practical_Tasks_No2
{
    public abstract class Figure_Task2
    {
        public int X { get; }

        public int Y { get; }

        public Figure_Task2(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void Draw();
    }
}
