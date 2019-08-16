namespace Practical_Tasks_No2.Task_4
{
    internal class Square : Figure, IDrawable
    {
        public Square(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this.GetType());
        }

        public override void DrawAll(params IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }
}
