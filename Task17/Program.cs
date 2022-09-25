// Задача 17. Напишите программу, 
// 1. которая принимает на входbкоординаты точки (X и Y),
// 2. причём X ≠ 0 и Y ≠ 0 и выдаёт
// 3. номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int qurter = Qurter (x, y);
string result = qurter > 0 ? "$Указанные кординаты соответствует четверти -> {qurter.ToString()}" : "Введены некоректные координаты";
Console.WriteLine(result);

int Qurter (int xc, int yc)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
