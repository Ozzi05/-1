// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int randomNumber = rand.Next(10, 100);

System.Console.WriteLine(randomNumber);

if (randomNumber / 10 > randomNumber % 10)
{
    System.Console.WriteLine($"Левое число больше -> {randomNumber / 10}");
}
else if (randomNumber % 10 > randomNumber / 10)
{
    System.Console.WriteLine($"Правое число больше -> {randomNumber % 10}");
}
else
{
    System.Console.WriteLine("Числа равны");
}



// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


Random rand = new Random();
int NumberA = rand.Next(100, 1000);
System.Console.WriteLine(NumberA);
System.Console.WriteLine(NumberA/100);
System.Console.WriteLine(NumberA%10);
System.Console.WriteLine();


Random rand = new Random();
            int number = rand.Next(100, 1000);
            Console.WriteLine(number);
            int result = (number / 100) * 10 + (number % 10);
            Console.WriteLine(result);
            Console.WriteLine();


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.WriteLine("введите число 1");
int number1 =Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите число 2");
int number2 =Convert.ToInt32(Console.ReadLine());

if (number1%number2 == 0)
{
    System.Console.WriteLine("Числа кратны");
}
else System.Console.Write("Число не кратно. Остаток от деленеия = " + number1%number2)


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} -> да");
}
else
{
     Console.WriteLine($"{number} -> нет");
}

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


System.Console.WriteLine("Введите число 1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 * Number1 == Number2 || Number2 * Number2 == Number1)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}