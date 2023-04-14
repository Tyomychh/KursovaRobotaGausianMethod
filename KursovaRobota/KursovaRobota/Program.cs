using System;

namespace KursovaRobota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiрнiсть матрицi:");
            int n = int.Parse(Console.ReadLine());

            if (n + 1 > 11 || n < 3)
            {
                Console.WriteLine("\nВведiть нормальну розмiрнiсть, вона має бути не бiльше 11та не менше 3\n");
                return;
            }

            double[,] coefficients = new double[n, n];

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введiть значення елемента Рядок[{i}],Стовбець[{j}]: ");
                    coefficients[i, j] = double.Parse(Console.ReadLine());
                    
                }
            }

            Console.WriteLine();

            Console.WriteLine("Введiть вектор сталих значень:\n");
            double[] constants = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} Стале значення: ");
                constants[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            JordanGausClass solver = new JordanGausClass(coefficients, constants);
            solver.JordanGauss();

            Console.ReadLine();
        }
    }
}