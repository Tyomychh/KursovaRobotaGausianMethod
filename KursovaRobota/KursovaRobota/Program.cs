using System;

namespace KursovaRobota
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo;
            Console.WriteLine("Введiть розмiрнiсть матрицi:");
            bool isNumeric = int.TryParse(Console.ReadLine(), out chislo);

            AuditClass perevirkaprog = new AuditClass(chislo, isNumeric);
            perevirkaprog.Poverka();
            perevirkaprog.VvodMatrici();
            perevirkaprog.VvodVektora();
            perevirkaprog.VivodVsego();


            Console.ReadLine();
        }
    }
}