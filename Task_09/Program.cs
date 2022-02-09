int a=0; 
int b=0;
string c;

Console.WriteLine("Введите число в последовательности от 1:");
c=Console.ReadLine();
a=Convert.ToInt32(c);

Console.WriteLine("Введите число в последовательности до N:");
c=Console.ReadLine();
b=Convert.ToInt32(c);

while (a!=b)
{
    if (a%2 == 0)
    Console.Write($"{a}" + " ");

    a++;

}
