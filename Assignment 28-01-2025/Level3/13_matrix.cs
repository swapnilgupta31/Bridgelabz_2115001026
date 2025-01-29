using System;
public class MatrixOperations
{
    // Method to create a random matrix
    public int[,] CreateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);  // Random values between 1 and 9
            }
        }
        return matrix;
    }

    // Method to add two matrices
    public int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
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

    // Method to subtract two matrices
    public int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
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

    // Method to multiply two matrices
    public int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix2.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    // Method to find the transpose of a matrix
    public int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }

    // Method to find the determinant of a 2x2 matrix
    public int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Method to find the determinant of a 3x3 matrix
    public int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
               matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
               matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    // Method to find the inverse of a 2x2 matrix
    public double[,] Inverse2x2(int[,] matrix)
    {
        int det = Determinant2x2(matrix);
        if (det == 0)
        {
            Console.WriteLine("Inverse does not exist.");
            return null;
        }
        double[,] result = new double[2, 2];
        result[0, 0] = matrix[1, 1] / (double)det;
        result[0, 1] = -matrix[0, 1] / (double)det;
        result[1, 0] = -matrix[1, 0] / (double)det;
        result[1, 1] = matrix[0, 0] / (double)det;
        return result;
    }

    // Method to find the inverse of a 3x3 matrix
    public double[,] Inverse3x3(int[,] matrix)
    {
        int det = Determinant3x3(matrix);
        if (det == 0)
        {
            Console.WriteLine("Inverse does not exist.");
            return null;
        }
        double[,] result = new double[3, 3];
        result[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / (double)det;
        result[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / (double)det;
        result[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / (double)det;
        result[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / (double)det;
        result[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / (double)det;
        result[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / (double)det;
        result[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / (double)det;
        result[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / (double)det;
        result[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / (double)det;
        return result;
    }

    // Method to display a matrix
    public void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Method to display a double matrix
    public void DisplayMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(Math.Round(matrix[i, j], 2) + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        MatrixOperations matrixOps = new MatrixOperations();

        // Create random matrices
        int[,] matrix1 = matrixOps.CreateRandomMatrix(3, 3);
        int[,] matrix2 = matrixOps.CreateRandomMatrix(3, 3);

        Console.WriteLine("Matrix 1:");
        matrixOps.DisplayMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        matrixOps.DisplayMatrix(matrix2);

        // Add matrices
        int[,] sum = matrixOps.AddMatrices(matrix1, matrix2);
        Console.WriteLine("Sum of matrices:");
        matrixOps.DisplayMatrix(sum);

        // Subtract matrices
        int[,] difference = matrixOps.SubtractMatrices(matrix1, matrix2);
        Console.WriteLine("Difference of matrices:");
        matrixOps.DisplayMatrix(difference);

        // Multiply matrices
        int[,] product = matrixOps.MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Product of matrices:");
        matrixOps.DisplayMatrix(product);

        // Transpose matrix
        int[,] transpose = matrixOps.TransposeMatrix(matrix1);
        Console.WriteLine("Transpose of Matrix 1:");
        matrixOps.DisplayMatrix(transpose);

        // Determinant and Inverse for 2x2 matrix
        int[,] matrix2x2 = matrixOps.CreateRandomMatrix(2, 2);
        Console.WriteLine("2x2 Matrix:");
        matrixOps.DisplayMatrix(matrix2x2);
        Console.WriteLine("Determinant of 2x2 matrix: " + matrixOps.Determinant2x2(matrix2x2));
        double[,] inverse2x2 = matrixOps.Inverse2x2(matrix2x2);
        Console.WriteLine("Inverse of 2x2 matrix:");
        matrixOps.DisplayMatrix(inverse2x2);

        // Determinant and Inverse for 3x3 matrix
        Console.WriteLine("Determinant of 3x3 matrix: " + matrixOps.Determinant3x3(matrix1));
        double[,] inverse3x3 = matrixOps.Inverse3x3(matrix1);
        Console.WriteLine("Inverse of 3x3 matrix:");
        matrixOps.DisplayMatrix(inverse3x3);
    }
}
