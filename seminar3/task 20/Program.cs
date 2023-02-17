// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,10 
// A (7,-5); B (1,-1) -> 7,21

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double xa = ReadNumber("Введите координату точки A по X");
double ya = ReadNumber("Введите координату точки A по Y");
double xb = ReadNumber("Введите координату точки B по X");
double yb = ReadNumber("Введите координату точки B по Y");

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
Console.WriteLine($"{res:f2}");
