/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание,
 что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
17 -> такого числа в массиве нет */

Console.WriteLine("Введите номер строки: ");
int numberRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int numberColums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int RowsMatrix = 3;
int ColumsMatrix = 4;

int[,] aray = new int[RowsMatrix, ColumsMatrix];
for (int i = 0; i < RowsMatrix; i++)
{
    for (int j = 0; j < ColumsMatrix; j++)
    {
        aray[i, j] = new Random().Next(11);
        Console.Write(aray[i, j] + "\t");
    }
    Console.WriteLine();
}
int n = numberRows - 1;
int m = numberColums - 1;
if (n < aray.GetLength(0) && m < aray.GetLength(1))
{
    Console.WriteLine($"Элемент {numberRows} строки {numberColums} столбца = {aray[n, m]}");
}
else Console.WriteLine("Такова элемента не существует");