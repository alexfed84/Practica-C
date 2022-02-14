// Задача № 16:	Дано число обозначающее день недели. Выяснить является номер дня недели выходным.


Console.WriteLine ("Введите число  от 1 до 7:");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);

if (b == 6) Console.WriteLine("Ввёденое число является субботой.");
if (b == 7) Console.WriteLine("Ввёденое число является воскресеньем.");
else Console.WriteLine("Сегодня трудовые будни!");


