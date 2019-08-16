namespace Practical_Tasks_No2.Task_2
{
    internal class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this);
        }
    }
}
