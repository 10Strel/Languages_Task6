Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).\r\n");

Console.WriteLine("Введите целое число:");

bool res = int.TryParse(Console.ReadLine(), out int number);
if (!res)
{
    Console.WriteLine("Ошибка ввода.\r\nВыполнение программы будет остановлено.");
    return;
}

Console.WriteLine($"Результат: {number} {(number % 2 == 0 ? "четное" : "нечетное")} число.");