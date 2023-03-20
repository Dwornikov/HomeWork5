void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,11); 
}
int SumNegativePosition(int[] array, int x){
 for (int i = 1; i < array.Length; i+=2)
 {
   x+=array[i];
 }
 return x;
}
Console.Clear();
System.Console.WriteLine("Введите кол-во элементов в массиве: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = new int[N];
int summ = 0;
InputArray(array);
System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
System.Console.WriteLine($"Сумма чисел в нечетных позициях {SumNegativePosition(array,summ)}");