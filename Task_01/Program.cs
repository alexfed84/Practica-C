// Задача 1: Вывести квадрат числа.

// Метод 1

/*
int a = 5;
int sum = a*a;
Console.WriteLine(sum);
*/

// Метод 2 - запрос на ввоод данных от пользователя;
/*
Console.WriteLine("Введите любое число:");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
int sum = b*b;
Console.WriteLine(sum);
*/

// Задача № 2: По двум заданным числам проверять является ли первое квадратом второго.

// Метод 1
/*
double a = 5;
double b = 16;
if (a*a == b)  Console.WriteLine("a  является квадрантом b");
if (a*a != b) Console.WriteLine("a не является квадрантом b");

// Метод 2

double a = 0;
double b = 0;
string c;

Console.WriteLine("Введите число a:");
c = Console.ReadLine();
a = Convert.ToDouble(c);

Console.WriteLine("Введите  число b:");
c = Console.ReadLine();
b = Convert.ToDouble(c);

if (a*a ==b)                  //(a == Math.Pow(b,2))
{
Console.WriteLine (" a квадрант b ");
}
else 
{
 Console.WriteLine (" a не квадрант b ");
}


// Задача № 3: Даны два числа. Показать большее и меньшее число

int a = 0;
int b = 0;
string c;

Console.WriteLine("Введите число a");
 c = Console.ReadLine();
 a = Convert.ToInt32(c);

Console.WriteLine("Введите число b");
 c = Console.ReadLine();
 b = Convert.ToInt32(c);

if (a > b)
{
    Console.WriteLine("Число a больше числа b");
}
else if (a < b)
{
    Console.WriteLine ("Число a меньше числа b");
}    
else 
{
    Console.WriteLine ("Число a равно числу b");
}


// Задача № 4: По заданному номеру дня недели вывести его название

// string [] dayweek = { "пн", "вт", "ср","чт", "пт", "сб", "вс" };

// Console.WriteLine ("Введите от 1 до 7");
// int 

// Задача № 5: Найти максимальное из трех чисел

int a = 3;
int b = 4;
int c = 5;
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine (max);


// Задача № 6: Написать программу вычисления значения функции y = f(a).  ?????

double F (double a);
{
    return a*a;
}
Console.WriteLine(F(a));



// Задача № 7: Выяснить является ли число чётным.

  // Метод 1

Console.WriteLine ("Введите число a:");
string b = Console.ReadLine();
int a = Convert.ToInt32(b);
if (a%2 == 0) 
{
    Console.WriteLine("Введённое Вами число является чётным.");
} 
else
{
     Console.WriteLine("Введённое Вами число не является чётным.");
}

  // метод 2: из урока, через метод

bool OddOrEven (int a)
{
    return a%2 ==0;
    // if (a%2 == 0) return true; else return false;
}
OddOrEven (5);
if (OddOrEven(5)) Console.WriteLine("Число чётное");
else  Console.WriteLine("Число не чётное");


// Задача № 8:	Показать числа от -N до N.



// Задача № 10: Показать последнюю цифру трехзначного числа.
int number = 462;
int lastnumber = (number % 10);
Console.WriteLine(lastnumber);

// Задача № 11: Показать вторую цифру трехзначного числа.

int number = 462;
int lastnumber = (number/10)%10;
Console.WriteLine(lastnumber);


// Задача № 31:	Задать массив из 8 элементов и вывести их на экран.

int [] a = new int[8]{1,2,3,4,5,6,7,98}; // заполнение массива в ручную.
for (int i = 0; i<a.Length; i++)
Console.Write($"{a[i]} ");



int [] a = new int[8]; // рандомный случай заполнения массива.
for (int i = 0; i<a.Length; i++)
 a[i] = new Random().Next (0, 20);
for (int i = 0; i<a.Length; i++)
Console.Write($"{a[i]} ");

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
 
 // Задача № 32:Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

int [] a = new int[8]{0,1,0,0,1,1,1,0}; 
int i = 0;
while(i<a.Length) //for (int i = 0; i<a.Length; i++)
{
    Console.Write($"{a[i]} ");
    i++;
}

// Задача № 34:	Написать программу замену элементов массива на противоположные.

int [] a = {1, 2, -3, 5, -9, 7};
for (int i = 0; i<a.Length; i++)
{ 
    a[i] = a[i] * (-1);   
    Console.Write($"{a[i]},");
} 


//Задача №35:Определить, присутствует ли в заданном массиве, некоторое число.

int [] a = {1,4,6,13,8,23,34};
int find = 8;
int n = a.Length;
int index = 0;
while (index < n)
{
    if (a[index]==find)
    {
        Console.WriteLine(index);
    }
    index++; //index = index + 1;
    
}

*/
