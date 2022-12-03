// Разница между max и min значениями в массиве из вещественных чисел
int size = 6;
double[] numbers = new double[size];

void FillArray(double[] nums, int minValue, int maxValue)
{
Random rand = new Random();
int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
    nums[i] = Math.Round (rand.Next(minValue, maxValue) + rand.NextDouble(), 2);
    }
}
void PrintArray(double[] nums)
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

FillArray(numbers, -5, 7);
PrintArray(numbers);

double max = numbers[0];
double min = max;
for (int i = 1; i < size; i ++)
{
    if (numbers[i] >= max)
    {
        max = numbers[i];
    }
    else
    {
        if (min >= numbers[i])
        {
            min = numbers[i];
        }
    }
}
double diffirence = Math.Round (max - Math.Abs(min), 2);
Console.WriteLine ($"Разница между max ({max}) и min ({min}) значениями чисел в массиве = " + diffirence);