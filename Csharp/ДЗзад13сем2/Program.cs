//задача 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите трёхзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num < -100)
{
    System.Console.WriteLine("третьей цифры нет");

}
while (num > 1000 || num < -1000)
{
    num = num / 10;
}
System.Console.WriteLine(num = num % 10);