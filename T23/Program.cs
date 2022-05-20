// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeTable(int FromNummber, int UpToNumber)
{
    for (int i = FromNummber; i <= UpToNumber; i++)
    {
        int sum = i * i * i;
        Console.WriteLine($"{i}^3 = {sum}");
    }
}
Console.Write("Введите число от: ");
int FromNummber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число до: ");
int UpToNumber = Convert.ToInt32(Console.ReadLine());
CubeTable(FromNummber, UpToNumber);
