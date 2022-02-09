int a=0; 
int b=0;
string c;

Console.WriteLine("Введите число в последовательности от -N:");
c=Console.ReadLine();
a=Convert.ToInt32(c);

Console.WriteLine("Введите число в последовательности до N:");
c=Console.ReadLine();
b=Convert.ToInt32(c);

while (a!=b)
{
    a++;
    Console.Write($"{a}" + " ");
}
