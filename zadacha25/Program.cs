// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Через метод
Console.Clear();

void Degree(int x, int y)
{
    double result = Math.Pow(x, y);
    Console.WriteLine($"Число {x} в степени {y} равно {result}");
}

Console.WriteLine("Введите два целых числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Degree(A, B);


// Через цикл

Console.WriteLine();

Console.WriteLine("Введите два целых числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int compos = 1;
for (int i = 1; i <= B; i++)
{
    compos = compos * A;
}
Console.WriteLine($"Число {a} в степени {b} равно {compos}");


