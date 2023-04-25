using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRobota
{
    public class AuditClass
    {
        private int numInClass;
        private bool question;
        public double[,] coefficients;
        public double[] constants;
        public AuditClass(int n, bool q)
        {
            numInClass = n;
            question = q;
            coefficients = new double[numInClass, numInClass];
            constants = new double[numInClass];
        }

        // Перевірка на коректність введеної розмірності масиву
        public void DimensionArrayAudit()
        {
            while (!question)
            {
                Console.WriteLine("\nНекоректно введенi данi, спробуйте заново та введiть число\n");
                question = int.TryParse(Console.ReadLine(), out numInClass);
            }
        }

        // Введення та перевірка матриці на коректність введеного числа
        public void MatrixFilling()
        {
            coefficients = new double[numInClass, numInClass];
            for (int i = 0; i < numInClass; i++)
            {
                for (int j = 0; j < numInClass; j++)
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
        public void VectorFilling()
        {
            Console.WriteLine("Введiть вектор сталих значень:\n");
            constants = new double[numInClass];
            for (int i = 0; i < numInClass; i++)
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

        public void CalculationAndOutput()
        {
            Console.WriteLine();

            JordanGausClass solver = new JordanGausClass(coefficients, constants);
            solver.JordanGaussMethodSolution();
        }
    }
}
