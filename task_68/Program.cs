/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

 */
Console.WriteLine("Введите значение m: ");
double  m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
double  n = Convert.ToDouble(Console.ReadLine());

double Akerman(double m, double n)
{
    if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akerman(n - 1, 1);
    else
      return Akerman(n - 1, Akerman(n, m - 1));
}
Console.WriteLine(Akerman(m,n));