string QuarterToCoords(int num)
{ 
    if(num == 1) return "x > 0, y > 0";
    if(num == 2) return "x < 0, y > 0";
    if(num == 3) return "x < 0, y < 0";
    if(num == 4) return "x > 0, y < 0";
    return null;
}


Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

string quarter = QuarterToCoords(number);


string result = quarter != null ? $"Указанная четверть соответствуют координатам {quarter}" : "Введены  некорректные координаты";

Console.WriteLine(result);

