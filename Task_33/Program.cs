// Задача №33:Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

System.Int32[] a = {-8,-7,-5,-4,-3,-1,3,4,5,6,8,9};
int sumPos = 0;
int sumNeg = 0;
for (int i=0; i < a.Length; i++)
{
   if (a[i]>0) sumPos =sumPos + a[i];
   if (a[i]<0) sumNeg = sumNeg + a[i];
}
Console.WriteLine(sumPos);
Console.WriteLine(sumNeg);
