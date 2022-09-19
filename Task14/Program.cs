// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.Write("Введите первый делитель: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй делитель: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите делимое: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool Multiple (int num, int numD)
{
    return ((num % numD) == 0);
}
if (Multiple(numC,numA) && Multiple(numC,numB)) Console.WriteLine("кратно обоим");
    else Console.WriteLine("НЕ кратно обоим");