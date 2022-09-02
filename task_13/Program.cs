/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
string? chislo = Convert.ToString(Console.ReadLine());
int leng = chislo.Length;


if (leng>3) 
	Console.WriteLine($"Третья цифра {chislo[2]}");
else
	Console.WriteLine($"Третьей цифры нет!");