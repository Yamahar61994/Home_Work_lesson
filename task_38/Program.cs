//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Введите значение длинны массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayRandom = new int[size];

for (int i=0; i < size; i++)
{
	arrayRandom[i] = new Random().Next(100);
}
Console.WriteLine($" [{string.Join(",\t", arrayRandom)}]");
int max = arrayRandom[0];
int min = arrayRandom[0];

for (int c=0; c < size; c++)
{
	if ( arrayRandom[c] > max ) max = arrayRandom[c];
	if ( arrayRandom[c] < min ) min = arrayRandom[c];
}
int summa = max + min;
Console.WriteLine($"MAX = {max} \t MIN = {min} ");
Console.WriteLine($"Сумма {max} + {min} = {summa}");