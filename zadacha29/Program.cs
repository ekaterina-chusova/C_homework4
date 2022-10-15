// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите количество элементов в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[x];
FullArray(arr);