using System;

namespace kratos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Massiv = new int [4][];
            Random rnd = new Random();
            Massiv[0] = new int[1];
            Massiv[1] = new int[2];
            Massiv[2] = new int[1];
            Massiv[3] = new int[3];
            for (int i = 0; i < 1; i++)
            {
                Massiv[0][i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < 2; i++)
            {
                Massiv[1][i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < 1; i++)
            {
                Massiv[2][i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < 3; i++)
            {
                Massiv[3][i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < 1; i++)
            {
                Console.Write(Massiv[0][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write(Massiv[1][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                Console.Write(Massiv[2][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(Massiv[3][i] + " ");
            }
        }
    }
}
