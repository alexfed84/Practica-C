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

