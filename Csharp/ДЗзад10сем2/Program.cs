// напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

System.Console.WriteLine("Введите трёхзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
if  (num<99 || 1000<num)
{
    System.Console.WriteLine("Введите коректное число");
}
else if (num>99 || 1000>num)
{
   System.Console.WriteLine(num = num / 10 % 10);
};
System.Console.WriteLine();