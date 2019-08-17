namespace Practical_Tasks_No2
{
    public class Rectangle_Task2 : Figure_Task2
    {
        public Rectangle_Task2(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this.GetType());
        }
    }
}
