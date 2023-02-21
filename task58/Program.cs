/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
rez[0, 0] = (matrA[0, 0] * matrB[0, 0]) + (matrA[0, 1] * matrB[1, 0]);
rez[0, 1] = (matrA[0, 0] * matrB[0, 1]) + (matrA[0, 1] * matrB[1, 1]);
rez[1, 0] = (matrA[1, 0] * matrB[0, 0]) + (matrA[1, 1] * matrB[1, 0]); 
rez[1, 1] = (matrA[1, 0] * matrB[0, 1]) + (matrA[1, 1] * matrB[1, 1]);*/
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

int [,] MultiplyMatr (int[,] matrA, int[,] matrB)
{
int[,] rez = new int[matrA.GetLength(0), matrB.GetLength(1)];
     if (matrA.GetLength(1) == matrB.GetLength(0))
    {
        for (int i = 0; i < rez.GetLength(0); i++)
        {
            for (int j = 0; j < rez.GetLength(1); j++)
            {
                rez [i, j] = 0;
                for (int n = 0; n < matrA.GetLength(1); n++)
                {
                    rez [i, j] += matrA[i, n] * matrB[n, j];
                }
            }
        }
    }
   return rez;
}


int[,] matrA = new int [2, 2] { {2, 4}, {3, 2} };

int[,] matrB = new int [2, 2] { {3, 4}, {3, 3} };
PrintMatrix(matrA);
Console.WriteLine();
PrintMatrix(matrB);
System.Console.WriteLine();
int [,] matrC = MultiplyMatr(matrA, matrB);
PrintMatrix(matrC);