using System;

class Program
{
    static void Main()
    {
        double[,] mat = { { 1, 2 }, { 3, 4 } };
        double angle = Math.PI / 4;

        double[,] result = MatrixMath.Rotate2D(mat, angle);

        for (int i = 0; i < result.GetLength(0); i++)
            Console.WriteLine($"{result[i,0]}, {result[i,1]}");
    }
}
