using System;
using static System.Console;
Clear();

Write ("Введите число элементов массива: ");
int a = int.Parse(ReadLine());
double [] numbers = new double [a];
FillArray (numbers);
PrintArray (numbers);

double max = numbers [0];
for (int i = 0; i < a; i++)
    {
        if (numbers[i] > max)
         {
            max = numbers[i];
         }
    }
double min = numbers [0];
for (int i = 0; i < a; i++)
    {
        if (numbers[i] < min)
         {
            min = numbers[i];
         }
    }
double difference = max - min;
WriteLine ("Разница между максимальными и минимальными элементами массива: "+difference);
void FillArray (double [] array)
  {
    for (int i =0; i < array.Length; i++)
    {
       numbers [i] = new Random().Next(0,100);
    }

  }

  void PrintArray (double [] array)
  {
    for (int i =0; i < array.Length; i++)
    {
       Write(numbers [i] + " ");
    }
    WriteLine();
  }