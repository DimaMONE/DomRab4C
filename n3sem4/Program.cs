//Задача 29: Напишите программу, которая задаёт массив
// из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
Console.WriteLine("Введите числа массива");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int x3 = Convert.ToInt32(Console.ReadLine());
int x4 = Convert.ToInt32(Console.ReadLine());
int x5 = Convert.ToInt32(Console.ReadLine());
int x6 = Convert.ToInt32(Console.ReadLine());
int x7 = Convert.ToInt32(Console.ReadLine());
int x8 = Convert.ToInt32(Console.ReadLine());
int[] array = {x1,x2,x3,x4,x5,x6,x7,x8};
    Console.WriteLine();

void PrintArray(int[]array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
PrintArray(array);
