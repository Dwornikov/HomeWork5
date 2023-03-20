void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99,1000); 
}

int Search(int[] array, int x)
{
 for (int i = 0; i < array.Length; i++)
 {
  if(array[i]%2==0){
x+=1;
  }  
 }
 return x;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
int a= 0;
InputArray(array);
System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
System.Console.WriteLine($"Четных чисел в массиве {Search(array,a)}"); 