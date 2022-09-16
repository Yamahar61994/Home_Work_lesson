//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа: ");
string? chisLo = Console.ReadLine();
int count = 0;

string[] cifra = chisLo.Split('.');
foreach (var number in cifra)
{
    //Console.WriteLine($"{number}");
    int a = Convert.ToInt32(number);
        if (a > 0) count++;
}
Console.WriteLine($"Колличество положительных чисел: {count}");