//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateArrayWithRandomNumbers(int numbers = 12,
int startInterval = -9,
int endInterval = 9)
{
    var result = new int[numbers];

    Random random = new();

    for (int i = 0; i < numbers; i++)
    {
        result[i] = random.Next(startInterval, endInterval + 1);
    }

    return result;
}

void Print(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i]);

        if (i != input.Length - 1)
            Console.Write(", ");
    }

    Console.WriteLine();
}
int SumElementsNumber(int[] input)
{

    int sumElements = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (i % 2 != 1)
        {
            sumElements = sumElements + input[i];
        }
    }
    return sumElements;
}


var array = CreateArrayWithRandomNumbers();
Print(array);

var sumElements = SumElementsNumber(array);
Console.WriteLine("Сумма положительных чисел: " + sumElements);










