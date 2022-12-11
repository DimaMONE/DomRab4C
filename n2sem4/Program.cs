// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = n % 10;
int i = 0;
void Sum()
{
    while (n > 0)
    {
        n = n / 10;
        i = n;
        if (n < 10)
        {
            sum = sum + i;
        }
        else
        {
            i = i % 10;
            sum = sum + i;
        }

    }
}

Sum();
Console.WriteLine($"Сумма цифр равна {sum} ");