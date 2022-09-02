/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>100 && number<999)
{
	int number_1 = number/100;
	int number_2 = (number - number_1*100)/10;
	Console.Write($"Вторая цифра {number_2}");
}
else 
Console.Write($"число НЕ трёхзначное! ");