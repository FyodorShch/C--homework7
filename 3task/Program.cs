/* 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

Console.WriteLine("Введите размер матрицы и границы чисел");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int mi = Convert.ToInt32(Console.ReadLine());
int ma = Convert.ToInt32(Console.ReadLine());

int[,] OurMass = array(a,b,mi,ma);
ShowArray(OurMass);
AverageOfLines(OurMass);

int[,] array(int size1, int size2, int min, int max)
{
    int[,] massiv = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            massiv[i, j] = new Random().Next(min, max + 1);
        }
    }
    return massiv;
}
void ShowArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]:f5} ");
        }
        Console.WriteLine();
    }
}
void AverageOfLines(int[,] mass)
{
    double[] averArray = new double[mass.GetLength(0)];
    for (int k = 0; k > averArray.Length; k++)
    {
        averArray[k] = 0;
    }
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        for (int j = 0; j < mass.GetLength(0); j++)
        {
            averArray[j] += Convert.ToInt32(mass[j, i]);
        }
    }
    for(int p=0;p<averArray.Length;p++)
    {
        averArray[p] /= mass.GetLength(1);
        Console.WriteLine($"Среднее арифметическое {p}-й строки равно {averArray[p]}");
    }
}