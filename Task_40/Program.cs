// Задача № 40:	В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
int [] array = {2, 45, 57, 6, 9, 10, 33, 8, 13};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} 

int max = Max (
 Max (array[0], array[1], array[2]),
 Max (array[3], array[4], array[5]),
 Max (array[6], array[7], array[8])
);
Console.WriteLine(max);

int Min(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 < result) result = arg2;
    if (arg3 < result) result = arg3;
    return result;
} 

int min = Min (
 Min (array[0], array[1], array[2]),
 Min (array[3], array[4], array[5]),
 Min (array[6], array[7], array[8])
);
Console.WriteLine(min);

Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
