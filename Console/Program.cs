namespace Console
{
    using System;
    using System.Collections.Generic;
    using HW1 = Practical_Tasks_No1;
    using HW2 = Practical_Tasks_No2;
    using HW3 = Practical_Tasks_No3;

    class Program
    {
        #region properties
        public static double TopLeftCornerX { get; set; }

        public static double TopLeftCornerY { get; set; }

        public static double BottomRightCornerX { get; set; }

        public static double BottomRightCornerY { get; set; }

        public static double Perimeter { get; set; }

        public static double Square { get; set; }

        public static double Radius { get; set; }

        public static double Real { get; set; }

        public static double Imaginary { get; set; }
        #endregion

        static void Main(string[] args)
        {
            while (!InPut())
            {
            }

            HomeWork1();

            HomeWork2();

            HomeWork3();

            Console.ReadKey();
        }

        private static bool InPut()
        {
            try
            {
                Console.WriteLine("--- Work with rectangles ---");
                Console.Write("Enter top left coordinate x: ");
                TopLeftCornerX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter top left coordinate y: ");
                TopLeftCornerY = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter bottom right coordinate x: ");
                BottomRightCornerX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter bottom right coordinate y: ");
                BottomRightCornerY = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n--- Work with circles ---");
                Console.Write("Enter the radius of the circle: ");
                Radius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n--- Work with Complex Numbers ---");
                Console.Write("Enter the real part of the first complex number: ");
                Real = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary part of the first complex number: ");
                Imaginary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the real part of the second complex number: ");
                Real = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary part of the second complex number: ");
                Imaginary = Convert.ToDouble(Console.ReadLine());
                return true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Incorrect input\n" + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect input\n" + ex.Message);
                return false;
            }
        }

        private static void HomeWork1()
        {
            Console.WriteLine("\n----- HomeWork 1 -----");

            /*
             Task 1
             */

            // Finding perimeter and square
            Console.WriteLine("\n--- Task1 Rectangle ---");

            HW1.Rectangle_Task1 rectangle1 = new HW1.Rectangle_Task1(TopLeftCornerX, TopLeftCornerY, BottomRightCornerX, BottomRightCornerY);
            Console.WriteLine($"Perimetr equals {rectangle1.Perimeter()}");
            Console.WriteLine($"Perimetr equals {rectangle1.Square()}");

            /*
             Task 2
             */

            Console.WriteLine("\n--- Task2 Rectangle ---");

            HW1.Rectangle_Task2 rectangle2 = new HW1.Rectangle_Task2(TopLeftCornerX, TopLeftCornerY, BottomRightCornerX, BottomRightCornerY);
            Console.WriteLine($"Perimetr equals {rectangle2.Perimetr}");
            Console.WriteLine($"Perimetr equals {rectangle2.Square}");

            /*
            Task 3
            */

            // Finding circuit and circleSquare
            Console.WriteLine("\n--- Task3 Circle ---");

            HW1.Circle_Task3 circle = new HW1.Circle_Task3();
            Console.WriteLine($"Circuit equals {circle.Circuit(Radius)}");
            Console.WriteLine($"CircleSquare equals {circle.CircleSquare(Radius)}\n");

            /*
             Task 4
             */

            Console.WriteLine("--- Task4 Rectangle ---");

            Perimeter = HW1.Rectangle_Task4.Perimeter(TopLeftCornerX, TopLeftCornerY, BottomRightCornerX, BottomRightCornerY);
            Square = HW1.Rectangle_Task4.Square(TopLeftCornerX, TopLeftCornerY, BottomRightCornerX, BottomRightCornerY);
            Console.WriteLine($"Perimetr equals {Perimeter}");
            Console.WriteLine($"Square equals {Square}\n");

            Console.WriteLine("--- Task4 Circle ---");

            Console.WriteLine($"Circuit equals {HW1.Circle_Task4.Circuit(Radius)}");
            Console.WriteLine($"CircleSquare equals {HW1.Circle_Task4.CircleSquare(Radius)}\n");

            /*
            Task 5
            */

            Console.WriteLine("--- Task5 Complex Number ---");

            HW1.ComplexNumber c1, c2 = new HW1.ComplexNumber();
            c1 = new HW1.ComplexNumber(Real, Imaginary);
            c2 = new HW1.ComplexNumber(Real, Imaginary);

            // Multiplication
            HW1.ComplexNumber c3 = c1 * c2;
            Console.WriteLine("Multiplication result: ");
            Console.WriteLine($"c3 = {c3.R} + i * {c3.I}");

            // Division
            HW1.ComplexNumber c4 = c1 / c2;
            Console.WriteLine("Division result: ");
            Console.WriteLine($"c4 = {c4.R} + i * {c4.I}");
        }

        private static void HomeWork2()
        {
            Console.WriteLine("\n----- HomeWork 2 -----");

            /*
             Task 1
             */

            Console.WriteLine("\n--- Task1 ---");

            HW2.Figure_Task1 r = new HW2.Rectangle_Task1();
            r.Draw();

            HW2.Figure_Task1 s = new HW2.Square_Task1();
            s.Draw();

            /*
            Task 2
            */

            Console.WriteLine("\n--- Task2 ---");

            HW2.Figure_Task2 r2 = new HW2.Rectangle_Task2(1, 1);
            r2.Draw();

            HW2.Figure_Task2 s2 = new HW2.Square_Task2(2, 2);
            s2.Draw();

            /*
             Task 3
             */

            Console.WriteLine("\n--- Task3 ---");

            HW2.Figure_Task3 r3 = new HW2.Rectangle_Task3(1, 1);
            r3.Draw();

            HW2.Figure_Task3 s3 = new HW2.Square_Task3(2, 2);
            s3.Draw();

            HW2.Figure_Task3 f3 = new HW2.Figure_Task3(3, 3);
            f3.Draw();

            /*
            Task 4
            */

            Console.WriteLine("\n--- Task4 ---");

            HW2.IDrawable_Task4 s4 = new HW2.Square_Task4(1, 2);
            HW2.IDrawable_Task4 r4 = new HW2.Rectangle_Task4(1, 2);

            s4.DrawAll(r4, r4, r4, s4, r4);
        }

        private static void HomeWork3()
        {
            /*
             Task 1
             */
            Console.WriteLine("--- Task 1 ---");
            HW3.Task1 task1 = new HW3.Task1();
            task1.CreateRandomList();
            task1.DrawList();

            /*
             Task 2
             */
            Console.WriteLine("\n--- Task 2 ---");
            List<HW3.Person> people = new List<HW3.Person>();

            HW3.Task2 task2 = new HW3.Task2();
            List<string> phones;
            string name;
            byte age = 0, count = 0;
            task2.CreateRandomList();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nAdding new person number {i + 1}");
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Age: ");

                if (!byte.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Error!\nIncorrect input");
                    break;
                }

                Console.Write("How many phones you need to enter?: ");

                if (!byte.TryParse(Console.ReadLine(), out count))
                {
                    Console.WriteLine("Error!\nIncorrect input");
                    break;
                }

                phones = new List<string>();

                for (int j = 0; j < count; j++)
                {
                    Console.Write($"Enter phone number {j + 1}: ");
                    phones.Add(Console.ReadLine());
                }

                people.Add(new HW3.Person() { Name = name, Age = age, PhoneNumbers = phones });
            }

            task2.AddNewPeople(people);
            task2.DrawList();

            /*
             Task 3
             */
            HW3.Task3 task3 = new HW3.Task3();
            Console.ReadKey();
            Console.Clear();
            List<string> strings = new List<string>();
            byte input = 0;

            while (true)
            {
                Console.WriteLine("\n--- Task 3 ---\nHello, what are you want to do?\n");

                Console.WriteLine("[1] Create random string list");
                Console.WriteLine("[2] Delete Repetitions in the list");
                Console.WriteLine("[3] Delete rows that begin on Z");
                Console.WriteLine("[4] Sorte list (z - a)");
                Console.WriteLine("[5] Display page of the list");
                Console.WriteLine("[6] Display all list\n");

                Console.Write("Enter number from 1 to 6 -> ");
                try
                {
                    input = Convert.ToByte(Console.ReadLine());
                }
                catch (OverflowException OverFlowExp)
                {
                    Console.WriteLine($"Error!\nIncorrect input\n {OverFlowExp.Message}\nPress any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (FormatException formExp)
                {
                    Console.WriteLine($"Error!\nIncorrect input\n{formExp.Message}");
                    Console.WriteLine($"Program finished");
                    Console.ReadKey();
                    break;
                }

                if (strings.Count == 0 && input != 1)
                {
                    Console.WriteLine("\nError!\nFirst, create a new list\nPress any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (input)
                {
                    case 1:
                        Console.WriteLine("\nCreated new random string list");
                        strings = task3.GetRandomListGeneration();
                        break;
                    case 2:
                        Console.WriteLine("\nDeleted Repetitions in the list");
                        strings = task3.DeleteRepetitionsInTheList(strings);
                        break;
                    case 3:
                        Console.WriteLine("\nDeleted rows that begin on Z");
                        strings = task3.DeleteRowsThatBeginOnZ(strings);
                        break;
                    case 4:
                        Console.WriteLine("\nSorted list (z - a)");
                        strings = task3.SortList(strings);
                        break;
                    case 5:
                        Console.Write("Enter page of list -> ");
                        byte page = Convert.ToByte(Console.ReadLine());
                        task3.DisplayPage(page, strings);
                        break;
                    case 6:
                        task3.DisplayAllList(strings);
                        break;
                    default:
                        Console.WriteLine("Error!\nEnter number from 1 to 6");
                        break;
                }

                Console.WriteLine("\nPress any button to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
