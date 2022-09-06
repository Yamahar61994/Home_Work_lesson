/*Задача 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
string? word = Console.ReadLine();

if (word.Length==5)
{
	if (word[0]==word[4] && word[1]==word[3])
	  Console.WriteLine($"число полинндром");
	else 
	  Console.WriteLine($"число НЕ полиндром, УВЫ(");
}
else 
  Console.WriteLine("число не пятизначное");
