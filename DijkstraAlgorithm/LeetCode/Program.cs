using LeetCode;

TwoSum twoSumInstance = new();

int[] nums = { 2, 7, 11, 15 };

var result = twoSumInstance.TwoSumMethod(nums, 9);

foreach (var item in result)
{
    Console.WriteLine(item.ToString());
}