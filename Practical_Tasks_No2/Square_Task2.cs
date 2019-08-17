namespace Practical_Tasks_No2
{
    public class Square_Task2 : Figure_Task2
    {
        public Square_Task2(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this);
        }
    }
}
