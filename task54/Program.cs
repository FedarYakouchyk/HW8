/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
int[,] Arr2d()
{
    System.Console.WriteLine("Введите кол-во строк: M и кол-во столбцов: N, а также диапазон значений [Lrange; Rrange]");
    int row = Convert.ToInt32(Console.ReadLine());
    int col = Convert.ToInt32(Console.ReadLine());
    int Lrange = Convert.ToInt32(Console.ReadLine());
    int Rrange = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random();
    int[,] matrix = new int[row, col];
    System.Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rand.Next(Lrange, Rrange + 1);
        }
    }
    System.Console.WriteLine();
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] Sorting(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(1) - j - 1; m++)
            {
                if (matrix[i, m] < matrix[i, m + 1])
                {
                    int t = matrix[i, m];
                    matrix[i, m] = matrix[i, m + 1];
                    matrix[i, m + 1] = t;
                }
            }
        }
    }
    return result;
}
int[,] array = Arr2d();
PrintMatrix(array);
System.Console.WriteLine();
int[,] array2 =Sorting(array);
PrintMatrix(array);