// Задача № 13:	Удалить вторую цифру трёхзначного числа.

string a = "123";

string Delete (string a, char OldValue, char NewValue)
{
    int result = String.Empty;
    for (int i =0; i<a.Length; i++)
    {
        if (a[1]== OldValue ) result = result + NewValue;
    }
    return result;
}
string newa = Delete(a, "2", "0");



Console.WriteLine(newa);

//Console.WriteLine("Get element by index s12[3]: " + s12[3]);