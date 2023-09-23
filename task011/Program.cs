//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int TwoNumber (int num)
{
    int firstDigit = (num / 100) * 10;
    int lastDigit = num % 10;
    int twoNumber = firstDigit + lastDigit;
    return twoNumber;
} 
int twoNumber = TwoNumber(number);
Console.WriteLine($"{number} -> {twoNumber}");


