 //Задача №36:	Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] a = new int[7];
int chet = 0;
int nechet = 0;

for (int i=0; i < a.Length; i++)
{
    a[i] = new Random().Next(100,200);
    if (a[i]%2 ==0) chet ++;
    if (a[i]%2 !=0) nechet ++;
    
}

Console.WriteLine("Количество четных элементов массива " + chet);
Console.WriteLine("Количество нечётных элементов массива " + nechet);
