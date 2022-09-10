/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Получение расстояния между двумя точками в 3D пространстве
double GetDistanceTwoPoint(int x1, int y1, int x2, int y2, int z1, int z2) 
{
    double distanse = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

    return distanse;
}

// Ввод координат точек
Console.Write("Введите координаты первой точки X1 Y1 Z1 через пробел: ");
string line1 = Console.ReadLine();
        string[] splitString1 = line1.Split(' ');

        int x1 = Convert.ToInt32(splitString1[0]);
        int y1 = Convert.ToInt32(splitString1[1]);
        int z1 = Convert.ToInt32(splitString1[2]);

Console.Write("Введите координаты второй точки X2 Y2 Z2 через пробел: ");
string line2 = Console.ReadLine();
        string[] splitString2 = line2.Split(' ');

        int x2 = Convert.ToInt32(splitString2[0]);
        int y2 = Convert.ToInt32(splitString2[1]);
        int z2 = Convert.ToInt32(splitString2[2]);

// Расчет расстояния между двумя точками на плоскости
double result = GetDistanceTwoPoint(x1, y1, x2, y2, z1, z2);
Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");