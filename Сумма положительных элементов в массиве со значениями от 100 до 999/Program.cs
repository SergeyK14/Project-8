// Количество четных чисел в случайном массиве 
//из трехзначных положительных чисел
int size = 11;
int[] numbers = new int[size];

void FillArray(int[] nums)
{
Random rand = new Random();
int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
    nums[i] = rand.Next (100, 1000);
    }
}
void PrintArray(int[] nums)
{   
int length = nums.Length;
Console.WriteLine ("Массив: ");
    for (int i = 0; i < length; i++)
    {
    Console.Write (nums[i] + " ");
    }
Console.WriteLine();
Console.WriteLine();
}

FillArray(numbers);
PrintArray(numbers);

int sum = 0;
for (int i = 0; i < size; i ++)
{
    if (numbers[i]%2 == 0)
    {
        sum += 1;
    }
}
Console.WriteLine ("Количество четных элементов в массиве = " + sum);
