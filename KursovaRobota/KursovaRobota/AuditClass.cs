using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRobota
{
    public class AuditClass
    {
        private int k;
        private bool question;
        public double[,] coefficients;
        public double[] constants;
        public AuditClass(int n, bool q)
        {
            k = n;
            question = q;
            coefficients = new double[k, k];
            constants = new double[k];
        }

        // Перевірка на коректність введеного числа
        public void Poverka()
        {
            while (!question)
            {
                Console.WriteLine("\nНекоректно введенi данi, спробуйте заново та введiть число\n");
                question = int.TryParse(Console.ReadLine(), out k);
            }
        }

        // Введення та перевірка матриці на коректність введеного числа
        public void VvodMatrici()
        {
            coefficients = new double[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
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
        }

        // Введення та перевірка вектора на коректність введеного числа
        public void VvodVektora()
        {
            Console.WriteLine("Введiть вектор сталих значень:\n");
            constants = new double[k];
            for (int i = 0; i < k; i++)
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
        }

        public void VivodVsego()
        {
            Console.WriteLine();

            JordanGausClass solver = new JordanGausClass(coefficients, constants);
            solver.JordanGaussMethodSolution();
        }
    }
}
