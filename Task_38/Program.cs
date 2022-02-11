// Задача № 38:	Найти сумму чисел одномерного массива стоящих на нечетной позиции.

int [] a = {12, 15, 8, 6, 20, 3, 11};
int nechet = 0;
for (int i=0; i < a.Length; i++)
{
    if (a[i]%2 !=0) nechet = nechet+a[i];
}

Console.WriteLine("Сумма нечётных элементов массива " + nechet);

