namespace Practical_Tasks_No2
{
    public class Rectangle_Task4 : Figure_Task4
    {
        public Rectangle_Task4(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this.GetType());
        }

        public override void DrawAll(params IDrawable_Task4[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }
}