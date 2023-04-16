using System;

namespace KursovaRobota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiрнiсть матрицi:");
            int n;
            bool isNumeric = int.TryParse(Console.ReadLine(), out n);

            if (!isNumeric)
            {
                Console.WriteLine("\nНекоректно введенi данi, спробуйте заново та введiть число\n");
                return;
            }

            if (n + 1 > 11 || n < 3)
            {
                Console.WriteLine("\nСпробуйте заново, та введiть нормальну розмiрнiсть, вона має бути не бiльше 11 та не менше 3\n");
                return;
            }

            double[,] coefficients = new double[n, n];

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введiть значення елемента Рядок[{i}],Стовбець[{j}]: ");
                    string inp = Console.ReadLine();
                    if (double.TryParse(inp, out double value))
                    {
                        coefficients[i, j] = value;
                    }
                    else
                    {
                        Console.WriteLine("\nНекоректно введенi даннi. Будь ласка, введiть число\n");
                        j--;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Введiть вектор сталих значень:\n");
            double[] constants = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} Стале значення: ");
                string inp = Console.ReadLine();
                if (double.TryParse(inp, out double value))
                {
                    constants[i] = value;
                }
                else
                {
                    Console.WriteLine("\nНекоректно введенi даннi. Будь ласка, введiть число\n");
                    i--;
                }
            }

            Console.WriteLine();

            JordanGausClass solver = new JordanGausClass(coefficients, constants);
            solver.JordanGaussMethodSolution();

            Console.ReadLine();
        }
    }
}