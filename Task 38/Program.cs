/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

double GetMaxMin(double[] mass)
{
    double max = mass[0];
    double min = mass[0];
    for (int i = 1; i < mass.Length; i++)
    {
        if (max < mass[i]) max = mass[i];
        if (min > mass[i]) min = mass[i];
    }
    double result = max - min;
    return result; 
}

double[] array = GetArray(10, 0, 20);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", GetMaxMin(array)));
