// Задача № 48:	Показать двумерный массив размером m × n заполненный целыми числами.

int [,] array = new int [3,4];
int i=0;
int j=0;
//array[i,j] = new Random().Next();
for( i = 0; i<array.GetLength(0); i++)
{
   for (j = 0; j<array.GetLength(1); j++)
   {
       array[i,j] = new Random().Next(1,8);
       Console.Write ($"{array[i,j]} ");
       
   }
 Console.WriteLine ();

}

