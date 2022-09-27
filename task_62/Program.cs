/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

 1  2  3  4
12 13 14  5
11 16 15  6
10  9  8  7 
*/

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

int RowsMatrix = 4;
int ColumsMatrix = 4;
int[,] Matrix = new int[RowsMatrix, ColumsMatrix];
int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = ColumsMatrix;
for (int i = 0; i < Matrix.Length; i++)
{
    Matrix[col,row] = i +1;
    if (--gran == 0)
    {
    gran = ColumsMatrix * (dirChanges % 2) + RowsMatrix * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
    
    int temp = dx;
    dx = - dy;
    dy = temp;
    dirChanges++;
    }
    // Выбор: заполнять по часовой стрелке или против.
    col += dy;
    row += dx;
}

PrintMatrix(Matrix);