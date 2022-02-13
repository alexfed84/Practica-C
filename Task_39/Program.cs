//Задача № 39:	Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int a = 0;
string b = string.Empty;
int[] array = new int[a];


void Input(int[] arr)
{  Console.WriteLine("Введите размер массива:");
   b = Console.ReadLine();
   a = Convert.ToInt32(b);
}  

void Solve(int[] arr) 
{    
  for(int i=0; i<arr.Length; i++)         
     arr[i] =new Random().Next(0, 6); 
  
  for (int i = 0; i < arr.Length; i++)

    System.Console.Write(arr[i] + " ");
}
         
void Print(int[] arr)
{
for (int i = 0; i < array.Length/2; i++)

    System.Console.Write(array[i]*array[a-1-i] + " ");
}

Input(arr);
Print(arr); 
Solve(arr);
System.Console.WriteLine();
Print(array);


