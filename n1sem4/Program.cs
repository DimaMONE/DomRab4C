// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int c = a*a;
for(int i = 0; i < b - 2; i++)
{
   c = c*a;
}
Console.WriteLine($"Число {a} в степени {b} равно {c} ");
