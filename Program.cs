// //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int number_A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int number_B = int.Parse(Console.ReadLine()!);

//   if (number_A > number_B)
// {
//     Console.WriteLine($"Первое число {number_A} больше чем второе {number_B}");
// }

//   else
// {
//     Console.WriteLine($"Второе число {number_B} больше чем первое {number_A}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int number_1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int number_2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int number_3 = int.Parse(Console.ReadLine()!);

// int max = number_1;

// if (number_2 > max)
// { 
//   max = number_2;
// }
// if (number_3 > max)
// {
//   max = number_3;
// }

// Console.WriteLine($"Максимальное из этих чисел: {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)

{
  Console.WriteLine($"Число {num} является ЧЁТНЫМ");
}

else

{
  Console.WriteLine($"Число {num} является НЕЧЁТНЫМ");
}
