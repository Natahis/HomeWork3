// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10) Console.WriteLine($"Число {number} -> палиндром.");
// else Console.WriteLine($"Число {number} -> не является палиндромом.");

string Palindrom(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10) return ($"Число {num} -> палиндром.");
    return ($"Число {num} -> не является палиндромом.");
}

string result = Palindrom(number);
Console.WriteLine(result);