/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Console.Clear();

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int mi = int.Parse(Console.ReadLine());
int ma = int.Parse(Console.ReadLine());
double[,] OurArray = array(a,b,mi,ma);
ShowArray(OurArray);

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
void ShowArray(double[,] massive)
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