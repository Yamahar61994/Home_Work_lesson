//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayRand = new int[size];
int count = 0;

for (int i=0; i<arrayRand.Length ; i++)
{
	arrayRand[i] = new Random().Next(100,1000);
	int ost = arrayRand[i] % 2;
	if (ost == 0) count++;
}
Console.WriteLine($"[{String.Join(",\t", arrayRand)}]  --> {count}");