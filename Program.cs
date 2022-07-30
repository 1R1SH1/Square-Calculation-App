using MathLibrary;
using System;

namespace SquareCalculationApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nКакую команду Вы хотите выполнить?:");
            Console.WriteLine("\nКоманда 1. Метод вычисления площади круга. Нажмите 1:");
            Console.WriteLine("\nКоманда 2. Метод вычисления площади треугольника. Нажмите 2:");

            while (true)
            {
                int userinput = int.Parse(Console.ReadLine());
                int Program = userinput;

                switch (Program)
                {
                    case 1:
                        {
                            double A, B, C;
                            Console.WriteLine("Введите сторону A: ");
                            A = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Введите сторону B: ");
                            B = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Введите сторону C: ");
                            C = Convert.ToDouble(Console.ReadLine());

                            double S = Method.TriangleSquare(A, B, C);

                            Console.WriteLine("Площадь равна: {0}", S);
                            break;
                        }

                    case 2:
                        {
                            double R;
                            Console.WriteLine("Введите велечину Радиуса: R: ");
                            R = Convert.ToDouble(Console.ReadLine());

                            double S = Method.CircleSquare(R);

                            Console.WriteLine("Площадь равна: {0}", S);
                            break;
                        }
                }
            }
        }
    }
}
