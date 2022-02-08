// Задача № 31: Задать массив из 8 элементов и вывести их на экран.
/*
int [] a = new int[8]{1,2,3,4,5,6,7,98}; // заполнение массива в ручную.
for (int i = 0; i<a.Length; i++)
Console.Write($"{a[i]} ");
*/

int [] a = new int[8]; // рандомный случай заполнения массива.
for (int i = 0; i<a.Length; i++)
 a[i] = new Random().Next (0, 20);
for (int i = 0; i<a.Length; i++)
Console.Write($"{a[i]} ");

