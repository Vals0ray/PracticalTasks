namespace Practical_Tasks_No2
{
    public class Square_Task3 : Figure_Task3
    {
        public Square_Task3(int X, int Y)
            : base(X, Y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this);
        }
    }
}
