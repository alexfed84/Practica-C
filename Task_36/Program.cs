//Задача №36:	Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
/*
int [] array = new int[10];

void FillArray(int [] collection)
{
   int lenght = collection.Length;  // длинна массива
   int index = 0;
   while (index < lenght)
   {
       collection [index] = new Random().Next(100,110);
       index++; //index = index + 1
   } 
}

void PrintArray(int[] col)
{ 
     int count = col.Length;
     int position = 0;
     while (position < count)
     {
         Console.WriteLine(col[position]);
         position++;
         if (array[position]%2==0) Console.WriteLine("Чётные числа");
         else Console.WriteLine("НеЧётные числа");
     }
}

FillArray(array);  // метод заполняет массив
PrintArray(array); // метод печатает массив
*/
