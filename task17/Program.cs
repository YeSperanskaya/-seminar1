﻿Console.WriteLine("Введите координты точек");
Console.Write("x: ");
int xCoorinate = Convert.ToInt32(Console.ReadLine());

Console.Write("y: ");
int yCoorinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoorinate, yCoorinate);


string result = quarter > 0 ? $"Указанные коооррдинаты соответствуют четверти {quarter}" : "Введены  некорректные координаты";

Console.WriteLine(result);
int Quarter(int x, int y)
{ 
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}