// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
     int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =  rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[] FindNumberPosition(int[,] matrix, int number) 
{
    int[] position = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void PrintMatrix(int[,] matrix)
{   
    Console.WriteLine("   ");
   

    for (int i = 0; i < matrix.GetLength(0); i++)
    {Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 1000 > 0) Console.Write($"{matrix[i, j]}   ");
            else if (matrix[i, j] / 100 > 0) Console.Write($" {matrix[i, j]}   ");
            else if (matrix[i, j] / 10 > 0) Console.Write($"  {matrix[i, j]}   ");
            else Console.Write($"   {matrix[i, j]}   ");
        } Console.Write("]");
        Console.WriteLine();
    }
}

void PrintPosition(int[] pos, int num)
{
    Console.WriteLine();
    if (pos[0] > 0 && pos[1] > 0)Console.WriteLine($"Число {num} находится в {pos[0]}-й строке, {pos[1]}-м столбце");
    else Console.WriteLine($"Число {num} отсутствует в заданном массиве");
    Console.WriteLine();
}

int GetNumerToFind()
{
    Console.WriteLine();
    Console.Write("Введите число:   ");
    int numb =Convert.ToInt32(Console.ReadLine());
    int number = Convert.ToInt32(numb);
    return number;
}

int row = 7;
int col = 10;
int min = 1;
int max = 1000;

int[,] matrix = CreateMatrixRndInt(row, col, min, max);
PrintMatrix(matrix);
int number = GetNumerToFind();
int[] position = FindNumberPosition(matrix, number);
PrintPosition(position, number);