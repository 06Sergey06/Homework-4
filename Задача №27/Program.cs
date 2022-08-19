// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int GetCountNumbers(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = num % 10;
        num = num / 10;
        count = count + number;
    }
    return count;
}
Console.WriteLine($"Сумма чисел: {GetCountNumbers(num)}");
