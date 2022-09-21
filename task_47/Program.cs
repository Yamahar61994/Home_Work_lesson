/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9rld!");*/
int rows = 3;
int colums = 4;
double[,] CreatMatrix(int n, int m)
{
    double[,] Aray = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Aray[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        }
    }
    return Aray;
}
void PrintMatrix(double[,] inputMatrix)
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
double[,] resultMatrix = CreatMatrix(rows, colums);//Заполнение массива
PrintMatrix(resultMatrix); // Вывод массива

