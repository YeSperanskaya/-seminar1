//Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
int number = new Random().Next(10, 100);
Console.WriteLine($"Random number [10, 100] -> {number}");

//if (firstDigit > secondDigit) Console.WriteLine ($"max number -> {firstDigit}")
//else Console.WriteLine ($"max number -> {secondDigit}");

//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine("Max digit is " + maxDigit);

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
     return maxDigit;
};

int maxDigit = MaxDigit(number);
Console.WriteLine(maxDigit);