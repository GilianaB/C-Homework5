Console.WriteLine("введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите массив");
int [] array = new int [length];
for (int i=0; i<array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Сумма элементов на нечетных позициях {Sum(array)}");

int Sum(int [] array)
{
    int sum=0;
    for(int i=1; i<array.Length; i=i+2)
    {
       sum=sum+array[i];
    }
    return sum;
}