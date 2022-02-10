//  Задача № 15:Найти третью цифру числа или сообщить, что её нет.

Console.WriteLine("Введите  число:");
string a = Console.ReadLine();
int b = a.Length;

if (b >= 3) Console.WriteLine( "Третья цифра числа: " + a[2]);
else Console.WriteLine("Третья цифра в числе отсутсвует.");