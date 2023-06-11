//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число :");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число :");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    System.Console.WriteLine("первое число больше");
}
else
{
    System.Console.WriteLine("второе число больше");
}

