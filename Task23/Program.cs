// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите любое целое число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Неверное число!");
int i = 1;
while (i <= number)
{
    Console.WriteLine($"{i}    {i*i*i}");
    // Console.WriteLine(i*i);
    i++;
}

Console.WriteLine();
