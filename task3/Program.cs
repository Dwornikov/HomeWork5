void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
         array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
}
double Max(double [] array, double maximum){
maximum=array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(maximum<array[i]){
            maximum=array[i];
        }
    }
return maximum;
}
double Min(double [] array, double minimum){
minimum=array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(minimum>array[i]){
            minimum=array[i];
        }
    }
return minimum;
}
Console.Clear();
System.Console.WriteLine("Введите кол-во элементов в массиве: ");
int N = int.Parse(Console.ReadLine()!);
double[] array = new double[N];
double max = 0;
double min = 0;
InputArray(array);
System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
System.Console.WriteLine($"Максимальное значение в массиве {Max(array,max)}");
System.Console.WriteLine($"Минимальное значение в массиве {Min(array,min)}");
System.Console.WriteLine($"Разница между максимальным и минимальным значением {Max(array,max)-Min(array,min)}");