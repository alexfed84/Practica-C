int a = 4;
Console.WriteLine("Введиет число от 1 до 10:");
string b = Console.ReadLine();
int c = Convert.ToInt32(b);
if (a == c) Console.WriteLine("Введёное Вами число соотвествует заданному.");
else Console.WriteLine("Введёное Вами число несоотвествует заданному.");