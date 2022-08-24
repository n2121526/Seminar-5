﻿/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.*/
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int EvenNum(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
      if (mas[i] % 2 == 0)
          {
               count++;
          }
    }
    return count;
}
int[] array = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", EvenNum(array)));

