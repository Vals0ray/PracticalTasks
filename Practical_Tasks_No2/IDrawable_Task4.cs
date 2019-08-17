namespace Practical_Tasks_No2
{
    public interface IDrawable_Task4
    {
        void Draw();

        void DrawAll(params IDrawable_Task4[] array);
    }
}