// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

void FullArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().NextDouble();
       Console.Write($"{array[i]} "); 
    }   
}

Console.Write("Введите количество чисел в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[x];
FullArray(arr);
Console.WriteLine();

double max = arr[0];
double min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}

double result = max - min;
Console.WriteLine($"Разницу между максимальным элементом {max} и минимальным элементом массива {min} равна {result}");