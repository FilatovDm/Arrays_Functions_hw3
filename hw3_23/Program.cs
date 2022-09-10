/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int[] GetCubeNumer(int numer)
{
    int[] squaresNumers = new int[numer];

    // Заполнение массива результата
    for (int i = 1; i <= numer; i++)
    {
        squaresNumers[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
    }

    return squaresNumers;
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine());

int[] result = GetCubeNumer(num);
for (int i = 0; i < result.Length; i++) 
{
    Console.WriteLine(result[i]);
}
