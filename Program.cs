// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 100) ^ (num > 999))
{
    Console.WriteLine("Введено некорректное число");
}
else
{
    Console.WriteLine($"Вторая цифра числа {num}: {(num - 100 * (num / 100) - num % 10) / 10}");
}