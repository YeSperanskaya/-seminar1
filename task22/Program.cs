// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

void TableSquare(int number)
{
    int index = 1;
    while (index < number+1)
    {
        Console.WriteLine($"{index, 3} -> {index*index, 5}");
        index++;
    }
}

TableSquare(num);