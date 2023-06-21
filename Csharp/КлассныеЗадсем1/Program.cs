// // Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// // 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число :");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int numberB = 0;
// if (numberA > 0) { numberB = -numberA; }
// else
// {
//     numberB = numberA;
//     numberA = -numberA;
// }
// while (numberA >= numberB)
// {
//     Console.WriteLine(numberB + " ");
//     numberB++;
// }
// Console.ReadKey();








// Console.WriteLine("Введите первое число :");
//  numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число :");
// numberB = Convert.ToInt32(Console.ReadLine());

// if ((numberB * numberB) == numberA)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
// Console.ReadKey();







// // Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // 3 -> Среда 
// // 5 -> Пятница



// Console.WriteLine("Введите номер дня недели");
// int DayWeek = Convert.ToInt32(Console.ReadLine());

// switch (DayWeek)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         Console.WriteLine("Вторник");
//         break;
//     case 3:
//         Console.WriteLine("Среда");
//         break;
//     case 4:
//         Console.WriteLine("Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Пятница");
//         break;
//     case 6:
//         Console.WriteLine("Суббота");
//         break;
//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;
//     default:
//         Console.WriteLine("Ошибка");
//         break;
// }




// // Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // 3 -> Среда 
// // 5 -> Пятница



// System.Console.WriteLine("введите номер дня недели: ");
//  DayWeek = Convert.ToInt32(Console.ReadLine());

// if (DayWeek == 1)
//     System.Console.WriteLine("сегодня понедельник");
// else if (DayWeek == 2)
//     System.Console.WriteLine("сегодня вторник");
// else if (DayWeek == 3)
//     System.Console.WriteLine("сегодня среда");
// else if (DayWeek == 4)
//     System.Console.WriteLine("сегодня четверг");
// else if (DayWeek == 5)
//     System.Console.WriteLine("сегодня пятница");
// else if (DayWeek == 6)
//     System.Console.WriteLine("сегодня суббота");
// else if (DayWeek == 7)
//     System.Console.WriteLine("сегодня воскресенье");
// else System.Console.WriteLine("такого дня не существует");


// System.Console.WriteLine("Введите имя пользователя:");

// string username = Console.ReadLine();

// // if (username.ToLower() == "Маша")
// // {
// //     System.Console.WriteLine("Ура, это же Маша");
// // }

// if (username.Equals("Маша", StringComparison.OrdinalIgnoreCase))
// {
//     System.Console.WriteLine("Ура, это же Маша");
// }

// else
// {
//     System.Console.Write("Привет, ");
//     System.Console.WriteLine(username);
// }