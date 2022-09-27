/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/



Console.WriteLine("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) 
{
    Console.WriteLine("Это невозможно");
    return;
}
int SumNumber(int M, int N)
{
    //Базовый
    if (M == N) return N;
    //Рекурсивный
    return (M + SumNumber(M + 1, N));
}
Console.WriteLine(SumNumber(M,N));