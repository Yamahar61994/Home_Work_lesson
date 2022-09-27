/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3

8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка */

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

int[,] NewArray = CreatMatrix(RowsMatrix, ColumsMatrix);
Console.WriteLine("Это иходная матрица");
PrintMatrix(NewArray);
Console.WriteLine();

//Создаём массив из элементов сумм по строкам

int[] SummaRowsMatrix = new int[RowsMatrix + 1];
int sum = 0;
for (int i = 0; i < RowsMatrix; i++)
{
    for (int j = 0; j < ColumsMatrix; j++)

    {
        sum += NewArray[i, j];
    }
    SummaRowsMatrix[i] = sum;
    sum = 0;
}

// Находим сроку с наименьшей суммой

int min = SummaRowsMatrix[0];
int iMin = 0;

for (int i = 0; i < RowsMatrix; i++)
{
    Console.Write($"{SummaRowsMatrix[i]}  ");
    if (min > SummaRowsMatrix[i])
    {
        min = SummaRowsMatrix[i];
        iMin = i;
    }
}
Console.WriteLine();
Console.WriteLine($"{iMin + 1} строка с наименьшей суммой элементов");