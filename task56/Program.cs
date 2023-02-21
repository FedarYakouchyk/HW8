/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
void printArray(int[] array)
{
    System.Console.WriteLine("[ " + String.Join("; ", array) + " ]");
}
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
void SearchMinRow(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i, j];
        }
    }
    printArray(result);
    int min = result[0];
    for (int m = 0; m < result.Length; m++)
    {
        if (result[m] < min)
        {
            min = result[m];
        }
    }
    for (int k = 0; k < result.Length; k++)
    {
        if (min == result[k])
        {
            System.Console.WriteLine($"Cтрокa, с наименьшей суммой элементов: {k + 1}");
        }
    }

}

int[,] array = Arr2d();
PrintMatrix(array);
System.Console.WriteLine();
SearchMinRow(array);
