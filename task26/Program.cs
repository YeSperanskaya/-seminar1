// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// void Number(string number)
// {
//     int count = number.Lenght; 
//     Console
// }

// Console.WriteLine("Введите число");
// string number = Console.ReadLine();

int CountOfNumber (int num);
{
    int count = 0;
    while (num != 0)
    {
        int num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int countOfNumber = (CountOfNumber(number));
Console.WriteLine($"Количество чисел в числе ->  {countOfNumber}");