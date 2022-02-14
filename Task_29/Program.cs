// Задача № 29:	Написать программу вычисления произведения чисел от 1 до N.
int [] a =  {1,2,3,4};
int res = 1;
for ( int i = 0; i<a.Length; i++)
{
    res = res * a[i];

}
Console.WriteLine ( res );

