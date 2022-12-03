// Сумма элементов массива с нечетными индексами
int size = 10;
int[] numbers = new int[size];

void FillArray(int[] nums)
{
Random rand = new Random();
int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
    nums[i] = rand.Next (-100, 101);
    }
}
void PrintArray(int[] nums)
{   
int length = nums.Length;
Console.WriteLine ("Вывод массива: ");
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
    if (i%2 == 0)
    {
        sum = sum + numbers[i];
    }
}
Console.WriteLine ("Сумма элементов массива с нечетными индексами = " + sum);
