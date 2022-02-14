// Задача № 45.	Показать числа Фибоначчи.
int [] array =  new int [5];
array[0] = 1;
array[1] = 1;
int sumarray;
for (int i=0; i<array.Length; i++)
{
   array[i] = array[i-1] + array[i-2]; 
   Console.WriteLine("ЧИсло Фибоначчи {0} равно {1}",i,array[i]);
}

