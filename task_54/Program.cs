/*Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.WriteLine("Введите кол-во строк: ");
int RowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int ColumsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] CreatMatrix(int n, int m)
{
    int[,] Array = new int[n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
           Array[i,j] = new Random().Next(20); 
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

int[,] NewArray = CreatMatrix(RowsMatrix, ColumsMatrix);
Console.WriteLine("Это иходная матрица");
PrintMatrix(NewArray);
Console.WriteLine();
int temp = 0;
for (int i = 0; i < RowsMatrix; i++)
{
    for (int j = 0; j < ColumsMatrix - 1; j++)
    {
        for (int k = j + 1; k < ColumsMatrix; k++)
        {
            if (NewArray[i,j] < NewArray[i,k])
            {
                temp = NewArray[i,j];
                NewArray[i,j] = NewArray[i,k];
                NewArray[i,k] = temp;
            }
        }
    }
}
Console.WriteLine("Эта отсортированная матрица ");
PrintMatrix(NewArray);