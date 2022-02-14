// Задача № 27:	Определить количество цифр в числе
/*
string text ="456547"; 

int lot (string text)
{
    int count  = 0;
    for (int i = 0; i < text.Length; i++)
    {
        count++;
    }
    return count;
}

Console.WriteLine("Количество цифр в данном числе:"  + lot(text));
*/

// Второй вариfнт решения, быстрее просчитывает.
int n = 1234;
int n1;
int count = 0;
 n1=n;
while ( n !=0)
{
  n = n/10;  
  count++;
}

Console.WriteLine("{0,2} {1,2}",n1, count );
