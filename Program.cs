// //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number_A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number_B = int.Parse(Console.ReadLine()!);

  if (number_A > number_B)
{
    Console.WriteLine($"Первое число {number_A} больше чем второе {number_B}");
}

  else
{
    Console.WriteLine($"Второе число {number_B} больше чем первое {number_A}");
}