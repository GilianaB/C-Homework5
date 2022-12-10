Console.WriteLine("введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите массив");
double [] array = new double [length];
for (int i=0; i<array.Length; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine($"Разница {Operation(array)}");


double Operation(double [] array)
{
    double max=array[0];
    double min=array[0];
    for(int i=0; i<array.Length; i++)
    {
       if (array[i]>max)
       max=array[i];
    }
    Console.WriteLine($"максимальное число {max}");
    for(int i=0; i<array.Length; i++)
    {
       if (array[i]<min)
       min=array[i];
       
    }
    Console.WriteLine($"минимальное число {min}");
    if (min<0)
    min = - min;
    return max-min;
}