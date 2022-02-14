// Задача № 26:	Возведите число А в натуральную степень B используя цикл.
int a = 4;
int b = 4;
int res = 1;
int i = 0;
while (i<b)
{
    res = res * a;
    i++;
}

Console.WriteLine(res);

