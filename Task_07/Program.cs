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

  // метод 2: из урока, через метод.

bool OddOrEven (int a)
{
    return a%2 ==0;
    // if (a%2 == 0) return true; else return false;
}
OddOrEven (5);
if (OddOrEven(5)) Console.WriteLine("Число чётное");
else  Console.WriteLine("Число не чётное");

