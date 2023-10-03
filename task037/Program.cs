// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;

}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    // Console.WriteLine("]"); если добавим в метод, то скобки будут выводится всегда. Если скобки не критичны, то стоит выводить за метод.
}

int[] ProductOfNums (int[] arr)
{
    // получаем размер нового массива
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size +=1;
    // создаем новый массив
    int[] arrNew = new int[size];
    // заполняем новый массив произведением пар чисел
    for (int i = 0; i <arr.Length / 2; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length-1-i];
    }
    // добавляем последний элемент средний элемент исходного для  нечетных размеров массива
    if (arr.Length % 2 != 0) arrNew[arrNew.Length-1] = arr[arr.Length/2];
    return arrNew;
}


int[] array = CreateArrayRndInt(5, 1, 9);
// PrintArray(array);
Console.Write(" [");
PrintArray(array);
Console.WriteLine("]");
int[] productOfNums = ProductOfNums(array);
PrintArray(productOfNums);




// создание и вывод нецелых числе

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;

}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double nRoubd = Math.Round(arr[1], 1);
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    // Console.WriteLine("]"); если добавим в метод, то скобки будут выводится всегда. Если скобки не критичны, то стоит выводить за метод.
}