// Задача №17:	По двум заданным числам проверять является ли одно квадратом другого.

double a = 0;
double b = 0;
string c;

Console.WriteLine("Введите число a:");
c = Console.ReadLine();
a = Convert.ToDouble(c);

Console.WriteLine("Введите  число b:");
c = Console.ReadLine();
b = Convert.ToDouble(c);

if (a*a ==b)                  //(a == Math.Pow(b,2)) ??
{
Console.WriteLine (" a квадрант b ");
}
else 
{
 Console.WriteLine (" a не квадрант b ");
}
