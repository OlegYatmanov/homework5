using System;
using static System.Console;
Clear();

int InputNumber(string message)
{
    WriteLine(message);
    return int.Parse(ReadLine());
}
int[] randomArray()
{
    int sizeArr = InputNumber("Введите размер массива: ");
    int[] numbers = new int[sizeArr];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(99, 999);
    }
    return numbers;
}
int[] arr = randomArray();
int result = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        result++;
    }
}
Write("В массиве [{0}] ", string.Join(", ", arr));
WriteLine($" количества чётных чисел равно: {result}");