/*Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] NewArray(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

void PrintArray(double[] array) //функция вывода на экран 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
        
    }
    Console.WriteLine();
}

double[] array = NewArray(10);
PrintArray(array);

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double maxNum = MaxNumber(array);
double minNum = MinNumber(array);
double res = maxNum - minNum;
Console.Write($"разница между максимальным и минимальным элементов массива равна {res}");