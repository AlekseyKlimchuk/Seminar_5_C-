//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayWithRandomNumbers(int numbers = 12, int startInterval = 100, int endInterval = 1000)
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
int CountPositiveNumber (int[] input)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] % 2 ==  0)
            count++;
    }

    return count;
}

var array = CreateArrayWithRandomNumbers();
Print(array);

var countpositivenumber = CountPositiveNumber(array);
Console.WriteLine("Количество четных чисел: " + countpositivenumber);

