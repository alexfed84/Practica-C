// Задача № 49:	Показать двумерный массив размером m×n заполненный вещественными числами.


double [,] array = new double [3,4];

for( int i = 0; i<array.GetLength(0); i++)
{
   for (int j = 0; j<array.GetLength(1); j++)
   {
       array[i,j] = new Random().NextDouble();
       Console.Write ($"{array[i,j]} ");
   }
 Console.WriteLine ();

}

