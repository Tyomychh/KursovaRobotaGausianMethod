using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRobota
{
    public class JordanGausClass
    {
        private double[,] matrix;
        private double[] constants;

        public JordanGausClass(double[,] coefficients, double[] constants)
        {
            int n = constants.Length;
            matrix = new double[n, n];
            this.constants = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = coefficients[i, j];
                }
                this.constants[i] = constants[i];
            }
        }

        // Вирішення методом Жордана-Гауса
        public void JordanGaussMethodSolution()
        {
            int n = constants.Length;

            for (int k = 0; k < n; k++)
            {
                double div = matrix[k, k];
                for (int j = k; j < n; j++)
                {
                    matrix[k, j] /= div;
                }
                constants[k] /= div;

                for (int i = 0; i < n; i++)
                {
                    if (i != k)
                    {
                        double mult = matrix[i, k];
                        for (int j = k; j < n; j++)
                        {
                            matrix[i, j] -= mult * matrix[k, j];
                        }
                        constants[i] -= mult * constants[k];
                    }
                }
            }

            // Виводимо результати
            Console.WriteLine("Вирiшена система:\n");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x{i + 1} = {constants[i]}");
            }
        }
    }
}