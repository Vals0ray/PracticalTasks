namespace Practical_Tasks_No2.Task_2
{
    internal class Rectangle : Figure
    {
        public Rectangle(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this.GetType());
        }
    }
}
