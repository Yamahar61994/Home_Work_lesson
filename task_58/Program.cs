/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Введите кол-во строк: ");
int RowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int ColumsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] CreatMatrix(int n, int m)
{
    int[,] Array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Array[i, j] = new Random().Next(10);
        }
    }
    return Array;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ArrayA = CreatMatrix(RowsMatrix, ColumsMatrix);
Console.WriteLine("Это иходная матрица A");
PrintMatrix(ArrayA);
Console.WriteLine();
int[,] ArrayB = CreatMatrix(RowsMatrix, ColumsMatrix);
Console.WriteLine("Это иходная матрица B");
PrintMatrix(ArrayB);
Console.WriteLine();

int[,] ProizvMatrix = new int[RowsMatrix, ColumsMatrix];
for (int i = 0; i < RowsMatrix; i++)
{
    for (int j = 0; j < ColumsMatrix; j++)
    {
        ProizvMatrix[i,j] = 0;
        for (int k = 0; k < ColumsMatrix; k++)
        {
            ProizvMatrix[i,j] += ArrayA[i,k] * ArrayB[k,j];
        }
    }
}
Console.WriteLine("Матрица С =>  произведение матриц A и B");
PrintMatrix(ProizvMatrix);