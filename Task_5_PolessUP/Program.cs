int[] nums = new int[] {2, 3, 1};
Console.WriteLine("Ввод: [" + string.Join("; ", nums) + "]");

Console.WriteLine("Вывод: " + IndexMaxElementOnGroup(nums));
Console.ReadLine();

int IndexMaxElementOnGroup(int[] numbers)
{
    int[] nums = new int[numbers.Length];
    Array.Copy(numbers, nums, numbers.Length);
    Array.Sort(nums);
    return Array.IndexOf(numbers, nums[^1]);
}