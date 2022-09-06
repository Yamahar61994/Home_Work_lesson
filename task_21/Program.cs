/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
d^2= (х2— х1)^2 + (y2— y1)^2 + (z2-z1)^2;
*/
Console.WriteLine("Вводим кординаты первой точки A ");
Console.WriteLine("Введите кординату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим кординаты второй точки B ");
Console.WriteLine("Введите кординату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//double sq = Math.Sqrt(z2);
//double d = Math.Pow(z2,2);
double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"Длина отрезка AB = {Math.Round(d,2)}");
