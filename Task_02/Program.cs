// Задача № 2: По двум заданным числам проверять является ли первое квадратом второго.
/*
// Метод 1

double a = 5;
double b = 16;
if (a*a == b)  Console.WriteLine("a  является квадрантом b");
if (a*a != b) Console.WriteLine("a не является квадрантом b");
*/
// Метод 2

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
