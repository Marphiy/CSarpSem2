int[] nums = new int[100];
Random num = new Random();
for (int i = 0; i < 100; i++)
{
    nums[i] = num.Next(1, 100);
}

int[] newNums = new int[100];
Console.Clear();
Console.WriteLine("Введите цифру (0 - 9), которую желаете удалить из массива:");
int delnum = Convert.ToInt32(Console.ReadLine());
int j = 0;
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 10 ==  delnum || nums[i] / 10 == delnum && i < nums.Length)
    {
        i++;
        count++;
        for (int k = i; k < nums.Length; k++)
        {
            if (nums[i] % 10 == delnum || nums[i] / 10 == delnum && i < nums.Length)
            {
                i++;
                count++;
            }
        }
    }
    if (i < nums.Length)
    {
        newNums[j] = nums[i];
        j++;
    }
}

void ArrPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}


int[] outArray = new int[nums.Length - count];
for (int i = 0; i < outArray.Length; i++)
{
    outArray[i] = newNums[i];
}
Console.WriteLine("Исходный массив:");
ArrPrint(nums);
Console.WriteLine($"Удаляем из массива числа, содержащие цифру {delnum}");
Console.WriteLine("Конечный массив:");
ArrPrint(outArray);
if (count % 10 == 1) Console.WriteLine($"Удалено {count} число, содержащее цифру {delnum}");
else if (count % 10 > 1 && count % 10 < 5) Console.WriteLine($"Удалено {count} числа, содержащих цифру {delnum}");
else if (count % 10 > 5) Console.WriteLine($"Удалено {count} чисел, содержащих цифру {delnum}");