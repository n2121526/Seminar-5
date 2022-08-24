/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];   
    }
    return sum;
 }

int[] array = GetArray(5, 1, 100);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", SumArray(array)));
