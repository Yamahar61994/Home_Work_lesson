/*Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */

Console.WriteLine("Введите кол-во строк: ");
int RowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int ColumsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

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

int summaRowsNumbers = 0;
Console.WriteLine();

for (int j = 0; j < ColumsMatrix; j++)
{
    for (int i = 0; i < RowsMatrix; i++)
    {
        summaRowsNumbers = summaRowsNumbers + aray[i, j];
    }
    double ArifMean = summaRowsNumbers / RowsMatrix;
    Console.Write(ArifMean + "; ");
    ArifMean = 0;
    summaRowsNumbers = 0;
}
//Михаил, при выводе округлят до целого числа, хотя указан тип double
//Программа считает всё правильно, но огруляет ответ до целого