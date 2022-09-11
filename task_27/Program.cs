/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int size = 0;
int n = number;

while (n > 0)
{
	n = n/10;
	size++;
}

Console.WriteLine(SumNumber(number));

int SumNumber (int num)
{
	int sum = 0;
	for ( int i=0; i < size; i++)
	{
		int n = num % 10;
		num = num / 10;
		sum+= n;
	}
		
	return sum;
}
