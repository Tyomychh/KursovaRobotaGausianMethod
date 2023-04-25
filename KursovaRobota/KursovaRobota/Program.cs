using System;

namespace KursovaRobota
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введiть розмiрнiсть матрицi:");
            bool isNumeric = int.TryParse(Console.ReadLine(), out number);

            AuditClass perevirkaprog = new AuditClass(number, isNumeric);
            perevirkaprog.DimensionArrayAudit();
            perevirkaprog.MatrixFilling();
            perevirkaprog.VectorFilling();
            perevirkaprog.CalculationAndOutput();


            Console.ReadLine();
        }
    }
}