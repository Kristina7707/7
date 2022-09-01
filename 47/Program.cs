// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] CreateMatrixRndDouble(int row, int col, int min, int max) 
{
    
    double[,] matrix = new double[row, col];
    

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().NextDouble() * 100;
             matrix[i, j] = Math.Round(matrix[i, j], 3);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}"+"   ");
            else Console.Write($"{matrix[i, j],3}" +"   ");
        }
        Console.WriteLine("]");
    }

}


double[,] matrixdouble = CreateMatrixRndDouble(4, 4, 0, 10);
PrintMatrix(matrixdouble);
