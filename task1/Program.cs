Console.WriteLine("введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [length];
Random random = new Random();
for (int i=0; i<array.Length; i++)
{
    array[i] = random.Next(100,1000);
}

Console.WriteLine(string.Join(",", array));
Console.WriteLine(Count(array));

int Count(int [] array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        count++;
    }
    return count;
}