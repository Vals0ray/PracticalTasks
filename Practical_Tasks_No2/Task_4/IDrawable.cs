namespace Practical_Tasks_No2.Task_4
{
    internal interface IDrawable
    {
        void Draw();

        void DrawAll(params IDrawable[] array);
    }
}