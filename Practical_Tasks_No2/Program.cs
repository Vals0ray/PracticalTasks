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
            Figure_Task1 r = new Rectangle_Task1();
            r.Draw();

            Figure_Task1 s = new Square_Task1();
            s.Draw();
        }

        private static void Task2()
        {
            Figure_Task2 r = new Rectangle_Task2(1, 1);
            r.Draw();

            Figure_Task2 s = new Square_Task2(2, 2);
            s.Draw();
        }

        private static void Task3()
        {
            Figure_Task3 r = new Rectangle_Task3(1, 1);
            r.Draw();

            Figure_Task3 s = new Square_Task3(2, 2);
            s.Draw();

            Figure_Task3 f = new Figure_Task3(3, 3);
            r.Draw();
        }

        private static void Task4()
        {
            IDrawable_Task4 s = new Square_Task4(1, 2);
            IDrawable_Task4 r = new Rectangle_Task4(1, 2);

            s.DrawAll(r, r, r, s, r);
        }
    }
}