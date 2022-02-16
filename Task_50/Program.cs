//Задача № 50:	В двумерном массиве n×k заменить четные элементы на противоположные.

int [,] array = new int [2,4];
int i=0;
int j=0;
//array[i,j] = new Random().Next();
for( i = 0; i<array.GetLength(0); i++)
{
   for (j = 0; j<array.GetLength(1); j++)
   {
       array[i,j] = new Random().Next(1,8);
       Console.Write($"{array[i,j]} " + " ");
       if (j%2 ==0) array[i,j]=array[i,j]*-1;
       Console.Write ($"{array[i,j]} " + " ");
   }
  
 Console.WriteLine ();
 
}

//Console.WriteLine ($"{array[i,j]} ");