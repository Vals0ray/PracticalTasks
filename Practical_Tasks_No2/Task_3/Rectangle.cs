namespace Practical_Tasks_No2.Task_3
{
    internal class Rectangle : Figure
    {
        public Rectangle(int X, int Y)
            : base(X, Y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this.GetType());
        }
    }
}
