namespace Practical_Tasks_No2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task1();

            System.Console.WriteLine();

            Task2();

            System.Console.WriteLine();

            Task3();

            System.Console.WriteLine();

            Task4();

            System.Console.ReadKey();
        }

        private static void Task1()
        {
            Task_1.Figure r = new Task_1.Rectangle();
            r.Draw();

            Task_1.Figure s = new Task_1.Square();
            s.Draw();
        }

        private static void Task2()
        {
            Task_2.Figure r = new Task_2.Rectangle(1, 1);
            r.Draw();

            Task_2.Figure s = new Task_2.Square(2, 2);
            s.Draw();
        }

        private static void Task3()
        {
            Task_3.Figure r = new Task_3.Rectangle(1, 1);
            r.Draw();

            Task_3.Figure s = new Task_3.Square(2, 2);
            s.Draw();

            Task_3.Figure f = new Task_3.Figure(3, 3);
            r.Draw();
        }

        private static void Task4()
        {
            Task_4.IDrawable s = new Task_4.Square(1, 2);
            Task_4.IDrawable r = new Task_4.Rectangle(1, 2);

            s.DrawAll(r, r, r, s, r);
        }
    }
}
