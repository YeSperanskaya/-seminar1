// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
bool MultipleTwoNumbers(int num1,int num2)
{
    return num2 / num1 == num1;
}
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

// if (number % firstNumber == 0 && number % secondNumber == 0)
// {
//     Console.WriteLine($"{number}-> Да");
// }
// else
//     Console.WriteLine($"{number}-> Нет");
bool result = MultipleTwoNumbers(number1, number2);
Console.WriteLine(result ? $"{number1}, {number2} -> Да" : $"{number1}, {number2}-> Нет" );