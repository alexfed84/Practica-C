// Задача № 30:	Показать кубы чисел, заканчивающихся на четную цифру.
int [] a = {1,2,3,4,5,6,7};
for (int i=0; i<a.Length; i++)
if (a[i]%2==0)
Console.WriteLine("{0} в кубе {1}",a[i], Math.Pow(a[i],3) );
