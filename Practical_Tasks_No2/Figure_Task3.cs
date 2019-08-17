namespace Practical_Tasks_No2
{
    public class Figure_Task3
    {
        public int X { get; }

        public int Y { get; }

        public Figure_Task3(int X, int Y)
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
