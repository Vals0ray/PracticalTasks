namespace Practical_Tasks_No2
{
    public abstract class Figure_Task4 : IDrawable_Task4
    {
        public int X { get; }

        public int Y { get; }

        public Figure_Task4(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw();

        public abstract void DrawAll(params IDrawable_Task4[] array);
    }
}
