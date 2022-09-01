// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{

    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10) System.Console.Write($" {matrix[i, j]}  ");
            else System.Console.Write($"  {matrix[i, j]}  ");
   
        }
        Console.WriteLine("]");
    }

}

double[] GetArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.WriteLine("Среднее арифметическое = ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]};  ");
       
    }
}

int row = 4;
int col = 4;
int min = 1;
int max = 10;

int[,] matrix = CreateMatrixRndInt(row, col, min, max);
PrintMatrix(matrix);
double[] arithmeticmean = GetArithmeticMean(matrix);
PrintArray(arithmeticmean);
System.Console.WriteLine();
System.Console.WriteLine();
