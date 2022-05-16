/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
int GetNumber(string msg)
{
while(true)
{
Console.WriteLine(msg);
string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        return number;
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести число.");
    }
}
}
double GetLengthVector(double x1, double y1, double x2, double y2)
{
    double difx = Math.Pow((x1-x2), 2);
    double dify = Math.Pow((y1-y2), 2);
    double length = Math.Sqrt(difx + dify);
    return length;
}
int x1 = GetNumber("Введите координату точки A по оси x:");
int y1 = GetNumber("Введите координату точки A по оси y:");
int x2 = GetNumber("Введите координату точки B по оси x:");
int y2 = GetNumber("Введите координату точки B по оси y:");

double result = GetLengthVector( x1,  y1,  x2,  y2);
Console.WriteLine(result);
