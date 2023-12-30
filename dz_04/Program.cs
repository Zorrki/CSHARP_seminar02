// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1)
{
    // Создаем строку для хранения цифр числа через запятую.
    string result = "";
    int copyNumber = number;
    while (copyNumber > 0)
    {
        // Получаем последнюю цифру числа.
        int lastDigit = copyNumber % 10;
        // Добавляем цифру в начало строки с результатом.
        result = $"{lastDigit}, {result}";
        // Убираем последнюю цифру числа.
        copyNumber /= 10;
    }
    // Убираем последнюю запятую и выводим результат.
    Console.WriteLine(result.TrimEnd(',', ' '));
}
else
{
    // Если введено число меньше 1, выводим сообщение об ошибке.
    Console.WriteLine("Это не натуральное число!");
}



// using System;
// class Program
// {
// static void Main()
// {
// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
// while (N > 0)
// {
// int currentDigit = N % 10;
// N /= 10;
// if (N > 0)
// {
// Console.Write(currentDigit + ",");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }
// }
// }
// }