using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Validate: matrix must have 2 columns
        if (matrix == null || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        double[,] rotated = new double[rows, 2];

        double cosA = Math.Cos(angle);
        double sinA = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            // Apply rotation formulas
            rotated[i, 0] = Math.Round(x * cosA - y * sinA, 2);
            rotated[i, 1] = Math.Round(x * sinA + y * cosA, 2);
        }

        return rotated;
    }
}

