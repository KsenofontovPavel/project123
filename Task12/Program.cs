﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write ("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1 % num2;
if (result == 0) Console.WriteLine ($"Число {num1} кратно числу {num2}");
else Console.WriteLine ($"Число {num1} не кратно числу {num2}. Остаток от деления: {result}");
