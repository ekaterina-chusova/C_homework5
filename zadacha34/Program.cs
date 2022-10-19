// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

void FullArray(int[] array) // заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}


void EvenNumber(int[] array) // нахождение четных чисел
{
    int sum = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum = sum + array[i];
            count++; 
        }
    }
    Console.WriteLine($"Количество чётных элементов в массиве равно {count}, а их сумму равна {sum}");
}

Console.Write("Введите количество чисел в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[x];
FullArray(arr);
Console.WriteLine();
EvenNumber(arr);