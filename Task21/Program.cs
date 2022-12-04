// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите X координату точки A: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки A: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки A: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X координату точки B: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки B: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки B: ");                                                         
int Z2 = Convert.ToInt32(Console.ReadLine());                                                           

double length = Math.Round((Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2))),2); 
Console.WriteLine("Расстояние между точками A и B в 3D пространстве: " + length);
