// Задача 9. Напишите программу, которая выводит
// 1. случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 3. вывод результата

// 78 -> 8
// 12-> 2
// 85 -> 8

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if(firstDigit == secondDigit) System.Console.WriteLine("Цифры одинаковые");
// else if(firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {number} => {firstDigit}");
// else Console.WriteLine($"наибольшая цифра числа {number} => {secondDigit}");

// int maxDigit = 0;
// if(firstDigit > secondDigit) maxDigit = firstDigit;
// else maxDigit = secondDigit;

// int max = firstDigit > secondDigit ? firstDigit : secondDigit;


int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    //if(firstDigit > secondDigit) return firstDigit;
    //return secondDigit;
    if(firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int number = new Random().Next(10, 100);
System.Console.WriteLine($"Случайно число из отрезка 10 - 99 => {number}");

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString(): "Цифры одинаковые";
Console.WriteLine($"наибольшая цифра числа {number} => {maxDigit}");
