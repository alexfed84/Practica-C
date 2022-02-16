// Задача 23:	Показать таблицу квадратов чисел от 1 до N.

int a=0;
string s;
int res =0;
int i=1;

Console.Write ("Введите число: ");
s=Console.ReadLine();
a=Convert.ToInt32(s);

while ( i <= a )
{
    Console.Write (i+ " = ");
    res = i * i;
    Console.WriteLine (res+ ".");
    i++;
}
