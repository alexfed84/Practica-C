// Задача № 19:	Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0.
double x = 0;
double y = 0;
string c;

Console.WriteLine("Введите координату x:");
c = Console.ReadLine();
x = Convert.ToDouble(c);

Console.WriteLine("Введите координату y:");
c = Console.ReadLine();
y = Convert.ToDouble(c);

if(x > 0 && y > 0) Console.WriteLine("Точка с координатами Х = " + x + " Y = " + y + " находится в первой четверти");
if(x < 0 && y > 0) Console.WriteLine("Точка с координатами Х = " + x + " Y = " + y + " находится во второй четверти");
if(x < 0 && y < 0) Console.WriteLine("Точка с координатами Х = " + x + " Y = " + y + " находится в третьей четверти");
if(x > 0 && y < 0) Console.WriteLine("Точка с координатами Х = " + x + " Y = " + y + " находится в четвёртой четверти");






