// Задача № 37:	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].
int [] arr = new int [123];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
  arr = new Random().Next(0,122);
  if(arr[i]> arr[9] && arr[i] <= arr[98]) 
  count++;

}

Console.WriteLine("Количество элементов из отрезка [10,99] = ", + count);




