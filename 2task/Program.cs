/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

Console.Clear();

Console.WriteLine("Введите размер матрицы и границы чисел");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int mi = Convert.ToInt32(Console.ReadLine());
int ma = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки");
int px = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int py = Convert.ToInt32(Console.ReadLine());

double[,] massive = array(a, b,mi,ma);
CheckOfElement(massive, px,py);

double[,] array(int size1, int size2, int min, int max)
{
    double[,] massiv = new double[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            massiv[i, j] = new Random().NextDouble()*(max-min);
        }
    }
    return massiv;
}
void CheckOfElement(double[,] mass, int x, int y)
{
    if (x < mass.GetLength(0) && y < mass.GetLength(1))
    {
        Console.WriteLine($"Элемент на {x} строке и в {y} столбце — {mass[x, y]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}