/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] ArrayRandom (int size)
{
	int[] array = new int[size];
	for(int i=0; i<size; i++)
	{
		array[i] = new Random().Next(8);
	}
	return array;
}
int[] ResultArray = ArrayRandom(8);
Console.WriteLine($"Случайнный массив [ {String.Join(",", ResultArray)} ] ");
