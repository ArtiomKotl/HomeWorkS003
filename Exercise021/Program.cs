// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int getMean(string pointName, string coordName)
{
  int pointSize = 0;
  bool thisNumber = false;

  while (!thisNumber)
  {
    Console.Write($"Введите координату {coordName} точки {pointName}: ");
    thisNumber = int.TryParse(Console.ReadLine(), out pointSize);
  }
  return pointSize;
}

Console.WriteLine("Найдём расстояние между двумя точками в 3D пространстве:");
int x1 = getMean("A", "x");
int y1 = getMean("A", "y");
int z1 = getMean("A", "z");

int x2 = getMean("B", "x");
int y2 = getMean("B", "y");
int z2 = getMean("B", "z");

double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
System.Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> расстояние между ними в 3D пространстве ({Math.Round(dist, 2)})");

