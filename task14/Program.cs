// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Please enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool Division7And23 (int num)
{
    int firstNumber = 7;
    int secondNumber = 23;
    int num1 = num % firstNumber;
    int num2 = num % secondNumber;
    if (num1 & num2 == 0) return yes;
    esle return no;
} 
bool division = Division7And23(45);
Console.WriteLine($"result {number} -> division");