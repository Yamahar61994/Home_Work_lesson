/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите значение А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B: ");
int b = Convert.ToInt32(Console.ReadLine());

double NumberDegree (int a, int b)
{
	double step = Math.Pow(a,b);
	return step;
}
Console.WriteLine(NumberDegree(a,b));

//Михаил, не понюмаю, зачем нужен цикл?