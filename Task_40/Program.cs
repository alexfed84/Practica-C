// Задача № 40:	В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
int [] array = {2, 21, 57, 4, 9, 10, 33, 8, 13};

int max = Max (
 Max (array[0], array[1], array[2]),
 Max (array[3], array[4], array[5]),
 Max (array[6], array[7], array[8])
);
Console.WriteLine(max);
