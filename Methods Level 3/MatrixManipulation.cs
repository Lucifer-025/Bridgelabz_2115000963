using System;

class MatrixManipulation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows for the matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns for the matrix: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix1 = GenerateRandomMatrix(rows, cols);
        int[,] matrix2 = GenerateRandomMatrix(rows, cols);

        Console.WriteLine("\nMatrix 1:");
        DisplayMatrix(matrix1);

        Console.WriteLine("\nMatrix 2:");
        DisplayMatrix(matrix2);

        Console.WriteLine("\nMatrix Addition:");
        DisplayMatrix(AddMatrices(matrix1, matrix2));

        Console.WriteLine("\nMatrix Subtraction:");
        DisplayMatrix(SubtractMatrices(matrix1, matrix2));

        if (rows == cols)
        {
            Console.WriteLine("\nMatrix Multiplication:");
            DisplayMatrix(MultiplyMatrices(matrix1, matrix2));

            Console.WriteLine("\nTranspose of Matrix 1:");
            DisplayMatrix(TransposeMatrix(matrix1));

            if (rows == 2)
            {
                Console.WriteLine("\nDeterminant of Matrix 1 (2x2): " + Determinant2x2(matrix1));
                Console.WriteLine("\nInverse of Matrix 1 (2x2):");
                DisplayMatrix(Inverse2x2(matrix1));
            }
            else if (rows == 3)
            {
                Console.WriteLine("\nDeterminant of Matrix 1 (3x3): " + Determinant3x3(matrix1));
                Console.WriteLine("\nInverse of Matrix 1 (3x3):");
                DisplayMatrix(Inverse3x3(matrix1));
            }
        }
        else
        {
            Console.WriteLine("\nMatrix Multiplication, Determinant, and Inverse operations are not supported for non-square matrices.");
        }
    }

    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }
        return matrix;
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix2.GetLength(1);
        int common = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < common; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transpose = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }
        return transpose;
    }

    static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    static double[,] Inverse2x2(int[,] matrix)
    {
        int determinant = Determinant2x2(matrix);
        if (determinant == 0)
        {
            throw new Exception("Matrix is singular and cannot be inverted.");
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / (double)determinant;
        inverse[0, 1] = -matrix[0, 1] / (double)determinant;
        inverse[1, 0] = -matrix[1, 0] / (double)determinant;
        inverse[1, 1] = matrix[0, 0] / (double)determinant;

        return inverse;
    }

    static int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
               matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
               matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    static double[,] Inverse3x3(int[,] matrix)
    {
        int determinant = Determinant3x3(matrix);
        if (determinant == 0)
        {
            throw new Exception("Matrix is singular and cannot be inverted.");
        }

        double[,] adjoint = new double[3, 3];
        adjoint[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
        adjoint[0, 1] = -(matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
        adjoint[0, 2] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

        adjoint[1, 0] = -(matrix[0, 1] * matrix[2, 2] - matrix[0, 2] * matrix[2, 1]);
        adjoint[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]);
        adjoint[1, 2] = -(matrix[0, 0] * matrix[2, 1] - matrix[0, 1] * matrix[2, 0]);

        adjoint[2, 0] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]);
        adjoint[2, 1] = -(matrix[0, 0] * matrix[1, 2] - matrix[0, 2] * matrix[1, 0]);
        adjoint[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

        double[,] inverse = new double[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                inverse[i, j] = adjoint[i, j] / determinant;
            }
        }
        return inverse;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void DisplayMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(Math.Round(matrix[i, j], 2) + "\t");
            }
            Console.WriteLine();
        }
    }
}
