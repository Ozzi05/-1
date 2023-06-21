// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for(int i = 1; i <= number; i++)
// {
//     sum = sum + i;
// }

// System.Console.WriteLine($"Сумма числе от 1 до {number}: {sum}");


// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumNumbers(int A)
// {
//     int sum = 0;

//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;
//     }

//     return sum;
// }

// //------------------------------------------------------------------

// int number = ReadInt("Введите число: ");
// int sum = SumNumbers(number);

// System.Console.WriteLine($"Сумма числе от 1 до {number}: {sum}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Math.Abs(Convert.ToInt32(Console.ReadLine()));
// }

// int CountNumbers(int N)
// {
//     int count = 0;

//     if (N == 0)
//     {
//         return 1;
//     }

//     while (N > 0)
//     {
//         N /= 10; // number = number / 10
//         count++;
//     }

//     return count;
// }

// // -----------------------------------------------------------------------

// int count = CountNumbers(ReadInt("Введите число: "));
// System.Console.WriteLine($"Количество цифр в числе -> {count}");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int Readint(string text)
// {
//     System.Console.Write(text);
//     return Math.Abs(Convert.ToInt32(Console.ReadLine()));
// }
// int Result(int N)
// {
//     int factorial = 1;
//     for(int i=1;i<=N ; i++)
//     {
//         factorial=factorial*i;
//     }
//     return factorial;
// }

// int number = Readint("введите число: ");
// if(number < 1 )
// {
//     System.Console.WriteLine("Введите коректное число");
//     return;
// }
// int result = Result(number);
// System.Console.WriteLine(result);



 
// void FillArray(int[] arr)
// {
//     Random rand = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(0, 2);
//     }
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine(string.Join(" ", arr));
// }

// int ReadInt(string text) // string, int[], string[], bool, void
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // ------------------------------------------------------

// int sizeArray = ReadInt("Введите размер массива: ");
// int[] array = new int[sizeArray];
// FillArray(array);
// PrintArray(array);