// Задача № 12:	Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.


int a = new Random().Next(10,99);
Console.WriteLine(a);

int [] array = new int[2];
int i = 0;
while (i < array.Length)
{
    
    array[i] = a%10;
    a = a/10;
    i++;
}
int max = array [0];

while (i < array.Length)
{
    
    if (array[i] > max) max = array[i];
    i++;
}

Console.WriteLine("Наибольшая цифра числа: " + max);