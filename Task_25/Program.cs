//  Задача № 25:Найти сумму чисел от 1 до А.
int a=1; 
int b=0;
string s;
int res =0;
Console.WriteLine("Введите число :");
s=Console.ReadLine();
b=Convert.ToInt32(s);
for (int i = a; i<=b; i++)
{

  res = res + i;

}
Console.WriteLine ("Сумма чисел от 1 до " + b + " равна "+ res);
