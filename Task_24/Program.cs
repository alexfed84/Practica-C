// Задача № 24:	Найти кубы чисел от 1 до N.

int a=1; 
int b=0;
string s;

Console.WriteLine("Введите число :");
s=Console.ReadLine();
b=Convert.ToInt32(s);

while(a <= b)
{
    Console.WriteLine ($"Значение числа {b} в кубе = {b*b*b}");
    b++;
    return;
}
