namespace Practical_Tasks_No2.Task_4
{
    internal abstract class Figure : IDrawable
    {
        public int X { get; }

        public int Y { get; }

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw();

        public abstract void DrawAll(params IDrawable[] array);
    }
}
