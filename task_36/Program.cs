//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите значение длинны массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] arrayRandom = new int[size];

for (int i=0; i< size; i++)
{
	arrayRandom[i] = new Random().Next(100);
}
Console.WriteLine($" [{string.Join("\t", arrayRandom)}]");

for (int c=1; c < arrayRandom.Length; c+=2)
{
	sum +=arrayRandom[c];
}
Console.WriteLine($"Сумма элементов на нечётных местах = {sum}");