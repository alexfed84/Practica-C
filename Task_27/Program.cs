// Задача № 27:	Определить количество цифр в числе

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