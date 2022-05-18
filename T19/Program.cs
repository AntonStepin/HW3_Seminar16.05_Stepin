// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

double MirrorNumber(int number)
{
    double MirrorNumber = 0;
    while (number > 0)
    {
        double temp = number % 10;
        MirrorNumber = (MirrorNumber + (temp / 10)) * 10;
        number = number / 10;
    }
    return MirrorNumber;
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("Отрицательное число не является палиндромом");
}
else if (number != MirrorNumber(number))
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} является палиндромом");
}