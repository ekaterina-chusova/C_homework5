// Задача 36: Задайте одномерный массив, заполненный случайными числами. Н
// айдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.Write("Введите количество чисел в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");
}

int sum = 0;
for (int i = 0; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");